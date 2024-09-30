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
            BtnNew.Text = editMode ? "Guardar" : "Nuevo";
            BtnNew.Image = editMode ? Resources.save : Resources._new;

            BtnEdit.Text = editMode ? "Cancelar" : "Editar";
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
                    MessageBox.Show("Error al guardar", "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Modo de pago guardado exitosamente", "Alerta",
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
                MessageBox.Show("El nombre del modo de pago es obligatorio", "Alerta",
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
                    MessageBox.Show("Seleccione un registro de la lista", "Alerta",
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

            if (DgPayMode.CurrentRow != null)
            {
                int id = Convert.ToInt32(DgPayMode.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este Modo de Pago?",
                                                      "Confirmación de Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Intentar eliminar el Pay Mode del DAO
                    if (payModeDAO.RemovePayMode(id))
                    {
                        MessageBox.Show("Modo de Pago eliminado exitosamente.", "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        // Recargar la lista después de la eliminación
                        LoadPayModeList();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el Modo de Pago.", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Modo de Pago para eliminar.", "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
    }
}
