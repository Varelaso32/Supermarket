
namespace Supermarket.View
{
    partial class ProductsForm
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
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgProducts = new System.Windows.Forms.DataGridView();
            this.IdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCategoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Enabled = false;
            this.TxtCategoria.Location = new System.Drawing.Point(31, 340);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(162, 22);
            this.TxtCategoria.TabIndex = 9;
            this.TxtCategoria.Text = "Ingrese la categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria ID";
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(31, 268);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(162, 22);
            this.TxtStock.TabIndex = 7;
            this.TxtStock.Text = "Ingrese el stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(31, 197);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(162, 22);
            this.TxtPrecio.TabIndex = 5;
            this.TxtPrecio.Text = "Ingrese precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(31, 128);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(162, 22);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.Text = "Ingrese name producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(31, 57);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(162, 22);
            this.TxtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Location = new System.Drawing.Point(278, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(312, 37);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(80, 63);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket.Properties.Resources._new;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNew.Location = new System.Drawing.Point(21, 37);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(80, 63);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "&New";
            this.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket.Properties.Resources.edit;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.Location = new System.Drawing.Point(119, 37);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(80, 63);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(217, 37);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 63);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgProducts
            // 
            this.DgProducts.AllowUserToAddRows = false;
            this.DgProducts.AllowUserToDeleteRows = false;
            this.DgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducts,
            this.NameProductos,
            this.PrecioProducts,
            this.StockProduct,
            this.CategoriaProducts});
            this.DgProducts.Location = new System.Drawing.Point(278, 162);
            this.DgProducts.Name = "DgProducts";
            this.DgProducts.ReadOnly = true;
            this.DgProducts.RowHeadersWidth = 51;
            this.DgProducts.RowTemplate.Height = 24;
            this.DgProducts.Size = new System.Drawing.Size(640, 282);
            this.DgProducts.TabIndex = 2;
            this.DgProducts.Click += new System.EventHandler(this.DgProducts_Click);
            // 
            // IdProducts
            // 
            this.IdProducts.HeaderText = "ID";
            this.IdProducts.MinimumWidth = 6;
            this.IdProducts.Name = "IdProducts";
            this.IdProducts.ReadOnly = true;
            this.IdProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdProducts.Width = 50;
            // 
            // NameProductos
            // 
            this.NameProductos.HeaderText = "Nombre";
            this.NameProductos.MinimumWidth = 6;
            this.NameProductos.Name = "NameProductos";
            this.NameProductos.ReadOnly = true;
            this.NameProductos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameProductos.Width = 110;
            // 
            // PrecioProducts
            // 
            this.PrecioProducts.HeaderText = "Precio";
            this.PrecioProducts.MinimumWidth = 6;
            this.PrecioProducts.Name = "PrecioProducts";
            this.PrecioProducts.ReadOnly = true;
            this.PrecioProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioProducts.Width = 110;
            // 
            // StockProduct
            // 
            this.StockProduct.HeaderText = "Stock";
            this.StockProduct.MinimumWidth = 6;
            this.StockProduct.Name = "StockProduct";
            this.StockProduct.ReadOnly = true;
            this.StockProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StockProduct.Width = 110;
            // 
            // CategoriaProducts
            // 
            this.CategoriaProducts.HeaderText = "Categoria";
            this.CategoriaProducts.MinimumWidth = 6;
            this.CategoriaProducts.Name = "CategoriaProducts";
            this.CategoriaProducts.ReadOnly = true;
            this.CategoriaProducts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriaProducts.Width = 110;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgProducts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridView DgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducts;
    }
}