
namespace Supermarket.View
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCumple = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgCustomers = new System.Windows.Forms.DataGridView();
            this.IdCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumpleañosCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContraseñaCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCumple);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtCelular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Enabled = false;
            this.TxtFirstName.Location = new System.Drawing.Point(19, 58);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(176, 22);
            this.TxtFirstName.TabIndex = 1;
            this.TxtFirstName.Text = "Ingrese su nombre";
            this.TxtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Enabled = false;
            this.TxtLastName.Location = new System.Drawing.Point(226, 58);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(176, 22);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.Text = "Ingrese su apellido";
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(435, 21);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(90, 22);
            this.TxtId.TabIndex = 5;
            // 
            // TxtCelular
            // 
            this.TxtCelular.Enabled = false;
            this.TxtCelular.Location = new System.Drawing.Point(226, 119);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(176, 22);
            this.TxtCelular.TabIndex = 9;
            this.TxtCelular.Text = "Ingrese su celular";
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contacto Cel";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Enabled = false;
            this.TxtDocumento.Location = new System.Drawing.Point(19, 119);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(176, 22);
            this.TxtDocumento.TabIndex = 7;
            this.TxtDocumento.Text = "Ingrese su documento";
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Documento";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(226, 179);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(176, 22);
            this.TxtEmail.TabIndex = 13;
            this.TxtEmail.Text = "Ingrese su email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // TxtCumple
            // 
            this.TxtCumple.Enabled = false;
            this.TxtCumple.Location = new System.Drawing.Point(19, 179);
            this.TxtCumple.Name = "TxtCumple";
            this.TxtCumple.Size = new System.Drawing.Size(176, 22);
            this.TxtCumple.TabIndex = 11;
            this.TxtCumple.Text = "DD-MM-YYYY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cumpleaños";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(135, 243);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(176, 22);
            this.TxtPassword.TabIndex = 14;
            this.TxtPassword.Text = "Ingrese una contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contraseña";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Location = new System.Drawing.Point(605, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(153, 173);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 67);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(19, 173);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 67);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket.Properties.Resources.edit;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(153, 49);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 67);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket.Properties.Resources._new;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNew.Location = new System.Drawing.Point(19, 49);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(100, 67);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "&New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // DgCustomers
            // 
            this.DgCustomers.AllowUserToAddRows = false;
            this.DgCustomers.AllowUserToDeleteRows = false;
            this.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCustomers,
            this.FirstNameCustomers,
            this.LastNameCustomers,
            this.DocumentoCustomers,
            this.PhoneCustomers,
            this.CumpleañosCustomers,
            this.EmailCustomers,
            this.ContraseñaCustomers});
            this.DgCustomers.Location = new System.Drawing.Point(46, 332);
            this.DgCustomers.Name = "DgCustomers";
            this.DgCustomers.ReadOnly = true;
            this.DgCustomers.RowHeadersWidth = 51;
            this.DgCustomers.RowTemplate.Height = 24;
            this.DgCustomers.Size = new System.Drawing.Size(831, 231);
            this.DgCustomers.TabIndex = 2;
            this.DgCustomers.Click += new System.EventHandler(this.DgCustomers_Click);
            // 
            // IdCustomers
            // 
            this.IdCustomers.HeaderText = "ID";
            this.IdCustomers.MinimumWidth = 6;
            this.IdCustomers.Name = "IdCustomers";
            this.IdCustomers.ReadOnly = true;
            this.IdCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCustomers.Width = 60;
            // 
            // FirstNameCustomers
            // 
            this.FirstNameCustomers.HeaderText = "FirsName";
            this.FirstNameCustomers.MinimumWidth = 6;
            this.FirstNameCustomers.Name = "FirstNameCustomers";
            this.FirstNameCustomers.ReadOnly = true;
            this.FirstNameCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastNameCustomers
            // 
            this.LastNameCustomers.HeaderText = "LastName";
            this.LastNameCustomers.MinimumWidth = 6;
            this.LastNameCustomers.Name = "LastNameCustomers";
            this.LastNameCustomers.ReadOnly = true;
            this.LastNameCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DocumentoCustomers
            // 
            this.DocumentoCustomers.HeaderText = "Documento";
            this.DocumentoCustomers.MinimumWidth = 6;
            this.DocumentoCustomers.Name = "DocumentoCustomers";
            this.DocumentoCustomers.ReadOnly = true;
            this.DocumentoCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PhoneCustomers
            // 
            this.PhoneCustomers.HeaderText = "Celular";
            this.PhoneCustomers.MinimumWidth = 6;
            this.PhoneCustomers.Name = "PhoneCustomers";
            this.PhoneCustomers.ReadOnly = true;
            this.PhoneCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CumpleañosCustomers
            // 
            this.CumpleañosCustomers.HeaderText = "Cumpleaños";
            this.CumpleañosCustomers.MinimumWidth = 6;
            this.CumpleañosCustomers.Name = "CumpleañosCustomers";
            this.CumpleañosCustomers.ReadOnly = true;
            this.CumpleañosCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EmailCustomers
            // 
            this.EmailCustomers.HeaderText = "Email";
            this.EmailCustomers.MinimumWidth = 6;
            this.EmailCustomers.Name = "EmailCustomers";
            this.EmailCustomers.ReadOnly = true;
            this.EmailCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ContraseñaCustomers
            // 
            this.ContraseñaCustomers.HeaderText = "Contraseña";
            this.ContraseñaCustomers.MinimumWidth = 6;
            this.ContraseñaCustomers.Name = "ContraseñaCustomers";
            this.ContraseñaCustomers.ReadOnly = true;
            this.ContraseñaCustomers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 627);
            this.ControlBox = false;
            this.Controls.Add(this.DgCustomers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCumple;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView DgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumpleañosCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraseñaCustomers;
    }
}