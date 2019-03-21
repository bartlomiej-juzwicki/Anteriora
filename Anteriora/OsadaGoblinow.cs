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
    public partial class OsadaGoblinow : Form
    {
        Osada o1;
        Początek o2;
        Mapa o3;

        public int czasGry;

        public OsadaGoblinow(Osada c1, Początek c2, Mapa c3)
        {
            o1 = c1;
            o2 = c2;
            o3 = c3;
            InitializeComponent();
            czasGry = o3.czasGry;
            TworzWidok();
            timerOsadaGoblinow.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMglaPoziom1_Click(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom1.Visible = false;
            this.BackgroundImage = Properties.Resources.osadagoblinow2b;
            o1.osadaGoblinow.postep = 2;
        }

        private void pictureBoxMglaPoziom2_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinow2;
                o1.osadaGoblinow.postep = 3;
            }
        }

        private void pictureBoxMglaPoziom2_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2.Image = null;
        }

        private void pictureBoxMglaPoziom3_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false)
            {
                pictureBoxMglaPoziom3.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinow3;
                o1.osadaGoblinow.postep = 4;
                pictureBoxNamiot.Visible = true;
            }
        }

        private void pictureBoxMglaPoziom3_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false)
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
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == true)
            {
                pictureBoxMglaPoziom4.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinow4;
                o1.osadaGoblinow.postep = 5;
            }
            else if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom5.Visible == false)
            {
                pictureBoxMglaPoziom4.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinowfull;
                o1.osadaGoblinow.postep = 7;
            }
        }

        private void pictureBoxMglaPoziom4_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false)
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
            if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == true)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinow5;
                o1.osadaGoblinow.postep = 6;
            }
            else if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false && pictureBoxMglaPoziom4.Visible == false)
            {
                pictureBoxMglaPoziom5.Visible = false;
                this.BackgroundImage = Properties.Resources.osadagoblinowfull;
                o1.osadaGoblinow.postep = 7;
            }
        }

        private void pictureBoxMglaPoziom5_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom5.Image = Properties.Resources.miecze2;
            }
        }

        private void pictureBoxMglaPoziom5_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom5.Image = null;
        }


        public void TworzWidok()
        {
            switch(o1.osadaGoblinow.postep)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.osadagoblinow1;
                    break;
                case 2:
                    pictureBoxMglaPoziom1.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinow2b;
                    break;
                case 3:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinow2;
                    break;
                case 4:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinow3;
                    break;
                case 5:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinow4;
                    break;
                case 6:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinow5;
                    break;
                case 7:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.osadagoblinowfull;
                    break;
            }
        }

        private void timerOsadaGoblinow_Tick(object sender, EventArgs e)
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

        private void pictureBoxNamiot_Click(object sender, EventArgs e)
        {
            if(pictureBoxNamiot.BackgroundImage == null)
            {
                if (pictureBoxMglaPoziom1.Visible == false && pictureBoxMglaPoziom2.Visible == false && pictureBoxMglaPoziom3.Visible == false)
                {
                    pictureBoxNamiot.Image = null;
                    pictureBoxNamiot.BackgroundImage = Properties.Resources.namiot;
                }
            }
            else
            {
                MessageBox.Show("okno");
            }
           
        }

        
    }
}
