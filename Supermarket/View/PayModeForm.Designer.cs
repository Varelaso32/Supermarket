
namespace Supermarket.View
{
    partial class PayModeForm
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.IdPaymode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(102, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(133, 22);
            this.TxtName.TabIndex = 3;
            this.TxtName.Text = "Pay mode name";
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(102, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(133, 22);
            this.TxtId.TabIndex = 2;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Location = new System.Drawing.Point(632, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(45, 332);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(152, 70);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(45, 230);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(152, 70);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket.Properties.Resources.edit;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(45, 136);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(152, 70);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket.Properties.Resources._new;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNew.Location = new System.Drawing.Point(45, 37);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(152, 67);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "&New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // DgPayMode
            // 
            this.DgPayMode.AllowUserToAddRows = false;
            this.DgPayMode.AllowUserToDeleteRows = false;
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaymode,
            this.NamePayMode});
            this.DgPayMode.Location = new System.Drawing.Point(41, 227);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.ReadOnly = true;
            this.DgPayMode.RowHeadersWidth = 51;
            this.DgPayMode.RowTemplate.Height = 24;
            this.DgPayMode.Size = new System.Drawing.Size(528, 226);
            this.DgPayMode.TabIndex = 2;
            this.DgPayMode.Click += new System.EventHandler(this.DgPayMode_Click);
            // 
            // IdPaymode
            // 
            this.IdPaymode.HeaderText = "ID";
            this.IdPaymode.MinimumWidth = 6;
            this.IdPaymode.Name = "IdPaymode";
            this.IdPaymode.ReadOnly = true;
            this.IdPaymode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdPaymode.Width = 125;
            // 
            // NamePayMode
            // 
            this.NamePayMode.HeaderText = "Name";
            this.NamePayMode.MinimumWidth = 6;
            this.NamePayMode.Name = "NamePayMode";
            this.NamePayMode.ReadOnly = true;
            this.NamePayMode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NamePayMode.Width = 200;
            // 
            // PayModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 529);
            this.ControlBox = false;
            this.Controls.Add(this.DgPayMode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pay Mode Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView DgPayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaymode;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePayMode;
    }
}