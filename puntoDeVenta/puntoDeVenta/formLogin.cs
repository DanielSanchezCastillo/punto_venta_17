using System;
using System.Windows.Forms;

namespace puntoDeVenta
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            boxPass.PasswordChar = default;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            boxPass.PasswordChar = '*';
            this.pictureBox5.Visible = false;
            this.pictureBox4.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            /*var user = this.boxUser.Text.ToString();
            var pass = this.boxPass.Text.ToString();
            securityClass sc = new securityClass();
            var userEn = sc.encryptUser(user);
            MessageBox.Show(userEn);*/

            var user = this.boxUser.Text.ToString();
            var pass = this.boxPass.Text.ToString();
            if(user == "probat" && pass == "tengohambre1")
            {
                formFunction frm2 = new formFunction();
                frm2.lblUsername.Text = "Daniel";
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("lo sentimos, el usuario que acaba de ingresar no se encuentra en nuestra base de datos");
            }


        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
