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

        Osada o1;
        Początek o2;
        Mapa o3;

        public int czasGry;

        public JaskiniaWezy(Osada c1, Początek c2, Mapa c3)
        {
            o1 = c1;
            o2 = c2;
            o3 = c3;
            InitializeComponent();
            TworzWidok();
            czasGry = o3.czasGry;
            timerJaskiniaWezy.Start();
        }

        private void pictureBoxMechanizm1_Click(object sender, EventArgs e)
        {
            new MechanizmJaskiniaWezy(this,o1, 1).ShowDialog();
        }

        private void pictureBoxMechanizm2_Click(object sender, EventArgs e)
        {
            new MechanizmJaskiniaWezy(this,o1, 2).ShowDialog();
        }

        private void pictureBoxMglaPoziom1_Click(object sender, EventArgs e)
        {
            pictureBoxBlokada1.Visible = true;
            pictureBoxBlokada1.BackgroundImage = Properties.Resources.blokada1jaskiniawezy;
            pictureBoxMglaPoziom1.Visible = false;
            this.BackgroundImage = Properties.Resources.jaskiniawezy2;
            o1.jaskiniaWezy.postep = 2;
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
            this.Close();
        }

        private void pictureBoxMglaPoziom2a_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2a.Visible = false;

                if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15e;
                    o1.jaskiniaWezy.postep = 38;
                }
                else if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezyfull;
                    o1.jaskiniaWezy.postep = 33;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy9;
                    o1.jaskiniaWezy.postep = 32;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14;
                    o1.jaskiniaWezy.postep = 27;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13e;
                    o1.jaskiniaWezy.postep = 26;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13;
                    o1.jaskiniaWezy.postep = 21;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy7;
                    o1.jaskiniaWezy.postep = 20;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12;
                    o1.jaskiniaWezy.postep = 15;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6;
                    o1.jaskiniaWezy.postep = 9;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11;
                    o1.jaskiniaWezy.postep = 12;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3a;
                    pictureBoxMglaPoziom2b.Location = new Point(1225, 471);
                    o1.jaskiniaWezy.postep = 3;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3c;
                    o1.jaskiniaWezy.postep = 5;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy5;
                    o1.jaskiniaWezy.postep = 8;
                }
            }
        }

        private void pictureBoxMglaPoziom2a_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false)
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
            if (pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2b.Visible = false;

                if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15e;
                    o1.jaskiniaWezy.postep = 38;
                }
                else if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezyfull;
                    o1.jaskiniaWezy.postep = 33;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy9;
                    o1.jaskiniaWezy.postep = 32;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14;
                    o1.jaskiniaWezy.postep = 27;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13e;
                    o1.jaskiniaWezy.postep = 26;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13;
                    o1.jaskiniaWezy.postep = 21;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy7;
                    o1.jaskiniaWezy.postep = 20;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12;
                    o1.jaskiniaWezy.postep = 15;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6;
                    o1.jaskiniaWezy.postep = 9;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11;
                    o1.jaskiniaWezy.postep = 12;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3b;
                    pictureBoxMglaPoziom2a.Location = new Point(1026, 298);
                    o1.jaskiniaWezy.postep = 4;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3c;
                    o1.jaskiniaWezy.postep = 5;
                }
                else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy5;
                    o1.jaskiniaWezy.postep = 8;
                }
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
            if (pictureBoxMglaPoziom2a.Visible == false || pictureBoxMglaPoziom2b.Visible == false)
            {
                pictureBoxMglaPoziom3.Visible = false;

                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy4a;
                    pictureBoxMglaPoziom2b.Location = new Point(1225, 471);
                    o1.jaskiniaWezy.postep = 6;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy4b;
                    pictureBoxMglaPoziom2a.Location = new Point(1026, 290);
                    o1.jaskiniaWezy.postep = 7;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy5;
                    o1.jaskiniaWezy.postep = 8;
                }
            }
        }

        private void pictureBoxMglaPoziom3_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false && (pictureBoxMglaPoziom2a.Visible == false || pictureBoxMglaPoziom2b.Visible == false))
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
            if (pictureBoxBlokada1.Visible == false && pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom2a.Location = new Point(490, 249);
                pictureBoxMglaPoziom2b.Location = new Point(397, 347);
                pictureBoxMglaPoziom4.Visible = false;
                
                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6;
                    o1.jaskiniaWezy.postep = 9;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6a;
                    o1.jaskiniaWezy.postep = 10;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6b;
                    o1.jaskiniaWezy.postep = 11;
                }
            }
        }

        private void pictureBoxMglaPoziom4_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxBlokada1.Visible == false)
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
            if (pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Visible = false;

                if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezyfull;
                    o1.jaskiniaWezy.postep = 33;
                }
                else if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15a;
                    o1.jaskiniaWezy.postep = 34;
                }
                else if (pictureBoxMglaPoziom9.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15b;
                    o1.jaskiniaWezy.postep = 35;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14;
                    o1.jaskiniaWezy.postep = 27;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14a;
                    o1.jaskiniaWezy.postep = 28;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14b;
                    o1.jaskiniaWezy.postep = 29;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13;
                    o1.jaskiniaWezy.postep = 21;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13a;
                    o1.jaskiniaWezy.postep = 22;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13b;
                    o1.jaskiniaWezy.postep = 23;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12;
                    o1.jaskiniaWezy.postep = 15;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12a;
                    o1.jaskiniaWezy.postep = 16;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12b;
                    o1.jaskiniaWezy.postep = 17;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11;
                    o1.jaskiniaWezy.postep = 12;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11a;
                    o1.jaskiniaWezy.postep = 13;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11b;
                    o1.jaskiniaWezy.postep = 14;
                }
            }

        }

        private void pictureBoxMglaPoziom5_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom4.Visible == false)
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
            if (pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom6.Visible = false;
                pictureBoxBlokada2.Visible = true;
                pictureBoxBlokada2.BackgroundImage = Properties.Resources.blokada2jaskiniawezy;

                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12;
                    o1.jaskiniaWezy.postep = 15;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy7;
                    o1.jaskiniaWezy.postep = 20;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12a;
                    o1.jaskiniaWezy.postep = 16;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12b;
                    o1.jaskiniaWezy.postep = 17;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12c;
                    o1.jaskiniaWezy.postep = 18;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12d;
                    o1.jaskiniaWezy.postep = 19;
                }
            }
        }

        private void pictureBoxMglaPoziom6_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom6.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom6_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom6.Image = null;
        }

        private void pictureBoxMglaPoziom7_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom7.Visible = false;

                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13;
                    o1.jaskiniaWezy.postep = 21;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13e;
                    o1.jaskiniaWezy.postep = 26;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13a;
                    o1.jaskiniaWezy.postep = 22;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13b;
                    o1.jaskiniaWezy.postep = 23;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13c;
                    o1.jaskiniaWezy.postep = 24;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13d;
                    o1.jaskiniaWezy.postep = 25;
                }
            }
        }

        private void pictureBoxMglaPoziom7_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom7.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom7_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom7.Image = null;
        }

        private void pictureBoxMglaPoziom8_Click(object sender, EventArgs e)
        {
            if (pictureBoxBlokada2.Visible == false)
            {
                pictureBoxMglaPoziom8.Visible = false;

                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14;
                    o1.jaskiniaWezy.postep = 27;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy9;
                    o1.jaskiniaWezy.postep = 32;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14a;
                    o1.jaskiniaWezy.postep = 28;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14b;
                    o1.jaskiniaWezy.postep = 29;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14c;
                    o1.jaskiniaWezy.postep = 30;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14d;
                    o1.jaskiniaWezy.postep = 31;
                }
            }
        }

        private void pictureBoxMglaPoziom8_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxBlokada2.Visible == false)
            {
                pictureBoxMglaPoziom8.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom8_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom8.Image = null;
        }

        private void pictureBoxMglaPoziom9_Click(object sender, EventArgs e)
        {
            if (pictureBoxMost.Visible == true)
            {
                pictureBoxMglaPoziom9.Visible = false;

                if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezyfull;
                    o1.jaskiniaWezy.postep = 33;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15e;
                    o1.jaskiniaWezy.postep = 38;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15a;
                    o1.jaskiniaWezy.postep = 34;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15b;
                    o1.jaskiniaWezy.postep = 35;
                }
                else if (pictureBoxMglaPoziom2a.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2b.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15c;
                    o1.jaskiniaWezy.postep = 36;
                }
                else if (pictureBoxMglaPoziom2b.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == true && pictureBoxMglaPoziom2a.Visible == true)
                {
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15d;
                    o1.jaskiniaWezy.postep = 37;
                }
            }
        }

        private void pictureBoxMglaPoziom9_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMost.Visible == true)
            {
                pictureBoxMglaPoziom9.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom9_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom9.Image = null;
        }

        private void pictureBoxPrzepasc_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom8.Visible == false)
            {
                pictureBoxMost.Visible = true;
                o1.jaskiniaWezy.czyBudowlaIstnieje1 = true;
            }
        }

        private void pictureBoxMiejsceNaKopalnie1_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom9.Visible == false)
            {
                pictureBoxMiejsceNaKopalnie1.Visible = false;
                pictureBoxKopalniaZlota1.Visible = true;
                o1.jaskiniaWezy.czyBudowlaIstnieje2 = true;
            }
        }

        private void pictureBoxMiejsceNaKopalnie2_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom9.Visible == false)
            {
                pictureBoxMiejsceNaKopalnie2.Visible = false;
                pictureBoxKopalniaZlota2.Visible = true;
                o1.jaskiniaWezy.czyBudowlaIstnieje3 = true;
            }
        }

        public void TworzWidok()
        {
            switch (o1.jaskiniaWezy.postep)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.jaskiniawezy1;
                    break;
                case 2:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxBlokada1.Visible = true;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy2;
                    break;
                case 3:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxBlokada1.Visible = true;
                    pictureBoxMglaPoziom2a.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3a;
                    break;
                case 4:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxBlokada1.Visible = true;
                    pictureBoxMglaPoziom2b.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3b;
                    break;
                case 5:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxBlokada1.Visible = true;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy3c;
                    break;
                case 6:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy4a;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje1 == false)
                    {
                        pictureBoxBlokada1.Visible = false;
                    }
                    else if (o1.jaskiniaWezy.czyBlokadaIstnieje1 == true)
                    {
                        pictureBoxBlokada1.Visible = true;
                    }

                    break;
                case 7:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy4b;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje1 == false)
                    {
                        pictureBoxBlokada1.Visible = false;
                    }
                    else if (o1.jaskiniaWezy.czyBlokadaIstnieje1 == true)
                    {
                        pictureBoxBlokada1.Visible = true;
                    }
                    break;
                case 8:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy5;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje1 == false)
                    {
                        pictureBoxBlokada1.Visible = false;
                    }
                    else if(o1.jaskiniaWezy.czyBlokadaIstnieje1 == true)
                    {
                        pictureBoxBlokada1.Visible = true;
                    }

                    break;
                case 9:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6;
                    break;
                case 10:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6a;
                    break;
                case 11:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy6b;
                    break;
                case 12:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11;
                    break;
                case 13:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11a;
                    break;
                case 14:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy11b;
                    break;
                case 15:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12;
                    break;
                case 16:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12a;
                    break;
                case 17:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12b;
                    break;
                case 18:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12c;
                    break;
                case 19:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy12d;
                    break;
                case 20:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy7;
                    break;
                case 21:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13;

                    if(o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 22:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13a;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 23:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13b;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 24:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13c;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 25:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13d;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 26:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxBlokada2.Visible = true;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy13e;

                    if (o1.jaskiniaWezy.czyBlokadaIstnieje2 == false)
                    {
                        pictureBoxBlokada2.Visible = false;
                    }

                    break;
                case 27:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14;

                    if(o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;
                case 28:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14a;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;
                case 29:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14b;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;
                case 30:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14c;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;
                case 31:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy14d;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;
                case 32:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy9;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje1 == true)
                    {
                        pictureBoxPrzepasc.Visible = false;
                        pictureBoxMost.Visible = true;
                    }

                    break;

                case 33:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezyfull;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
                case 34:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15a;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
                case 35:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15b;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
                case 36:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15c;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
                case 37:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15d;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
                case 38:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2a.Visible = false;
                    pictureBoxMglaPoziom2b.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    pictureBoxMglaPoziom9.Visible = false;
                    pictureBoxPrzepasc.Visible = false;
                    pictureBoxMost.Visible = true;
                    pictureBoxBlokada1.Visible = false;
                    pictureBoxBlokada2.Visible = false;
                    this.BackgroundImage = Properties.Resources.jaskiniawezy15e;

                    if (o1.jaskiniaWezy.czyBudowlaIstnieje2 == true)
                    {
                        pictureBoxMiejsceNaKopalnie1.Visible = false;
                        pictureBoxKopalniaZlota1.Visible = true;
                    }
                    if (o1.jaskiniaWezy.czyBudowlaIstnieje3 == true)
                    {
                        pictureBoxMiejsceNaKopalnie2.Visible = false;
                        pictureBoxKopalniaZlota2.Visible = true;
                    }

                    break;
            }                      
        }

        private void timerJaskiniaWezy_Tick(object sender, EventArgs e)
        {
            czasGry++;
            labelCzasMapa1.Text = "  Czas gry: " + czasGry.ToString() + " sekund(y)";
            labelDrewno.Text = "Drewno: " + o2.drewno.ilosc.ToString();
            labelKamien.Text = "Kamień: " + o2.kamień.ilosc.ToString();
            labelSiano.Text = "Siano: " + o2.siano.ilosc.ToString();
            labelJedzenie.Text = "Jedzenie: " + o2.jedzenie.ilosc.ToString();
            labelWoda.Text = "Woda: " + o2.woda.ilosc.ToString();
            labelZloto.Text = "Złoto: " + o1.zloto.ilosc.ToString();

            o1.ZmianaKoloruTekstuLabela(o2.drewno, labelDrewno);
            o1.ZmianaKoloruTekstuLabela(o2.kamień, labelKamien);
            o1.ZmianaKoloruTekstuLabela(o2.siano, labelSiano);
            o1.ZmianaKoloruTekstuLabela(o2.jedzenie, labelJedzenie);
            o1.ZmianaKoloruTekstuLabela(o2.woda, labelWoda);
            o1.ZmianaKoloruTekstuLabela(o1.zloto, labelZloto);
            o1.PojemnośćMagazynu();
        }
    }
}

