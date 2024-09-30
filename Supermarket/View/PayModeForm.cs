using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Supermarket.Business;
using Supermarket.Model;
using Supermarket.Properties;

namespace Supermarket.View
{
    public partial class PayModeForm : Form
    {
        private readonly PayModeDAO payModeDAO;
        private bool EditMode;
        private bool IsNew;
        private bool state;

        internal PayModeForm(ref PayModeDAO payModeDAO)
        {
            InitializeComponent();
            this.payModeDAO = payModeDAO;
            LoadPayModeList();
            EditMode = false;
            IsNew = false;

        }//Final de clase

        private void LoadPayModeList()
        {
            DgPayMode.Rows.Clear();
            foreach (KeyValuePair<int, PayMode> payModeKV in this.payModeDAO.GetPayModeList())
            {
                DgPayMode.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name);

            }

        }//Final de clase

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Final de clase

        private void DgPayMode_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();

        }//Final de clase

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                IsNew = true;
            }
            else
            {
                if (SavePayMode() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;

            }
            TxtId.Text = "";
            TxtName.Text = "";
            ActivateControls(EditMode);

        }//Final de clase

        private void ActivateControls(bool editMode)
        {
            BtnNew.Text = editMode ? "Save" : "New";
            BtnNew.Image = editMode ? Resources.save : Resources._new;

            BtnEdit.Text = editMode ? "Cancel" : "Edit";
            BtnEdit.Image = editMode ? Resources.cancel : Resources.edit;

            // Activar o desactivar solo el campo Name
            TxtName.Enabled = editMode;

            // Deshabilitar el DataGridView y otros botones cuando se está editando
            DgPayMode.Enabled = !editMode;
            BtnDelete.Enabled = !editMode;
            BtnClose.Enabled = !editMode;

            // Establecer el foco en TxtName cuando está habilitado
            if (editMode)
            {
                TxtName.Focus();
            }

        }//Final de clase

        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }

            if (IsNew == true)
            {
                PayMode payMode = new PayMode(null, TxtName.Text);

                if (payModeDAO.AddPayMode(payMode) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Pay mode save successfully", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadPayModeList();
            }

            else
            {
                int id = Int32.Parse(TxtId.Text);
                PayMode payMode = payModeDAO.GetPayMode(id);

                if (payMode != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }

                    payMode.Name = TxtName.Text;
                    payModeDAO.UpdatePayMode(id, payMode);
                    LoadPayModeList();
                    return true;

                }
                return false;

            }
            return true;

        }//Final de clase

        private bool IsNameFilled()
        {
            if ((TxtName.Text).Trim().Length == 0)
            {
                MessageBox.Show("The Pay mode name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtName.Focus();
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
                if (TxtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Select one register of the list", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                IsNew = false;

            }
            ActivateControls(EditMode);

        }//Final de clase

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el DataGridView
            if (DgPayMode.CurrentRow != null)
            {
                // Obtener el ID del modo de pago seleccionado
                int id = Convert.ToInt32(DgPayMode.CurrentRow.Cells[0].Value);

                // Confirmar si el usuario quiere eliminar el registro
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Pay Mode?",
                                                      "Delete Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Intentar eliminar el Pay Mode del DAO
                    if (payModeDAO.RemovePayMode(id))
                    {
                        MessageBox.Show("Pay Mode deleted successfully.", "Info",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        // Recargar la lista después de la eliminación
                        LoadPayModeList();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting the Pay Mode.", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Pay Mode to delete.", "Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
    }
}
