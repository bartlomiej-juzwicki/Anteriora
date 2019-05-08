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
    public partial class Panel4 : Form
    {
        Poczatek o1;
        Panel o2;

        bool czyRuch;
        Point start = new Point(0, 0);

        public Panel4(Poczatek c1, Panel c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            timer.Start();
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

        private void PictureBoxWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            o2.czyPanel4Istnieje = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelKamiennyMieczIlosc.Text = o1.kamiennyMiecz.ilosc.ToString();
            labelZelaznyMieczIlosc.Text = o1.zelaznyMiecz.ilosc.ToString();
            labelObsydianowyMieczIlosc.Text = o1.obsydianowyMiecz.ilosc.ToString();
            labelLukIlosc.Text = o1.luk.ilosc.ToString();
            labelZelaznaTarczaIlosc.Text = o1.zelaznaTarcza.ilosc.ToString();
            labelObsydianowaTarczaIlosc.Text = o1.obsydianowaTarcza.ilosc.ToString();
        }
    }
}
