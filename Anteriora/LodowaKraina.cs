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
    public partial class LodowaKraina : Form
    {
        Osada o1;
        Poczatek o2;
        Mapa o3;

        public LodowaKraina(Osada c1, Poczatek c2, Mapa c3)
        {
            o1 = c1;
            o2 = c2;
            o3 = c3;
            InitializeComponent();

            //o1.warsztatLK.pictureBox = pictureBoxWarsztat;
            //o1.studniaLK1.pictureBox = pictureBoxStudnia1;
            //o1.studniaLK2.pictureBox = pictureBoxStudnia2;
            //o1.kwateraRybackaLK1.pictureBox = pictureBoxKwateraRybacka1;
            //o1.kwateraRybackaLK2.pictureBox = pictureBoxKwateraRybacka2;
            /// jeszcze picturebox budynku mieszkalnego

            TworzWidok();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMglaPoziom2_Click(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2.Visible = false;
            this.BackgroundImage = Properties.Resources.lodowakraina2;
            o1.lodowaKraina.postep = 2;
        }
        
        private void pictureBoxMglaPoziom2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxMglaPoziom2.Image = Properties.Resources.miecze2;
        }

        private void pictureBoxMglaPoziom2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2.Image = null;
        }

        private void pictureBoxMglaPoziom3_Click(object sender, EventArgs e)
        {
            if (pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom4.Visible == true)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina3;
                o1.lodowaKraina.postep = 3;
            }
            else if (pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == true)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina4;
                o1.lodowaKraina.postep = 4;
            }
            else if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina5;
                o1.lodowaKraina.postep = 5;
            }
        }

        private void pictureBoxMglaPoziom3_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom2.Visible == false)
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
            if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom6.Visible == true)
            {
                pictureBoxMglaPoziom4.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina4;
                o1.lodowaKraina.postep = 4;
            }
            else if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom6.Visible == true)
            {
                pictureBoxMglaPoziom4.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina6;
                o1.lodowaKraina.postep = 6;
            }
            else if(pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom4.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina9;
                o1.lodowaKraina.postep = 9;
            }

        }

        private void pictureBoxMglaPoziom4_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom4.Image = null;

        }

        private void pictureBoxMglaPoziom4_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom2.Visible == false)
            {
                pictureBoxMglaPoziom4.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom5_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom3.Visible == true && pictureBoxMglaPoziom6.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina7;
                o1.lodowaKraina.postep = 7;
            }
            else if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom6.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina5;
                o1.lodowaKraina.postep = 5;
            }
            else if(pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.lodowakraina10;
                o1.lodowaKraina.postep = 10;
            }

        }

        private void pictureBoxMglaPoziom5_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom5.Image = null;
        }

        private void pictureBoxMglaPoziom5_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom6_Click(object sender, EventArgs e)
        {
            if(pictureBoxPrzeszkoda.Visible == false)
            {
                if (pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == true && pictureBoxMglaPoziom5.Visible == true)
                {
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina8;
                    o1.lodowaKraina.postep = 8;
                }
                else if(pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == true)
                {
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina9;
                    o1.lodowaKraina.postep = 9;
                }
                else if (pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina10;
                    o1.lodowaKraina.postep = 10;
                }
            }   
            else if(pictureBoxPrzeszkoda.Visible == true && pictureBoxMglaPoziom3.Visible == false)
            {
                MessageBox.Show("Lód blokuje przejście!");
            }
        }

        private void pictureBoxMglaPoziom6_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom6.Image = null;            
        }

        private void pictureBoxMglaPoziom6_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom6.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxPrzeszkoda_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxPrzeszkoda.Visible = false;
                o1.lodowaKraina.czyBlokadaIstnieje1 = false;
            }
        }

        private void pictureBoxNamiot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("okno");
        }

        private void pictureBoxPodNamiotem_Click(object sender, EventArgs e)
        {
            //pictureBoxNamiot.Visible = true;
            //pictureBoxPodNamiotem.Visible = false;
        }

        public void TworzWidok()
        {
            if (o1.lodowaKraina.czyBlokadaIstnieje1 == false)
            {
                pictureBoxPrzeszkoda.Visible = false;
            }

            switch (o1.lodowaKraina.postep)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.lodowakraina1;
                    break;
                case 2:
                    pictureBoxMglaPoziom2.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina2;
                    break;
                case 3:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina3;
                    break;
                case 4:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina4;
                    break;
                case 5:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina5;
                    break;
                case 6:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina6;
                    break;
                case 7:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina7;
                    break;
                case 8:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina8;
                    break;
                case 9:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina9;
                    break;
                case 10:
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.lodowakraina10;
                    break;
            }
        }

        private void pictureBoxMglaPoziom2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("elo");
        }
    }
}
