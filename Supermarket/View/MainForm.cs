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
using Supermarket.View;

namespace Supermarket
{
    public partial class MainForm : Form
    {
        internal PayModeDAO payModeDAO;
        internal CustomerDAO customerDAO;
        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            customerDAO = new CustomerDAO();

            InitializeComponent();

            payModeDAO.AddPayMode(new Model.PayMode(null, "Cash"));

            customerDAO.AddCustomer(new Model.Customer(
                null,                   
                "Samuel",             
                "Varela",     
                "12345678",        
                "31527516",          
                "05-09-2002",         
                "sam.varela@mail.com", 
                "123456OP"          
            ));

            //Agrego fondo para el escritorio principal en la raiz, en el bin

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }//Final de clase

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Final de clase

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\tSamuel Varela Morales " +
                            "\n\tGrupo: S4AN", "About us");

        }//Final de clase

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();

        }//Final de clase

        private void ProvidersMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm formCustomers = new CustomersForm(ref customerDAO);
            formCustomers.MdiParent = this;
            formCustomers.Show();

        }//Final de clase
    }
}
