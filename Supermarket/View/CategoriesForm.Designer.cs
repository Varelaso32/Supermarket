
namespace Supermarket.View
{
    partial class CategoriesForm
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
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgCategories = new System.Windows.Forms.DataGridView();
            this.IdCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(454, 36);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(174, 22);
            this.TxtDescripcion.TabIndex = 5;
            this.TxtDescripcion.Text = " Ingrese una descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(214, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(133, 22);
            this.TxtName.TabIndex = 3;
            this.TxtName.Text = "Ingrese nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(55, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(78, 22);
            this.TxtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Location = new System.Drawing.Point(693, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(30, 309);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(90, 62);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(30, 212);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 62);
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
            this.BtnEdit.Location = new System.Drawing.Point(30, 113);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(90, 62);
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
            this.BtnNew.Location = new System.Drawing.Point(30, 36);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(90, 59);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "&New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // DgCategories
            // 
            this.DgCategories.AllowUserToAddRows = false;
            this.DgCategories.AllowUserToDeleteRows = false;
            this.DgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategories,
            this.NameCategories,
            this.DescripcionCategories});
            this.DgCategories.Location = new System.Drawing.Point(28, 141);
            this.DgCategories.Name = "DgCategories";
            this.DgCategories.ReadOnly = true;
            this.DgCategories.RowHeadersWidth = 51;
            this.DgCategories.RowTemplate.Height = 24;
            this.DgCategories.Size = new System.Drawing.Size(634, 280);
            this.DgCategories.TabIndex = 3;
            this.DgCategories.Click += new System.EventHandler(this.DgCategories_Click);
            // 
            // IdCategories
            // 
            this.IdCategories.HeaderText = "ID";
            this.IdCategories.MinimumWidth = 6;
            this.IdCategories.Name = "IdCategories";
            this.IdCategories.ReadOnly = true;
            this.IdCategories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCategories.Width = 80;
            // 
            // NameCategories
            // 
            this.NameCategories.HeaderText = "Nombre";
            this.NameCategories.MinimumWidth = 6;
            this.NameCategories.Name = "NameCategories";
            this.NameCategories.ReadOnly = true;
            this.NameCategories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCategories.Width = 150;
            // 
            // DescripcionCategories
            // 
            this.DescripcionCategories.HeaderText = "Descripcion";
            this.DescripcionCategories.MinimumWidth = 6;
            this.DescripcionCategories.Name = "DescripcionCategories";
            this.DescripcionCategories.ReadOnly = true;
            this.DescripcionCategories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionCategories.Width = 150;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.ControlBox = false;
            this.Controls.Add(this.DgCategories);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView DgCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategories;
    }
}