
using System.Windows.Forms;

namespace puntoDeVenta
{
    public partial class formFunction : Form
    {
        public formFunction()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            this.lblPage.Text = "Dashboard";
            this.pnlDashboardItem.Show();

        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            
            formLogin frm1 = new formLogin();
            formFunction frm2 = new formFunction();
            frm1.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, System.EventArgs e)
        {
            this.lblPage.Text = "Inventario";
            this.pnlDashboardItem.Hide();
            
        }
    }
}
