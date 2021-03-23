using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace puntoDeVenta
{
    public partial class formCharge : Form
    {
        public formCharge()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.timer1.Start();
            this.timer1.Interval = 500;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }

            if (progressBar1.Value == 50)
            {
                lblPunto.Show();
            }
            else
            {
                if (progressBar1.Value == 60)
                {
                    lblDes.Show();
                }
                else
                {
                    if (progressBar1.Value == 70)
                    {
                        picIcon.Show();
                    }
                    else
                    {
                        if (progressBar1.Value == 95)
                        {
                            this.Hide();
                            formLogin frmLog = new formLogin();
                            frmLog.Show();
                        }
                    }
                }
            }

            

            

            
        }
    }
}
