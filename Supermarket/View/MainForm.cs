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
        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            InitializeComponent();
            payModeDAO.AddPayMode(new Model.PayMode(null, "Cash"));

            //Agrego fondo para el escritorio principal
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\tSamuel Varela Morales " +
                            "\n\tGrupo: S4AN", "About us");
        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();

        }
    }
}
