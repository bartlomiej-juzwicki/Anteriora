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
    public partial class MechanizmJaskiniaWezy : Form
    {
        public int mechanizmobrazek1;
        public int mechanizmobrazek2;
        public int mechanizmobrazek3;
        public int mechanizmobrazek4;
        public int mechanizmobrazek5;
        public int mechanizmobrazek6;

        public int mechanizm1;
        public int mechanizm2;
        public int mechanizm3;
        public int mechanizm4;
        public int mechanizm5;
        public int mechanizm6;

        public int ktoryMechanizm;

        public Random rnd = new Random();

        JaskiniaWezy o;
        Osada o2;

        public MechanizmJaskiniaWezy(JaskiniaWezy c, Osada c2, int mechanizm)
        {
            o = c;
            o2 = c2;
            InitializeComponent();

            ktoryMechanizm = mechanizm;
            
            if(ktoryMechanizm == 1)
            {
                this.Size = new Size(715, 295);
                pictureBoxMechanizm5.Visible = false;
                pictureBoxMechanizm6.Visible = false;
                mechanizm1 = rnd.Next(0, 2);
                mechanizm2 = rnd.Next(0, 2);
                mechanizm3 = rnd.Next(0, 2);
                mechanizm4 = rnd.Next(0, 2);
            }
            else if(ktoryMechanizm == 2)
            {
                this.Size = new Size(1067, 295);
                mechanizm1 = rnd.Next(0, 2);
                mechanizm2 = rnd.Next(0, 2);
                mechanizm3 = rnd.Next(0, 2);
                mechanizm4 = rnd.Next(0, 2);
                mechanizm5 = rnd.Next(0, 2);
                mechanizm6 = rnd.Next(0, 2);
            }

            timerCzyKombinacjaPoprawna.Start();
        }

        private void pictureBoxMechanizm1_Click(object sender, EventArgs e)
        {

            if (mechanizmobrazek1 == 0)
            {
                pictureBoxMechanizm1.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek1 = 1;
            }
            else if (mechanizmobrazek1 == 1)
            {
                pictureBoxMechanizm1.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek1 = 0;
            }
        }

        private void pictureBoxMechanizm2_Click(object sender, EventArgs e)
        {
            if (mechanizmobrazek2 == 0)
            {
                pictureBoxMechanizm2.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek2 = 1;
            }
            else if (mechanizmobrazek2 == 1)
            {
                pictureBoxMechanizm2.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek2 = 0;
            }
        }

        private void pictureBoxMechanizm3_Click(object sender, EventArgs e)
        {
            if (mechanizmobrazek3 == 0)
            {
                pictureBoxMechanizm3.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek3 = 1;
            }
            else if (mechanizmobrazek3 == 1)
            {
                pictureBoxMechanizm3.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek3 = 0;
            }
        }

        private void pictureBoxMechanizm4_Click(object sender, EventArgs e)
        {
            if (mechanizmobrazek4 == 0)
            {
                pictureBoxMechanizm4.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek4 = 1;
            }
            else if (mechanizmobrazek4 == 1)
            {
                pictureBoxMechanizm4.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek4 = 0;
            }
        }

        private void pictureBoxMechanizm5_Click(object sender, EventArgs e)
        {
            if (mechanizmobrazek5 == 0)
            {
                pictureBoxMechanizm5.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek5 = 1;
            }
            else if (mechanizmobrazek5 == 1)
            {
                pictureBoxMechanizm5.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek5 = 0;
            }
        }

        private void pictureBoxMechanizm6_Click(object sender, EventArgs e)
        {
            if (mechanizmobrazek6 == 0)
            {
                pictureBoxMechanizm6.BackgroundImage = Properties.Resources.mechanizm2;
                mechanizmobrazek6 = 1;
            }
            else if (mechanizmobrazek6 == 1)
            {
                pictureBoxMechanizm6.BackgroundImage = Properties.Resources.mechanizm1;
                mechanizmobrazek6 = 0;
            }
        }

        public void OdblokujPrzejscie()
        {
            if(ktoryMechanizm == 1)
            {
                if (mechanizm1 == 0 && mechanizm2 == 0 && mechanizm3 == 0 && mechanizm4 == 0)
                {
                    mechanizm1 = rnd.Next(0, 2);
                    mechanizm2 = rnd.Next(0, 2);
                    mechanizm3 = rnd.Next(0, 2);
                    mechanizm4 = rnd.Next(0, 2);
                }
                else if (mechanizmobrazek1 == mechanizm1 && mechanizmobrazek2 == mechanizm2 && mechanizmobrazek3 == mechanizm3 && mechanizmobrazek4 == mechanizm4)
                {
                    this.Close();
                    o2.jaskiniaWezy.czyBlokadaIstnieje1 = false;
                    o.pictureBoxBlokada1.Visible = false;
                }
            }
            else if (ktoryMechanizm == 2)
            {
                if (mechanizm1 == 0 && mechanizm2 == 0 && mechanizm3 == 0 && mechanizm4 == 0 && mechanizm5 == 0 && mechanizm6 == 0)
                {
                    mechanizm1 = rnd.Next(0, 2);
                    mechanizm2 = rnd.Next(0, 2);
                    mechanizm3 = rnd.Next(0, 2);
                    mechanizm4 = rnd.Next(0, 2);
                    mechanizm5 = rnd.Next(0, 2);
                    mechanizm6 = rnd.Next(0, 2);
                }
                else if (mechanizmobrazek1 == mechanizm1 && mechanizmobrazek2 == mechanizm2 && mechanizmobrazek3 == mechanizm3 && mechanizmobrazek4 == mechanizm4 && mechanizmobrazek5 == mechanizm5 && mechanizmobrazek6 == mechanizm6)
                {
                    this.Close();
                    o2.jaskiniaWezy.czyBlokadaIstnieje2 = false;
                    o.pictureBoxBlokada2.Visible = false;
                }
            }

        }

        private void timerCzyKombinacjaPoprawna_Tick(object sender, EventArgs e)
        {
            OdblokujPrzejscie();
            if(ktoryMechanizm == 1)
            {
                label1.Text = mechanizm1.ToString() + " " + mechanizm2.ToString() + " " + mechanizm3.ToString() + " " + mechanizm4.ToString() + " ";
            }
            else if(ktoryMechanizm == 2)
            {
                label1.Text = mechanizm1.ToString() + " " + mechanizm2.ToString() + " " + mechanizm3.ToString() + " " + mechanizm4.ToString() + " " + mechanizm5.ToString() + " " + mechanizm6.ToString() + " ";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
