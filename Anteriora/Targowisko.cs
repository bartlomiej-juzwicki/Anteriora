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
    public partial class Targowisko : Form
    {
        Osada o1;
        Początek o2;
        public Targowisko(Osada copyForm, Początek copyForm2)
        {
            o1 = copyForm;
            o2 = copyForm2;
            InitializeComponent();
        }
        /// <summary>
        /// zamiana surowców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Zamiana surowców na złoto i złoto na surowce
        private void buttonZlotoNaWode_Click(object sender, EventArgs e)
        {
            Zamiana(o1.zloto, 2, o2.woda, 50);
        }

        private void buttonWodaNaZloto_Click(object sender, EventArgs e)
        {
            Zamiana(o2.woda, 100, o1.zloto, 1);
        }

        private void buttonZlotoNaJedzenie_Click(object sender, EventArgs e)
        {
            Zamiana(o1.zloto, 2, o2.jedzenie, 60);
        }

        private void buttonJedzenieNaZloto_Click(object sender, EventArgs e)
        {
            Zamiana(o2.jedzenie, 120, o1.zloto, 1);
        }

        private void buttonZlotoNaSiano_Click(object sender, EventArgs e)
        {
            Zamiana(o1.zloto, 2, o2.siano, 40);
        }

        private void buttonSianoNaZloto_Click(object sender, EventArgs e)
        {
            Zamiana(o2.siano, 80, o1.zloto, 1);
        }

        private void buttonZlotoNaKamien_Click(object sender, EventArgs e)
        {
            Zamiana(o1.zloto, 2, o2.kamień, 50);
        }

        private void buttonKamienNaZloto_Click(object sender, EventArgs e)
        {
            Zamiana(o2.kamień, 100, o1.zloto, 1);
        }

        private void buttonZlotoNaDrewno_Click(object sender, EventArgs e)
        {
            Zamiana(o1.zloto, 2, o2.drewno, 100);
        }

        private void buttonDrewnoNaZloto_Click(object sender, EventArgs e)
        {
            Zamiana(o2.drewno, 200, o1.zloto, 1);
        }

        #endregion

        /// <summary>
        ///  metoda zamiany surowców
        /// </summary>
        /// <param name="materialy"></param>
        /// <param name="ilosc"></param>
        /// <param name="materialy2"></param>
        /// <param name="ilosc2"></param>
        public void Zamiana(Materiały materialy, int ilosc, Materiały materialy2, int ilosc2)
        {
            if(materialy.ilosc >= ilosc)
            {
                materialy.ilosc -= ilosc;
                materialy2.ilosc += ilosc2;
            }
            else
            {
                MessageBox.Show("Brak materiałów!");
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
