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

namespace Supermarket.View
{
    public partial class CustomersForm : Form
    {
        private readonly CustomerDAO customerDAO;
        private bool EditMode;
        private bool IsNew;

        internal CustomersForm(ref CustomerDAO customerDAO)
        {
            InitializeComponent();
            this.customerDAO = customerDAO;
            LoadCustomerList();
            EditMode = false;
            IsNew = false;

        }//Final de clase

        private void LoadCustomerList()
        {
            DgCustomers.Rows.Clear();
            var customers = this.customerDAO.GetCustomerList();

            if (customers.Count > 0)
            {
                foreach (KeyValuePair<int, Customer> customerKV in customers)
                {
                    DgCustomers.Rows.Add(
                        customerKV.Value.Id,
                        customerKV.Value.FirstName,
                        customerKV.Value.LastName,
                        customerKV.Value.DocumentNumber,
                        customerKV.Value.PhoneNumber,
                        customerKV.Value.Birthday,
                        customerKV.Value.Email,
                        customerKV.Value.Address
                    );
                }
            }
            else
            {
                MessageBox.Show("No hay clientes disponibles.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//Final de clase

        private void DgCustomers_Click(object sender, EventArgs e)
        {
            if (DgCustomers.CurrentRow != null)
            {
                TxtId.Text = DgCustomers.CurrentRow.Cells[0].Value.ToString();     
                TxtFirstName.Text = DgCustomers.CurrentRow.Cells[1].Value.ToString(); 
                TxtLastName.Text = DgCustomers.CurrentRow.Cells[2].Value.ToString();  
                TxtDocumento.Text = DgCustomers.CurrentRow.Cells[3].Value.ToString(); 
                TxtCelular.Text = DgCustomers.CurrentRow.Cells[4].Value.ToString();   
                TxtCumple.Text = DgCustomers.CurrentRow.Cells[5].Value.ToString();    
                TxtEmail.Text = DgCustomers.CurrentRow.Cells[6].Value.ToString();    
                TxtPassword.Text = DgCustomers.CurrentRow.Cells[7].Value.ToString(); 
            }

        }//Final de clase

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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
                if (SaveCustomer())
                {
                    IsNew = false;
                    EditMode = false;
                }
            }
            ActivateControls(EditMode);

        }//Final de clase

        private void ActivateControls(bool editMode)
        {
            BtnNew.Text = editMode ? "Guardar" : "Nuevo";
            BtnNew.Image = editMode ? Resources.save : Resources._new;

            BtnEdit.Text = editMode ? "Cancelar" : "Editar";
            BtnEdit.Image = editMode ? Resources.cancel : Resources.edit;

            TxtFirstName.Enabled = editMode;
            TxtLastName.Enabled = editMode;
            TxtDocumento.Enabled = editMode;
            TxtCelular.Enabled = editMode;
            TxtCumple.Enabled = editMode;
            TxtEmail.Enabled = editMode;
            TxtPassword.Enabled = editMode;

            DgCustomers.Enabled = !editMode;
            BtnDelete.Enabled = !editMode;
            BtnClose.Enabled = !editMode;

            if (editMode)
            {
                TxtFirstName.Focus();
            }

        }//Final de clase

        private bool SaveCustomer()
        {
            if (!AreFieldsFilled())
            {
                return false;
            }

            try
            {
                if (IsNew)
                {
                    Customer customer = new Customer(null, TxtDocumento.Text, TxtFirstName.Text, TxtLastName.Text,
                                                     TxtCelular.Text, TxtCumple.Text, TxtEmail.Text, TxtPassword.Text);

                    if (!customerDAO.AddCustomer(customer))
                    {
                        MessageBox.Show("Error al guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerList();
                }
                else
                {
                    int id = Int32.Parse(TxtId.Text);
                    Customer customer = customerDAO.GetCustomer(id);

                    if (customer != null)
                    {
                        customer.FirstName = TxtFirstName.Text;
                        customer.LastName = TxtLastName.Text;
                        customer.DocumentNumber = TxtDocumento.Text;
                        customer.PhoneNumber = TxtCelular.Text;
                        customer.Birthday = TxtCumple.Text;
                        customer.Email = TxtEmail.Text;
                        customer.Address = TxtPassword.Text;

                        if (!customerDAO.UpdateCustomer(id, customer))
                        {
                            MessageBox.Show("Error al actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        LoadCustomerList();
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
            if (string.IsNullOrWhiteSpace(TxtFirstName.Text) || string.IsNullOrWhiteSpace(TxtLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtDocumento.Text) || string.IsNullOrWhiteSpace(TxtCelular.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;

        }//Final de clase

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                EditMode = false;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(TxtFirstName.Text))
                {
                    MessageBox.Show("Seleccione un cliente de la lista", "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro que desea editar este cliente?",
                                                      "Confirmación de Edición",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                EditMode = true;
                IsNew = false;
            }
            ActivateControls(EditMode);

        }//Final de clase

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgCustomers.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgCustomers.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?",
                                                      "Confirmación de Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (customerDAO.RemoveCustomer(id))
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.", "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LoadCustomerList();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente para eliminar.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

        }//Final de clase

        private void ClearFields()
        {
            TxtId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtDocumento.Text = "";
            TxtCelular.Text = "";
            TxtCumple.Text = ""; 
            TxtEmail.Text = "";
            TxtPassword.Text = "";
            TxtCumple.Text = "";

        }//Final de clase

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }//Final de clase

        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }//Final de clase

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }//Final de clase

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }//Final de clase

        private void DgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//Ultima linea
}
