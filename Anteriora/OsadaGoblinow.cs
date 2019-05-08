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
        Poczatek o2;
        Mapa o3;

        Bitmap miecz = Properties.Resources.miecze2;

        Bitmap kopalnia = Properties.Resources.Kamieniołom;

        List<PictureBox> listaPictureBoxMgla = new List<PictureBox>();

        public OsadaGoblinow(Osada c1, Poczatek c2, Mapa c3)
        {
            o1 = c1;
            o2 = c2;
            o3 = c3;
            InitializeComponent();            

            o1.kopalniaKamienia.pictureBox = pictureBoxKopalniaKamienia;
            o1.kopalniaKamienia.progressBarBudowa = progressBarBudowaOsadaGoblinow;
            o1.kopalniaKamienia.progressBarUlepszanie = progressBarUlepszanieOsadaGoblinow;
            o1.kopalniaKamienia.bitmap = kopalnia;
            o1.kopalniaKamienia.punkt = new Point(1592, 564);

            o1.kopalniaRudyZelaza1.pictureBox = pictureBoxKopalniaRudyZelaza1;
            o1.kopalniaRudyZelaza1.progressBarBudowa = progressBarBudowaOsadaGoblinow;
            o1.kopalniaRudyZelaza1.progressBarUlepszanie = progressBarUlepszanieOsadaGoblinow;
            o1.kopalniaRudyZelaza1.bitmap = kopalnia;
            o1.kopalniaRudyZelaza1.punkt = new Point(212, 386);

            o1.kopalniaRudyZelaza2.pictureBox = pictureBoxKopalniaRudyZelaza2;
            o1.kopalniaRudyZelaza2.progressBarBudowa = progressBarBudowaOsadaGoblinow;
            o1.kopalniaRudyZelaza2.progressBarUlepszanie = progressBarUlepszanieOsadaGoblinow;
            o1.kopalniaRudyZelaza2.bitmap = kopalnia;
            o1.kopalniaRudyZelaza2.punkt = new Point(1605, 261);

            o1.osadaGoblinow.timerMapa = timerMapa;

            TworzWidok();

            listaPictureBoxMgla.AddRange(new PictureBox[] { pictureBoxMglaPoziom1, pictureBoxMglaPoziom2, pictureBoxMglaPoziom3, pictureBoxMglaPoziom4, pictureBoxMglaPoziom5, pictureBoxMglaPoziom6, pictureBoxMglaPoziom7, pictureBoxMglaPoziom8 });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxMglaPoziom1_Click(object sender, EventArgs e)
        {
            o1.osadaGoblinow1.ZdefiniujPrzeciwnikówNaObszarze(o1.nietoperzMaly, 10, o1.nietoperzDuzy, 5, o1.robak, 5, o1.brak, 0, o1.brak, 0, o1.brak, 0, o1.brak, 0);
            o1.osadaGoblinow1.czyBitwa = true;
            new PoleBitwy(o2,o1.osadaGoblinow, o1.osadaGoblinow1,Properties.Resources.osadagoblinowmapka1).Show();            
        }

        private void PictureBoxMglaPoziom1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxMglaPoziom1.BackgroundImage = miecz;
        }

        private void PictureBoxMglaPoziom1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom1.BackgroundImage = null;
        }

        private void PictureBoxMglaPoziom2_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false)
            {
                o1.osadaGoblinow2.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 3, o1.goblin2, 3, o1.brak, 0, o1.brak, 0, o1.brak, 0, o1.brak, 0, o1.brak, 0);
                o1.osadaGoblinow2.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow2, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom2_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom1.Visible == false)
            {
                pictureBoxMglaPoziom2.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom2.Image = null;
        }

        private void PictureBoxMglaPoziom3_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom2.Visible == false)
            {
                o1.osadaGoblinow3.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 5, o1.goblin2, 5, o1.goblin3, 5, o1.brak, 0, o1.brak, 0, o1.brak, 0, o1.brak, 0);
                o1.osadaGoblinow3.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow3, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom3_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom2.Visible == false)
            {
                pictureBoxMglaPoziom3.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom3_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom3.Image = null;
        }

        private void PictureBoxMglaPoziom4_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                o1.osadaGoblinow4.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 10, o1.goblin2, 10, o1.goblin3, 10, o1.goblin4, 5, o1.goblin5, 5, o1.brak, 0, o1.brak, 0);
                o1.osadaGoblinow4.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow4, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom4_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom4.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom4_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom4.Image = null;
        }

        private void PictureBoxMglaPoziom5_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                o1.osadaGoblinow5.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 10, o1.goblin2, 10, o1.goblin3, 10, o1.goblin4, 5, o1.goblin5, 5, o1.brak, 0, o1.brak, 0);
                o1.osadaGoblinow5.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow5, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom5_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom5.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom5_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom5.Image = null;
        }

        private void PictureBoxMglaPoziom6_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                o1.osadaGoblinow6.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 10, o1.goblin2, 10, o1.goblin3, 10, o1.goblin4, 5, o1.goblin5, 5, o1.brak, 0, o1.brak, 0);
                o1.osadaGoblinow6.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow6, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom6_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom3.Visible == false)
            {
                pictureBoxMglaPoziom6.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom6_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom6.Image = null;
        }

        private void PictureBoxMglaPoziom7_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom6.Visible == false)
            {
                o1.osadaGoblinow7.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 20, o1.goblin2, 30, o1.goblin3, 20, o1.goblin4, 20, o1.goblin5,20, o1.goblin6, 10, o1.goblin7, 10);
                o1.osadaGoblinow7.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow7, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom7_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom7.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom7_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom7.Image = null;
        }

        private void PictureBoxMglaPoziom8_Click(object sender, EventArgs e)
        {
            if(pictureBoxMglaPoziom6.Visible == false)
            {
                o1.osadaGoblinow8.ZdefiniujPrzeciwnikówNaObszarze(o1.goblin, 30, o1.ork, 1, o1.goblin3, 30, o1.goblin4, 20, o1.goblin5, 20, o1.goblin6, 20, o1.goblin7, 20);
                o1.osadaGoblinow8.czyBitwa = true;
                new PoleBitwy(o2, o1.osadaGoblinow, o1.osadaGoblinow8, Properties.Resources.pasekzyciatlo).Show();
            }
        }

        private void PictureBoxMglaPoziom8_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBoxMglaPoziom6.Visible == false)
            {
                pictureBoxMglaPoziom8.Image = miecz;
            }
        }

        private void PictureBoxMglaPoziom8_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMglaPoziom8.Image = null;

        }

        public void TworzWidok()
        {                      
            switch (o1.osadaGoblinow.postep)
            {
                case 1:
                    pictureBoxMglaPoziom1.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG14;
                    break;
                case 2:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG2;
                    break;
                case 3:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG3;
                    break;
                case 4:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG4;
                    break;
                case 5:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG5;
                    break;
                case 6:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG6;
                    break;
                case 7:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG7;
                    break;
                case 8:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG8;
                    break;
                case 9:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG9;
                    break;
                case 10:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG10;
                    break;
                case 11:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG11;
                    break;
                case 12:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG12;
                    break;
                case 13:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG13;
                    break;
                //case 14:
                //    pictureBoxMglaPoziom1.Visible = false;
                //    this.BackgroundImage = OG14;                      -- to samo co case 1
                //    break;
                case 15:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG15;
                    break;
                case 16:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG16;
                    break;
                case 17:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG17;
                    break;
                case 18:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG18;
                    break;
                case 19:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG19;
                    break;
                case 20:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG20;
                    break;
                case 21:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG21;
                    break;
                case 22:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OG22;
                    break;
                case 23:
                    pictureBoxMglaPoziom1.Visible = false;
                    pictureBoxMglaPoziom2.Visible = false;
                    pictureBoxMglaPoziom3.Visible = false;
                    pictureBoxMglaPoziom4.Visible = false;
                    pictureBoxMglaPoziom5.Visible = false;
                    pictureBoxMglaPoziom6.Visible = false;
                    pictureBoxMglaPoziom7.Visible = false;
                    pictureBoxMglaPoziom8.Visible = false;
                    this.BackgroundImage = Properties.Resources.OGFULL;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.OG1;
                    break;
            }

            if(o1.kopalniaKamienia.czyBudowlaIstnieje)
            {
                o1.kopalniaKamienia.pictureBox.Visible = true;                                         
                o1.kopalniaKamienia.pictureBox.BackgroundImage = o1.kopalniaKamienia.bitmap;           
            }
            else
            {
                o1.kopalniaKamienia.pictureBox.Visible = true;
            }

            if(o1.kopalniaRudyZelaza1.czyBudowlaIstnieje)
            {
                o1.kopalniaRudyZelaza1.pictureBox.Visible = true;
                o1.kopalniaRudyZelaza1.pictureBox.BackgroundImage = o1.kopalniaRudyZelaza1.bitmap;
            }
            else
            {
                o1.kopalniaRudyZelaza1.pictureBox.Visible = true;
            }

            if (o1.kopalniaRudyZelaza2.czyBudowlaIstnieje)
            {
                o1.kopalniaRudyZelaza2.pictureBox.Visible = true;
                o1.kopalniaRudyZelaza2.pictureBox.BackgroundImage = o1.kopalniaRudyZelaza2.bitmap;
            }
            else
            {
                o1.kopalniaRudyZelaza2.pictureBox.Visible = true;
            }

        }

        private void PictureBoxKopalniaKamienia_Click(object sender, EventArgs e)
        {         
            if (o1.kopalniaKamienia.pictureBox.BackgroundImage == o1.kopalniaKamienia.bitmap)
            {
                if(o1.kopalniaKamienia.poziomUlepszenia < 3)
                {
                    int iloscSurowcow = 300 * o1.kopalniaKamienia.poziomUlepszenia;
                    // do poprawy ilosc surowcow 
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz ulepszyć kopalnie kamienia do poziomu " + (o1.kopalniaKamienia.poziomUlepszenia + 1) + "?" + " Koszt: " + iloscSurowcow +" drewna.", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        o1.UlepszanieBudynkuInstancja1(o2.drewno, iloscSurowcow, o2.siano, 0, o1.kopalniaKamienia);
                    }
                }
                else
                { 
                    MessageBox.Show("Osiągnięto maksymalny poziom ulepszenia");
                }
               
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz wybudować kopalnie kamienia? Koszt: 300 drewna.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    o1.KosztBudowyInstancje(o2.drewno, 300, o2.siano, 0, o1.kopalniaKamienia);
                }
            }
        }

        private void PictureBoxKopalniaRudyZelaza1_Click(object sender, EventArgs e)
        {
            if (o1.kopalniaRudyZelaza1.pictureBox.BackgroundImage == o1.kopalniaRudyZelaza1.bitmap)
            {
                if (o1.kopalniaRudyZelaza1.poziomUlepszenia < 3)
                {
                    int iloscSurowcow = 300 * o1.kopalniaRudyZelaza1.poziomUlepszenia;
                    // do poprawy ilosc surowcow 
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz ulepszyć kopalnie rudy żelaza do poziomu " + (o1.kopalniaRudyZelaza1.poziomUlepszenia + 1) + "?" + " Koszt: " + iloscSurowcow + " drewna.", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        o1.UlepszanieBudynkuInstancja1(o2.drewno, iloscSurowcow, o2.siano, 0, o1.kopalniaRudyZelaza1);
                    }
                }
                else
                {
                    MessageBox.Show("Osiągnięto maksymalny poziom ulepszenia");
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz wybudować kopalnie rudy żelaza? Koszt: 300 drewna.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    o1.KosztBudowyInstancje(o2.drewno, 300, o2.siano, 0, o1.kopalniaRudyZelaza1);
                }
            }
        }

        private void PictureBoxKopalniaRudyZelaza2_Click(object sender, EventArgs e)
        {
            if (o1.kopalniaRudyZelaza2.pictureBox.BackgroundImage == o1.kopalniaRudyZelaza2.bitmap)
            {
                if (o1.kopalniaRudyZelaza2.poziomUlepszenia < 3)
                {
                    int iloscSurowcow = 300 * o1.kopalniaRudyZelaza2.poziomUlepszenia;
                    // do poprawy ilosc surowcow 
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz ulepszyć kopalnie rudy żelaza do poziomu " + (o1.kopalniaRudyZelaza2.poziomUlepszenia + 1) + "?" + " Koszt: " + iloscSurowcow + " drewna.", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        o1.UlepszanieBudynkuInstancja1(o2.drewno, iloscSurowcow, o2.siano, 0, o1.kopalniaRudyZelaza2);
                    }
                }
                else
                {
                    MessageBox.Show("Osiągnięto maksymalny poziom ulepszenia");
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz wybudować kopalnie rudy żelaza? Koszt: 300 drewna.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    o1.KosztBudowyInstancje(o2.drewno, 300, o2.siano, 0, o1.kopalniaRudyZelaza2);
                }
            }
        }

        private void TimerMapa_Tick(object sender, EventArgs e)
        {
            if (o1.osadaGoblinow1.czyOdblokowane == true && o1.osadaGoblinow1.czyBitwa == false)
            {
                pictureBoxMglaPoziom1.Visible = false;
                o1.osadaGoblinow.postep = 1;
                this.BackgroundImage = Properties.Resources.OG14;
                o1.osadaGoblinow1.czyOdblokowane = false;
            }
            else if (o1.osadaGoblinow2.czyOdblokowane == true && o1.osadaGoblinow2.czyBitwa == false)
            {
                pictureBoxMglaPoziom2.Visible = false;
                o1.osadaGoblinow.postep = 2;
                this.BackgroundImage = Properties.Resources.OG2;
                o1.osadaGoblinow2.czyOdblokowane = false;
            }
            else if(o1.osadaGoblinow3.czyOdblokowane == true && o1.osadaGoblinow3.czyBitwa == false)
            {
                pictureBoxMglaPoziom3.Visible = false;
                o1.osadaGoblinow.postep = 3;
                this.BackgroundImage = Properties.Resources.OG3;
                o1.osadaGoblinow3.czyOdblokowane = false;
            }
            else if(o1.osadaGoblinow4.czyOdblokowane == true && o1.osadaGoblinow4.czyBitwa == false)
            {
                pictureBoxMglaPoziom4.Visible = false;                

                if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 23;
                    this.BackgroundImage = Properties.Resources.OGFULL;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom7.Visible == false)
                {
                    o1.osadaGoblinow.postep = 12;
                    this.BackgroundImage = Properties.Resources.OG12;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 9;
                    this.BackgroundImage = Properties.Resources.OG9;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 8;
                    this.BackgroundImage = Properties.Resources.OG8;
                }
                else if (pictureBoxMglaPoziom8.Visible == false)
                {
                    o1.osadaGoblinow.postep = 13;
                    this.BackgroundImage = Properties.Resources.OG13;
                }
                else if (pictureBoxMglaPoziom7.Visible == false)
                {
                    o1.osadaGoblinow.postep = 11;
                    this.BackgroundImage = Properties.Resources.OG11;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 7;
                    this.BackgroundImage = Properties.Resources.OG7;
                }
                else if (pictureBoxMglaPoziom6.Visible == false)
                {
                    o1.osadaGoblinow.postep = 10;
                    this.BackgroundImage = Properties.Resources.OG10;
                }
                else if (pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 6;
                    this.BackgroundImage = Properties.Resources.OG6;
                }
                else
                {
                    o1.osadaGoblinow.postep = 4;
                    this.BackgroundImage = Properties.Resources.OG4;
                }

                o1.osadaGoblinow4.czyOdblokowane = false;
            }
            else if(o1.osadaGoblinow5.czyOdblokowane == true && o1.osadaGoblinow5.czyBitwa == false)
            {
                pictureBoxMglaPoziom5.Visible = false;
                pictureBoxKopalniaKamienia.Visible = true;

                if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 23;
                    this.BackgroundImage = Properties.Resources.OGFULL;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom7.Visible == false)
                {
                    o1.osadaGoblinow.postep = 17;
                    this.BackgroundImage = Properties.Resources.OG17;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 9;
                    this.BackgroundImage = Properties.Resources.OG9;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 8;
                    this.BackgroundImage = Properties.Resources.OG8;
                }
                else if (pictureBoxMglaPoziom8.Visible == false)
                {
                    o1.osadaGoblinow.postep = 18;
                    this.BackgroundImage = Properties.Resources.OG18;
                }
                else if (pictureBoxMglaPoziom7.Visible == false)
                {
                    o1.osadaGoblinow.postep = 16;
                    this.BackgroundImage = Properties.Resources.OG16;
                }
                else if (pictureBoxMglaPoziom6.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 7;
                    this.BackgroundImage = Properties.Resources.OG7;
                }
                else if (pictureBoxMglaPoziom6.Visible == false)
                {
                    o1.osadaGoblinow.postep = 15;
                    this.BackgroundImage = Properties.Resources.OG15;
                }
                else if (pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 6;
                    this.BackgroundImage = Properties.Resources.OG6;
                }
                else
                {
                    o1.osadaGoblinow.postep = 5;
                    this.BackgroundImage = Properties.Resources.OG5;
                }

                o1.osadaGoblinow5.czyOdblokowane = false;
            }
            else if(o1.osadaGoblinow6.czyOdblokowane == true && o1.osadaGoblinow6.czyBitwa == false)
            {
                pictureBoxMglaPoziom6.Visible = false;

                if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 7;
                    this.BackgroundImage = Properties.Resources.OG7;
                }
                else if (pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 10;
                    this.BackgroundImage = Properties.Resources.OG10;
                }
                else if (pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 15;
                    this.BackgroundImage = Properties.Resources.OG15;
                }
                else
                {
                    o1.osadaGoblinow.postep = 19;
                    this.BackgroundImage = Properties.Resources.OG19;
                }

                o1.osadaGoblinow6.czyOdblokowane = false;
            }
            else if (o1.osadaGoblinow7.czyOdblokowane == true && o1.osadaGoblinow7.czyBitwa == false)
            {
                pictureBoxMglaPoziom7.Visible = false;
                pictureBoxKopalniaRudyZelaza1.Visible = true;

                if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 23;
                    this.BackgroundImage = Properties.Resources.OGFULL;

                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 12;
                    this.BackgroundImage = Properties.Resources.OG12;
                }
                else if (pictureBoxMglaPoziom8.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 17;
                    this.BackgroundImage = Properties.Resources.OG17;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 8;
                    this.BackgroundImage = Properties.Resources.OG8;

                }
                else if (pictureBoxMglaPoziom8.Visible == false)
                {
                    o1.osadaGoblinow.postep = 21;
                    this.BackgroundImage = Properties.Resources.OG21;
                }
                else if (pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 11;
                    this.BackgroundImage = Properties.Resources.OG11;
                }
                else if (pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 16;
                    this.BackgroundImage = Properties.Resources.OG16;
                }
                else
                {
                    o1.osadaGoblinow.postep = 20;
                    this.BackgroundImage = Properties.Resources.OG20;
                }

                o1.osadaGoblinow7.czyOdblokowane = false;
            }
            else if (o1.osadaGoblinow8.czyOdblokowane == true && o1.osadaGoblinow8.czyBitwa == false)
            {
                pictureBoxMglaPoziom8.Visible = false;
                pictureBoxKopalniaRudyZelaza2.Visible = true;

                if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 23;
                    this.BackgroundImage = Properties.Resources.OGFULL;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 12;
                    this.BackgroundImage = Properties.Resources.OG12;
                }
                else if (pictureBoxMglaPoziom7.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 17;
                    this.BackgroundImage = Properties.Resources.OG17;
                }
                else if (pictureBoxMglaPoziom4.Visible == false && pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 9;
                    this.BackgroundImage = Properties.Resources.OG9;
                }
                else if (pictureBoxMglaPoziom7.Visible == false)
                {
                    o1.osadaGoblinow.postep = 21;
                    this.BackgroundImage = Properties.Resources.OG21;
                }
                else if (pictureBoxMglaPoziom4.Visible == false)
                {
                    o1.osadaGoblinow.postep = 13;
                    this.BackgroundImage = Properties.Resources.OG13;
                }
                else if (pictureBoxMglaPoziom5.Visible == false)
                {
                    o1.osadaGoblinow.postep = 18;
                    this.BackgroundImage = Properties.Resources.OG18;
                }
                else
                {
                    o1.osadaGoblinow.postep = 22;
                    this.BackgroundImage = Properties.Resources.OG22;
                }

                o1.osadaGoblinow8.czyOdblokowane = false;
            }

            timerMapa.Stop();
        }
    }
}
