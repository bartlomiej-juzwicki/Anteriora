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
    public partial class KoszaryZwiadowca : Form
    {
        Osada o1;
        Koszary o2;
       
        public KoszaryZwiadowca(Osada c1)
        {
            o1 = c1;
            
            InitializeComponent();
            textBoxNotatkaZwiadowcy.Text = o1.notatkaZwiadowcy;
            labelZwiadowcaIlosc.Text = "Ilość zwiadowców: "+ o1.zwiadowca.ilosc.ToString();
            labelZwiadowcaAtak.Text = "Szansa na powodzenie: 0%";
            labelZwiadowcaPoziomUlepszenia.Text ="Poziom zwiadowców: " + o1.zwiadowca.poziomUlepszenia.ToString();
            timerZwiadowcaTekst.Start();
            //textBoxNotatkaZwiadowcy.Text = o1.InformacjaNaTematPrzeciwnika(o1.osadaGoblinow,1, o1.nietoperzDuzy, 6);
            
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            o1.notatkaZwiadowcy ="";
            timerZwiadowcaTekst.Stop();
            this.Close();
        }

        private void buttonZamiana2_Click(object sender, EventArgs e)
        {
            timerZwiadowcaTekst.Stop();
            this.Close();
            new Koszary2(o1, o2).Show();
        }

        private void buttonZamiana_Click(object sender, EventArgs e)
        {
            this.Close();
            timerZwiadowcaTekst.Stop();
            new Koszary(o1).Show();
        }

        private void buttonDziennik_Click(object sender, EventArgs e)
        {
            new Dziennik(o1).ShowDialog();
        }

        private void buttonZapisDoDziennika_Click(object sender, EventArgs e)
        {
            o1.zapisDoDziennika = o1.zapisDoDziennika + Environment.NewLine + textBoxNotatkaZwiadowcy.Text;
        }

        private void buttonZwiadowca_Click(object sender, EventArgs e)
        {
            if(o1.zwiadowca.ilosc < 1 )
            {
                if (o1.zloto.ilosc >= 1)
                {
                    o1.zloto.ilosc -= 1;
                    o1.zwiadowca.ilosc++;
                    labelZwiadowcaIlosc.Text = "Ilość zwiadowców: " + o1.zwiadowca.ilosc.ToString();
                    labelZwiadowcaAtak.Text = "Szansa na powodzenie: " + o1.zwiadowca.ObliczAtakJednostki().ToString() + "%";
                    MessageBox.Show(o1.zwiadowca.ilosc.ToString());
                }
                else
                {
                    MessageBox.Show("Brak złota!");
                }
            }
            else
            {
                MessageBox.Show("Osiągnąłeś maksymalną ilość jednostek!");
            }
            
        }

        private void buttonUlepszZwiadowca_Click(object sender, EventArgs e)
        {
            if(o1.zwiadowca.poziomUlepszenia < 3)
            {
                o1.zwiadowca.poziomUlepszenia++;
                labelZwiadowcaAtak.Text = "Szansa na powodzenie: " + o1.zwiadowca.ObliczAtakJednostki().ToString() + "%";
                labelZwiadowcaPoziomUlepszenia.Text = "Poziom zwiadowców: " + o1.zwiadowca.poziomUlepszenia.ToString();
            }
            else
            {
                MessageBox.Show("Osiągnąłeś maksymalny poziom ulepszenia!");
            }
        }

        private void timerZwiadowcaTekst_Tick(object sender, EventArgs e)
        {
            textBoxNotatkaZwiadowcy.Text = o1.notatkaZwiadowcy;
        }
    }
}
