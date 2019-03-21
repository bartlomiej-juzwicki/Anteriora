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
    
    public partial class Koszary2 : Form
    {
        Osada originalForm;
        Koszary originalForm2;
        public Koszary2(Osada copyForm, Koszary copyForm2)
        {
            originalForm = copyForm;
            originalForm2 = copyForm2;
            InitializeComponent();
            timerKoszary2.Start();
            // określenie obrony jednostek defensywnych
            originalForm.peltasta.obrona = 20;
            originalForm.lucznik.obrona= 40;
            originalForm.halabardnik.obrona = 80;
        }
        /// <summary>
        /// przejscie do okna z jednostaki ofensywnymi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            timerKoszary2.Stop();
            this.Close();
        }

        private void timerKoszary2_Tick(object sender, EventArgs e)
        {
            /* // wpisanie aktualnych wartosci do labeli
             labelPeltastaIlosc.Text = "Ilość peltastów: " + originalForm.listPeltasta.Count().ToString();
             labelLucznikIlosc.Text = "Ilość łuczników: " + originalForm.listLucznik.Count().ToString();
             labelHalabardnikIlosc.Text = "Ilość halabardników: " + originalForm.listHalabardnik.Count().ToString();
             labelPeltastaPoziomUlepszenia.Text = "Poziom peltastów " + originalForm.peltasta.poziomUlepszenia.ToString();
             labelLucznikPoziomUlepszenia.Text = "Poziom łuczników: " + originalForm.lucznik.poziomUlepszenia.ToString();
             labelHalabardnikPoziomUlepszenia.Text = "Poziom halabardn.: " + originalForm.halabardnik.poziomUlepszenia.ToString();
             labelPeltastaObrona.Text = "Wartość obrony: " + originalForm.peltasta.obrona.ToString();
             labelLucznikObrona.Text = "Wartość obrony: " + originalForm.lucznik.obrona.ToString();
             labelHalabardnikObrona.Text = "Wartość obrony: " + originalForm.halabardnik.obrona.ToString();
             // obliczanie potencjalu obrony dla poszczególynch jednostek i dla ogółu
             originalForm.peltasta.PotencjalObrony(originalForm.listPeltasta.Count(), originalForm.peltasta.obrona, originalForm.peltasta.poziomUlepszenia).ToString();
             originalForm.lucznik.PotencjalObrony(originalForm.listLucznik.Count(), originalForm.lucznik.obrona, originalForm.lucznik.poziomUlepszenia).ToString();
             originalForm.halabardnik.PotencjalObrony(originalForm.listHalabardnik.Count(), originalForm.halabardnik.obrona, originalForm.halabardnik.poziomUlepszenia).ToString();
             labelPotencjalObronyOgolnie.Text = "Potencjał obrony jednostek: " + originalForm.jednostkiDefensywne.PotencjalObronyOgolnie(originalForm.peltasta.potencjalObrony, originalForm.lucznik.potencjalObrony, originalForm.halabardnik.potencjalObrony).ToString();*/
        }

        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy peltasta(dodajemy go do listy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPeltasta_Click(object sender, EventArgs e)
        {
            if(originalForm.zloto.ilosc >= 5)
            {
                originalForm.zloto.ilosc -= 5;
                originalForm.listPeltasta.Add(originalForm.peltasta);
                MessageBox.Show(originalForm.listPeltasta.Count().ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }
           
        }
        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy łucznika(dodajemy go do listy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLucznik_Click(object sender, EventArgs e)
        {
            if(originalForm.zloto.ilosc >= 10)
            {
                originalForm.zloto.ilosc -= 10;
                originalForm.listLucznik.Add(originalForm.lucznik);
                MessageBox.Show(originalForm.listLucznik.Count().ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }

        }
        /// <summary>
        /// jeśli posiadamy określoną ilość złota to po klikneciu na button werbujemy halabardnika(dodajemy go do listy)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHalabardnik_Click(object sender, EventArgs e)
        {
            if (originalForm.zloto.ilosc >= 15)
            {
                originalForm.zloto.ilosc -= 15;
                originalForm.listHalabardnik.Add(originalForm.halabardnik);
                MessageBox.Show(originalForm.listHalabardnik.Count().ToString());
            }
            else
            {
                MessageBox.Show("Brak złota!");
            }

        }

        private void buttonZamiana_Click(object sender, EventArgs e)
        {
            timerKoszary2.Stop();
            this.Close();
            new Koszary(originalForm).Show();
        }

        private void buttonAnuluj_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZwiadowca_Click(object sender, EventArgs e)
        {
            timerKoszary2.Stop();
            this.Close();
            new KoszaryZwiadowca(originalForm).Show();
        }
    }
}
