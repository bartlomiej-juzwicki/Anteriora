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
            labelAtakujacyIlosc.Text = (o1.piechur.liczebnoscAtakujacych + o1.lucznik.liczebnoscAtakujacych + o1.rycerz.liczebnoscAtakujacych + o1.czarnyRycerz.liczebnoscAtakujacych + o1.czarnyLucznik.liczebnoscAtakujacych).ToString();
            labelBroniacyIlosc.Text = (o1.piechur.liczebnoscBroniacych + o1.lucznik.liczebnoscBroniacych + o1.rycerz.liczebnoscBroniacych + o1.czarnyRycerz.liczebnoscBroniacych + o1.czarnyLucznik.liczebnoscBroniacych).ToString();
        }

        private void pictureBoxWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            o2.czyPanel2Istnieje = false;
        }
    }
}
