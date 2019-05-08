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
    public partial class Panel5 : Form
    {
        Poczatek o1;
        Panel o2;

        bool czyRuch;
        Point start = new Point(0, 0);

        public Panel5(Poczatek c1, Panel c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelSkora.Text = o1.skora.ilosc.ToString();
            labelRudaZelaza.Text = o1.rudaZelaza.ilosc.ToString();
            labelZelazo.Text = o1.zelazo.ilosc.ToString();
            labelRudaObsydianu.Text = o1.rudaObsydianu.ilosc.ToString();
            labelObsydian.Text = o1.obsydian.ilosc.ToString();
            labelKawalekDrewna.Text = o1.kawalekDrewna.ilosc.ToString();
            labelSkorzanyPasek.Text = o1.skorzanyPasek.ilosc.ToString();
            labelWelna.Text = o1.welna.ilosc.ToString();

            o2.ZmianaKoloruTekstuLabela(o1.skora, labelSkora);
            o2.ZmianaKoloruTekstuLabela(o1.rudaZelaza, labelRudaZelaza);
            o2.ZmianaKoloruTekstuLabela(o1.zelazo, labelZelazo);
            o2.ZmianaKoloruTekstuLabela(o1.rudaObsydianu, labelRudaObsydianu);
            o2.ZmianaKoloruTekstuLabela(o1.obsydian, labelObsydian);
            o2.ZmianaKoloruTekstuLabela(o1.kawalekDrewna, labelKawalekDrewna);
            o2.ZmianaKoloruTekstuLabela(o1.skorzanyPasek, labelSkorzanyPasek);
            o2.ZmianaKoloruTekstuLabela(o1.welna, labelWelna);

        }

        private void PictureBoxWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            o2.czyPanel5Istnieje = false;
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
