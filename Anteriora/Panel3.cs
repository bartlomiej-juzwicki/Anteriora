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
    public partial class Panel3 : Form
    {
        Poczatek o1;
        Panel o2;

        bool czyRuch;
        Point start = new Point(0, 0);

        public Panel3(Poczatek c1, Panel c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            timer.Start();
        }

        private void pictureBoxRuchOkna_MouseDown(object sender, MouseEventArgs e)
        {
            czyRuch = true;
            start = new Point(e.X, e.Y);
        }

        private void pictureBoxRuchOkna_MouseMove(object sender, MouseEventArgs e)
        {
            if (czyRuch == true)
            {
                Point ruch = PointToScreen(e.Location);
                this.Location = new Point(ruch.X - start.X, ruch.Y - start.Y);
            }
        }

        private void pictureBoxRuchOkna_MouseUp(object sender, MouseEventArgs e)
        {
            czyRuch = false;
        }

        private void pictureBoxWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            o2.czyPanel3Istnieje = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelSkorzanyHelmIlosc.Text = o1.skorzanyHelm.ilosc.ToString();
            labelSkorzanaZbrojaIlosc.Text = o1.skorzanaZbroja.ilosc.ToString();
            labelSkorzaneSpodnieIlosc.Text = o1.skorzaneSpodnie.ilosc.ToString();
            labelSkorzaneButyIlosc.Text = o1.skorzaneButy.ilosc.ToString();
            labelZelaznyHelmIlosc.Text = o1.zelaznyHelm.ilosc.ToString();
            labelZelaznaZbrojaIlosc.Text = o1.zelaznaZbroja.ilosc.ToString();
            labelZelazneSpodnieIlosc.Text = o1.zelazneSpodnie.ilosc.ToString();
            labelZelazneButyIlosc.Text = o1.zelazneButy.ilosc.ToString();
            labelObsydianowyHelmIlosc.Text = o1.obsydianowyHelm.ilosc.ToString();
            labelObsydianowaZbrojaIlosc.Text = o1.obsydianowaZbroja.ilosc.ToString();
            labelObsydianoweSpodnieIlosc.Text = o1.obsydianoweSpodnie.ilosc.ToString();
            labelObsydianoweButyIlosc.Text = o1.obsydianoweButy.ilosc.ToString();
        }
    }
}
