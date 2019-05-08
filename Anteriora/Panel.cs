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
    public partial class Panel : Form
    {
        Poczatek o1;

        int czasGry = 1;
        public bool czyPanel2Istnieje;
        public bool czyPanel3Istnieje;
        public bool czyPanel4Istnieje;
        public bool czyPanel5Istnieje;
        public bool czyPanel6Istnieje;

        bool czyRuch;
        Point start = new Point(0, 0);

        public Panel(Poczatek c1)
        {
            o1 = c1;
            InitializeComponent();
                       
            timerPanel.Start();
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            czasGry++;
            labelCzasGry.Text = czasGry.ToString();            
            labelDrewno.Text = o1.drewno.ilosc.ToString();
            labelKamien.Text = o1.kamień.ilosc.ToString();
            labelSiano.Text = o1.siano.ilosc.ToString();           
            labelJedzenie.Text = o1.jedzenie.ilosc.ToString();
            labelWoda.Text = o1.woda.ilosc.ToString();
            labelZloto.Text = o1.zloto.ilosc.ToString();

            ZmianaKoloruTekstuLabela(o1.drewno, labelDrewno);
            ZmianaKoloruTekstuLabela(o1.kamień, labelKamien);
            ZmianaKoloruTekstuLabela(o1.siano, labelSiano);
            ZmianaKoloruTekstuLabela(o1.jedzenie, labelJedzenie);
            ZmianaKoloruTekstuLabela(o1.woda, labelWoda);
           
            ZmienKolorLabelaPrzyGlodzie();

        }

        #region Zmiana koloru labela jedzenia i wody podczas głodu

        public void ZmienKolorLabelaPrzyGlodzie()
        {
            if (o1.jedzenie.ilosc < 0)
            {
                labelJedzenie.ForeColor = Color.DarkRed;
            }
            else if (labelJedzenie.ForeColor == Color.DarkRed && o1.jedzenie.ilosc >= 0)
            {
                labelJedzenie.ForeColor = Color.Black;
            }

            if (o1.woda.ilosc < 0)
            {
                labelWoda.ForeColor = Color.DarkRed;
            }
            else if (labelWoda.ForeColor == Color.DarkRed && o1.woda.ilosc >= 0)
            {
                labelWoda.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Zmiana koloru tekstu labela przy przepełnieniu magazynu materiałami

        public void ZmianaKoloruTekstuLabela(Materialy material, Label label)
        {
            if (o1.magazyn.poziomUlepszenia == 0)
            {
                if (material.ilosc >= 99)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 99)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (o1.magazyn.poziomUlepszenia == 1)
            {
                if (material.ilosc >= 999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 999)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (o1.magazyn.poziomUlepszenia == 2)
            {
                if (material.ilosc >= 1999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 1999)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (o1.magazyn.poziomUlepszenia == 3)
            {
                if (material.ilosc >= 2999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 2999)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        private void buttonPozostale_Click(object sender, EventArgs e)
        {
            if(czyPanel2Istnieje == false)
            {
                Panel2 panel = new Panel2(o1, this);
                panel.Show();
                czyPanel2Istnieje = true;
            }

            if(czyPanel3Istnieje == false)
            {
                Panel3 panel = new Panel3(o1, this);
                panel.Show();
                czyPanel3Istnieje = true;
            }

            if(czyPanel4Istnieje == false)
            {
                Panel4 panel = new Panel4(o1, this);
                panel.Show();
                czyPanel4Istnieje = true;
            }

            if(czyPanel5Istnieje == false)
            {
                Panel5 panel = new Panel5(o1, this);
                panel.Show();
                czyPanel5Istnieje = true;
            }
            
            if(czyPanel6Istnieje == false)
            {
                Panel6 panel = new Panel6(o1, this);
                panel.Show();
                czyPanel6Istnieje = true;
            }

        }

        private void PictureBoxRuchOkna_MouseDown(object sender, MouseEventArgs e)
        {
            czyRuch = true;
            start = new Point(e.X, e.Y);
        }

        private void PictureBoxRuchOkna_MouseMove(object sender, MouseEventArgs e)
        {
            if (czyRuch == true)
            {
                Point ruch = PointToScreen(e.Location);
                this.Location = new Point(ruch.X - start.X, ruch.Y - start.Y);
            }
        }

        private void PictureBoxRuchOkna_MouseUp(object sender, MouseEventArgs e)
        {
            czyRuch = false;
        }
    }
}
