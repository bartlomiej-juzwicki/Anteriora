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
    public partial class Panel2 : Form
    {
        Poczatek o1;
        Panel o2;

        bool czyRuch;
        Point start = new Point(0, 0);

        public Panel2(Poczatek c1, Panel c2)
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
            if(czyRuch == true)
            {
                Point ruch = PointToScreen(e.Location);
                this.Location = new Point(ruch.X - start.X, ruch.Y - start.Y);
            }
        }

        private void pictureBoxRuchOkna_MouseUp(object sender, MouseEventArgs e)
        {
            czyRuch = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelLiczbaMieszkancow.Text = o1.mieszkancy.liczbaMieszkancow.ToString();
            labelLiczbaPracujacychMieszkancow.Text = o1.mieszkancy.liczbaPracujacychMieszkancow.ToString();
            labelLiczbaBezrobotnychMieszkancow.Text = o1.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow().ToString();
            labelWojskoIlosc.Text = o1.mieszkancy.liczebnoscWojsk.ToString();
            labelZwiadowcaIlosc.Text = o1.zwiadowca.ilosc.ToString();
            labelPiechurIlosc.Text = o1.piechur.ilosc.ToString();
            labelLucznikIlosc.Text = o1.lucznik.ilosc.ToString();
            labelRycerzIlosc.Text = o1.rycerz.ilosc.ToString();
            labelCzarnyRycerzIlosc.Text = o1.czarnyRycerz.ilosc.ToString();
            labelCzarnyLucznikIlosc.Text = o1.czarnyLucznik.ilosc.ToString();
        }

        private void pictureBoxWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            o2.czyPanel2Istnieje = false;
        }
    }
}
