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

namespace Supermarket.View // Samuel Varela Morales
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoriesDAO categoriesDAO;
        private bool EditMode;
        private bool IsNew;

        internal CategoriesForm(ref CategoriesDAO categoriesDAO)
        {
            InitializeComponent();
            this.categoriesDAO = categoriesDAO;
            LoadCategoryList();
            EditMode = false;
            IsNew = false;
        } // Final

        private void LoadCategoryList()
        {
            DgCategories.Rows.Clear();
            var categories = this.categoriesDAO.GetCategoryList();

            if (categories.Count > 0)
            {
                foreach (KeyValuePair<int, Category> categoryKV in categories)
                {
                    DgCategories.Rows.Add(
                        categoryKV.Value.Id,
                        categoryKV.Value.Name,
                        categoryKV.Value.Description
                    );
                }
            }
            else
            {
                MessageBox.Show("No hay categorías disponibles.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Final de clase

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
                if (SaveCategory())
                {
                    IsNew = false;
                    EditMode = false;
                }
            }
            ActivateControls(EditMode);

        } // Final de clase

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

        } // Final de clase

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgCategories.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgCategories.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar esta categoría?",
                                                      "Confirmación de Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (categoriesDAO.RemoveCategory(id))
                    {
                        MessageBox.Show("Categoría eliminada exitosamente.", "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LoadCategoryList();
                        ClearFieldsPlaceHolder();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoría.", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una categoría para eliminar.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

        } // Final de clase

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Final de clase


        private void ActivateControls(bool editMode)
        {
            BtnNew.Text = editMode ? "Guardar" : "Nuevo";
            BtnNew.Image = editMode ? Resources.save : Resources._new;

            BtnEdit.Text = editMode ? "Cancelar" : "Editar";
            BtnEdit.Image = editMode ? Resources.cancel : Resources.edit;

            TxtName.Enabled = editMode;
            TxtDescripcion.Enabled = editMode;

            DgCategories.Enabled = !editMode;
            BtnDelete.Enabled = !editMode;
            BtnClose.Enabled = !editMode;

            if (editMode)
            {
                TxtName.Focus();
            }
            else if (IsNew)
            {
                ClearFieldsPlaceHolder();
            }
        } // Final de clase

        private bool SaveCategory()
        {
            if (!AreFieldsFilled())
            {
                return false;
            }

            try
            {
                if (IsNew)
                {
                    Category category = new Category(null, TxtName.Text, TxtDescripcion.Text);

                    if (!categoriesDAO.AddCategory(category))
                    {
                        MessageBox.Show("Error al guardar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoryList();
                }
                else
                {
                    int id = Int32.Parse(TxtId.Text);
                    Category category = categoriesDAO.GetCategory(id);

                    if (category != null)
                    {
                        category.Name = TxtName.Text;
                        category.Description = TxtDescripcion.Text;

                        if (!categoriesDAO.UpdateCategory(id, category))
                        {
                            MessageBox.Show("Error al actualizar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        MessageBox.Show("Categoría actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryList();
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

        }//Final Clase

        private bool AreFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;

        } // Final de clase

        private void DgCategories_Click(object sender, EventArgs e)
        {

            if (DgCategories.CurrentRow != null)
            {
                TxtId.Text = DgCategories.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DgCategories.CurrentRow.Cells[1].Value.ToString();
                TxtDescripcion.Text = DgCategories.CurrentRow.Cells[2].Value.ToString();
            }

        }// Final de clase

        private void ClearFields()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtDescripcion.Text = "";

        } // Final de clase

        private void ClearFieldsPlaceHolder()
        {
            TxtId.Text = "";
            TxtName.Text = "Ingrese nombre ";
            TxtDescripcion.Text = " Ingrese una descripcion";

        }//Final de clase
    }
}
