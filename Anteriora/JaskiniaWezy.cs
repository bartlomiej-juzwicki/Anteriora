using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public partial class JaskiniaWezy : Form
    {
        public JaskiniaWezy()
        {
            InitializeComponent();
        }

        private void pictureBoxMechanizm1_Click(object sender, EventArgs e)
        {
            new MechanizmJaskiniaWezy(this, 1).ShowDialog();
        }

        private void pictureBoxMechanizm2_Click(object sender, EventArgs e)
        {
            new MechanizmJaskiniaWezy(this, 2).ShowDialog();
        }

        private void pictureBoxMost_Click(object sender, EventArgs e)
        {
            pictureBoxMost.BackgroundImage = Properties.Resources.mostjaskiniawezy;
        }


        private void pictureBoxMglaPoziom1_Click(object sender, EventArgs e)
        {
            pictureBoxBlokada1.BackgroundImage = Properties.Resources.blokada1jaskiniawezy;
            pictureBoxMglaPoziom1.Visible = false;
            this.BackgroundImage = Properties.Resources.jaskiniawezy2;
        }

        private void pictureBoxMglaPoziom1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxMglaPoziom1.Image = Properties.Resources.miecze2;
        }

        private void pictureBoxMglaPoziom1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMglaPoziom2a_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11;
            }
            else if (pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy6;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
            {
                pictureBoxMglaPoziom2a.Visible = false;                
                this.BackgroundImage = Properties.Resources.jaskiniawezy3a;
                pictureBoxMglaPoziom2b.Location = new Point(1225,471);
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == true)
            {
                pictureBoxMglaPoziom2a.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy3c;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom2a.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy5;
            }
        }

        private void pictureBoxMglaPoziom2a_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2a.Image = Properties.Resources.miecze2;
            }
            
        }

        private void pictureBoxMglaPoziom2a_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2a.Image = null;
        }

        private void pictureBoxMglaPoziom2b_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11;
            }
            else if(pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy6;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy3b;
                pictureBoxMglaPoziom2a.Location = new Point(1026,298);
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == true)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy3c;
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy5;
            }
            

        }

        private void pictureBoxMglaPoziom2b_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2b.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom2b_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2b.Image = null;
        }

        private void pictureBoxMglaPoziom3_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy4a;
                pictureBoxMglaPoziom2b.Location = new Point(1225, 471);
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy4b;
                 pictureBoxMglaPoziom2a.Location = new Point(1026, 290);
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == false)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy5;
            }
        }

        private void pictureBoxMglaPoziom3_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && (pictureBoxMglaPoziom2a.Visible == false || pictureBoxMglaPoziom2b.Visible == false))
            {
                pictureBoxMglaPoziom3.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom3_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom3.Image = null;
        }

        private void pictureBoxMglaPoziom4_Click(object sender, EventArgs e)
        {
            if(pictureBoxBlokada1.Visible == false)
            {
                pictureBoxMglaPoziom2a.Location = new Point(490, 249);
                pictureBoxMglaPoziom2b.Location = new Point(397, 347);

                if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false)
                {
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6;
                }
                else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6a;
                }
                else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6b;
                }
            }
        }

        private void pictureBoxMglaPoziom4_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxBlokada1.Visible == false)
            {
                pictureBoxMglaPoziom4.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom4_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom4.Image = null;
        }

        private void pictureBoxMglaPoziom5_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11;
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11a;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11b;
            }
        }

        private void pictureBoxMglaPoziom5_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom5_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom5.Image = null;
        }

        private void pictureBoxMglaPoziom6_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
            {
                pictureBoxMglaPoziom6.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy12;
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11a;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.jaskiniawezy11b;
            }

        }

        private void pictureBoxMglaPoziom6_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom6.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom6_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom6.Image = null;
        }
    }
}
