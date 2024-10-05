using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket.Business;
using Supermarket.Model;
using Supermarket.Properties;

namespace Supermarket.View //Samuel Varela Morales
{
    public partial class ProductsForm : Form
    {
        private readonly ProductDAO productDAO;
        private bool EditMode;
        private bool IsNew;

        internal ProductsForm(ref ProductDAO productDAO)
        {
            InitializeComponent();
            this.productDAO = productDAO;
            LoadProductList();  
            EditMode = false;
            IsNew = false;

        }//Final

        private void LoadProductList()
        {
            DgProducts.Rows.Clear();
            var products = this.productDAO.GetProductList();

            if (products.Count > 0)
            {
                foreach (KeyValuePair<int, Product> productKV in products)
                {
                    DgProducts.Rows.Add(
                        productKV.Value.Id,
                        productKV.Value.Name,
                        productKV.Value.Price,
                        productKV.Value.Stock,
                        productKV.Value.CategoryId

                    );
                }
            }
            else
            {
                MessageBox.Show("No hay productos disponibles.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Final de clase

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                EditMode = true;
                IsNew = true;
                ClearFields();
            }
            else
            {
                if (SaveProduct())
                {
                    IsNew = false;
                    EditMode = false;
                }
            }
            ActivateControls(EditMode);

        }//Final de clase

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
            }
            else
            {
                EditMode = true;
                IsNew = false;
            }

            ActivateControls(EditMode);

        }//Final de clase

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgProducts.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgProducts.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este producto?",
                                                      "Confirmación de Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (productDAO.RemoveProduct(id))
                    {
                        MessageBox.Show("Producto eliminado exitosamente.", "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LoadProductList();
                        ClearFieldsPlaceHolder();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

        }//Final de clase

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Final de clase

        private void DgProducts_Click(object sender, EventArgs e)
        {
            if (DgProducts.CurrentRow != null)
            {
                TxtId.Text = DgProducts.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DgProducts.CurrentRow.Cells[1].Value.ToString();
                TxtPrecio.Text = DgProducts.CurrentRow.Cells[2].Value.ToString();
                TxtStock.Text = DgProducts.CurrentRow.Cells[3].Value.ToString();
                TxtCategoria.Text = DgProducts.CurrentRow.Cells[4].Value.ToString();
            }

        }//Final de clase

        private void ActivateControls(bool editMode)
        {
            BtnNew.Text = editMode ? "Guardar" : "Nuevo";
            BtnNew.Image = editMode ? Resources.save : Resources._new;

            BtnEdit.Text = editMode ? "Cancelar" : "Editar";
            BtnEdit.Image = editMode ? Resources.cancel : Resources.edit;

            TxtNombre.Enabled = editMode;
            TxtCategoria.Enabled = editMode;
            TxtPrecio.Enabled = editMode;
            TxtStock.Enabled = editMode;

            DgProducts.Enabled = !editMode;
            BtnDelete.Enabled = !editMode;
            BtnClose.Enabled = !editMode;

            if (editMode)
            {
                TxtNombre.Focus();
            }
            else if (IsNew)
            {
                ClearFieldsPlaceHolder();
            }

        }//Final de clase


        private bool SaveProduct()
        {
            if (!AreFieldsFilled())
            {
                return false;
            }

            try
            {
                if (IsNew)
                {
                    Product product = new Product(null, TxtNombre.Text, Convert.ToInt32(TxtPrecio.Text),
                                                  Convert.ToInt32(TxtStock.Text), Convert.ToInt32(TxtCategoria.Text));

                    if (!productDAO.AddProduct(product))
                    {
                        MessageBox.Show("Error al guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductList();
                }
                else
                {
                    int id = Int32.Parse(TxtId.Text);
                    Product product = productDAO.GetProduct(id);

                    if (product != null)
                    {
                        product.Name = TxtNombre.Text;
                        product.CategoryId = Convert.ToInt32(TxtCategoria.Text);
                        product.Price = Convert.ToInt32(TxtPrecio.Text);
                        product.Stock = Convert.ToInt32(TxtStock.Text);

                        if (!productDAO.UpdateProduct(id, product))
                        {
                            MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductList();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }//Final de clase

        private bool AreFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtCategoria.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecio.Text) || string.IsNullOrWhiteSpace(TxtStock.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;

        }//Final de clase

        private void ClearFields()
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            TxtCategoria.Text = ""; 
            TxtPrecio.Text = ""; 
            TxtStock.Text = "";

        }//Final de clase

        private void ClearFieldsPlaceHolder()
        {
            TxtId.Text = "";
            TxtNombre.Text = "Ingrese nombre";
            TxtCategoria.Text = "Ingrese categoría";
            TxtPrecio.Text = "Ingrese precio";
            TxtStock.Text = "Ingrese stock";

        }//Final de clase

    }
}
