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
    
    public partial class Koszary : Form
    {
        Osada o;

        public Koszary(Osada c)
        {
            o = c;
            InitializeComponent();
            timerKoszary.Start();
        }

        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy wojownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWojownika_Click(object sender, EventArgs e)
        {
            if(o.zloto.ilosc>=5)
            {
                o.zloto.ilosc -= 5;
                o.wojownik.ilosc++;
                MessageBox.Show(o.wojownik.ilosc.ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }
            
        }
        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy rycherza(dodajemy go do listy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLucznik_Click(object sender, EventArgs e)
        {
            if (o.zloto.ilosc >= 10)
            {
                o.zloto.ilosc -= 10;
                o.lucznik2.ilosc++;
                MessageBox.Show(o.lucznik2.ilosc.ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }

        }

        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy kawalerzyste (dodajemy go do listy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWlocznik_Click(object sender, EventArgs e)
        {
            if (o.zloto.ilosc >= 15)
            {
                o.zloto.ilosc -= 15;
                o.wlocznik.ilosc++;
                MessageBox.Show(o.wlocznik.ilosc.ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }

        }

        private void timerKoszary_Tick(object sender, EventArgs e)
        {
            // sprawdzanie aktualnych wartosci i wpisanie ich do labeli
            labelWojownikIlosc.Text = "Ilość wojowników: " + o.wojownik.ilosc.ToString();
            labelLucznikIlosc.Text = "Ilość łuczników: " + o.lucznik2.ilosc.ToString();
            labelWlocznikIlosc.Text = "Ilość włóczników: " + o.wlocznik.ilosc.ToString();
            labelWojownikPoziomUlepszenia.Text = "Poziom wojowników: " + o.wojownik.poziomUlepszenia.ToString();
            labelLucznikPoziomUlepszenia.Text ="Poziom łuczników: " + o.lucznik2.poziomUlepszenia.ToString();
            labelWlocznikPoziomUlepszenia.Text = "Poziom włóczników: " + o.wlocznik.poziomUlepszenia.ToString();
            labelWojownikAtak.Text = "Wartość ataku: " + o.wojownik.ObliczAtakJednostki().ToString();
            labelLucznikAtak.Text = "Wartość ataku: " + o.lucznik2.ObliczAtakJednostki().ToString();
            labelWlocznikAtak.Text = "Wartość ataku: " + o.wlocznik.ObliczAtakJednostki().ToString();
            // obliczanie potencjalu ataku dla poszczegolnych jednostek
            o.wojownik.ObliczPotencjalAtaku(o.wojownik.ilosc, o.wojownik.atak, o.wojownik.poziomUlepszenia).ToString();
            o.lucznik2.ObliczPotencjalAtaku(o.lucznik2.ilosc, o.lucznik2.atak, o.lucznik2.poziomUlepszenia).ToString();
            o.wlocznik.ObliczPotencjalAtaku(o.wlocznik.ilosc, o.wlocznik.atak, o.wlocznik.poziomUlepszenia).ToString();
            // i dla ogółu
            labelPotencjalAtakuOgolnie.Text ="Potencjał ataku jednostek: " + o.jednostkiOfensywne.ObliczPotencjalAtakuWszystkichJednostek(o.wojownik.potencjalAtaku, o.lucznik2.potencjalAtaku, o.wlocznik.potencjalAtaku).ToString();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            timerKoszary.Stop();
            this.Close();
        }

        /// <summary>
        /// przejscie do okna z jednostkami defensywynmi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZamiana_Click(object sender, EventArgs e)
        {
            timerKoszary.Stop();
            this.Close();
            new Koszary2(o,this).Show();
        }

        private void buttonZwiadowca_Click(object sender, EventArgs e)
        {
            timerKoszary.Stop();
            this.Close();
            new KoszaryZwiadowca(o).Show();
        }
    }
}
