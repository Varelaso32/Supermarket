
namespace Supermarket
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProvidersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.MasterMenuItem,
            this.TransactionsMenuItem,
            this.HelpMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(936, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(120, 26);
            this.ExitMenuItem.Text = "Exit ";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // MasterMenuItem
            // 
            this.MasterMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsMenuItem,
            this.ProvidersMenuItem,
            this.CategoriesMenuItem,
            this.PayModeMenuItem});
            this.MasterMenuItem.Name = "MasterMenuItem";
            this.MasterMenuItem.Size = new System.Drawing.Size(72, 24);
            this.MasterMenuItem.Text = "Master ";
            // 
            // ProductsMenuItem
            // 
            this.ProductsMenuItem.Name = "ProductsMenuItem";
            this.ProductsMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ProductsMenuItem.Text = "Products ";
            // 
            // ProvidersMenuItem
            // 
            this.ProvidersMenuItem.Name = "ProvidersMenuItem";
            this.ProvidersMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ProvidersMenuItem.Text = "Providers ";
            // 
            // CategoriesMenuItem
            // 
            this.CategoriesMenuItem.Name = "CategoriesMenuItem";
            this.CategoriesMenuItem.Size = new System.Drawing.Size(167, 26);
            this.CategoriesMenuItem.Text = "Categories ";
            // 
            // PayModeMenuItem
            // 
            this.PayModeMenuItem.Name = "PayModeMenuItem";
            this.PayModeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PayModeMenuItem.Text = "Pay Mode";
            this.PayModeMenuItem.Click += new System.EventHandler(this.PayModeMenuItem_Click);
            // 
            // TransactionsMenuItem
            // 
            this.TransactionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellMenuItem,
            this.PurchaseMenuItem});
            this.TransactionsMenuItem.Name = "TransactionsMenuItem";
            this.TransactionsMenuItem.Size = new System.Drawing.Size(104, 24);
            this.TransactionsMenuItem.Text = "Transactions";
            // 
            // SellMenuItem
            // 
            this.SellMenuItem.Name = "SellMenuItem";
            this.SellMenuItem.Size = new System.Drawing.Size(154, 26);
            this.SellMenuItem.Text = "Sell ";
            // 
            // PurchaseMenuItem
            // 
            this.PurchaseMenuItem.Name = "PurchaseMenuItem";
            this.PurchaseMenuItem.Size = new System.Drawing.Size(154, 26);
            this.PurchaseMenuItem.Text = "Purchase ";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(137, 26);
            this.AboutMenuItem.Text = "About ";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 504);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Supermarket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProvidersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}

