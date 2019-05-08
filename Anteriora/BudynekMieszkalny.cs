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
    public partial class BudynekMieszkalny : Form
    {
        Osada o1;
        Poczatek o2;
        public BudynekMieszkalny(Osada c1, Poczatek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            timerBudynekMieszkalny.Start();

            o2.mieszkancy.OkreslZyczeniaMieszkancow(textBoxListaZyczen,o2.mieszkancy);
        }       

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerBudynekMieszkalny_Tick(object sender, EventArgs e)
        {
            o2.mieszkancy.OkreslZyczeniaMieszkancow(textBoxListaZyczen, o2.mieszkancy);

            if (o2.mieszkancy.liczbaMiejscBudynku == o2.mieszkancy.liczbaMieszkancow)
            {
                o2.mieszkancy.czyPrzyrostMieszkancow = false;
            }

            labelLiczbaMiejscBudynku.Text = o2.mieszkancy.ObliczLiczbeMiejscBudynku(o1.budynekMieszkalny).ToString();
            labelLiczbaMieszkancow.Text = o2.mieszkancy.liczbaMieszkancow.ToString();
            labelLiczbaPracujacychMieszkancow.Text = o2.mieszkancy.liczbaPracujacychMieszkancow.ToString();
            labelLiczbaBezrobotynchMieszkancow.Text = o2.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow().ToString();
            labelPoziomZadowolenia.Text = o2.mieszkancy.poziomZadowolenia.ToString();

            if(o2.mieszkancy.czyPrzyrostMieszkancow == true)
            {
                pictureBoxStrzalka1.Visible = true;
                pictureBoxStrzalka2.Visible = true;
            }
            else if(o2.mieszkancy.czyPrzyrostMieszkancow == false)
            {
                pictureBoxStrzalka1.Visible = false;
                pictureBoxStrzalka2.Visible = false;
            }
        }

        private void buttonOtwarty_Click(object sender, EventArgs e)
        {
            if(o2.ubraniaMieszkancow.ilosc < 1 && o2.lozko.ilosc < 1)
            {
                new Wiadomosc("Brakuje ubrań lub łóżek dla mieszkańców.").ShowDialog();
            }
            else
            {
                o2.mieszkancy.czyPrzyrostMieszkancow = true;
            }
        }

        private void buttonZamkniety_Click(object sender, EventArgs e)
        {
            o2.mieszkancy.czyPrzyrostMieszkancow = false;
        }

        private void buttonSpelnijZyczenia_Click(object sender, EventArgs e)
        {
            switch(o2.mieszkancy.poziomZadowolenia)
            {
                case 0:
                    if (o2.drewno.ilosc >= 5 * o2.mieszkancy.liczbaMieszkancow)
                    {
                        o2.drewno.ilosc -= 5 * o2.mieszkancy.liczbaMieszkancow;
                        o2.mieszkancy.poziomZadowolenia = 1;
                    }
                    else
                    {
                        MessageBox.Show("nie jestes w stanie spelnic zyczen mieszkancow");
                    }
                    break;
                case 1:
                    if(o2.drewno.ilosc >= 10 * o2.mieszkancy.liczbaMieszkancow)
                    {
                        o2.drewno.ilosc -= 10 * o2.mieszkancy.liczbaMieszkancow;
                        o2.mieszkancy.poziomZadowolenia = 2;
                    }
                    else
                    {
                        MessageBox.Show("nie jestes w stanie spelnic zyczen mieszkancow");
                    }
                    break;
                case 2:
                    if(o2.drewno.ilosc >= 20 * o2.mieszkancy.liczbaMieszkancow && o2.kamień.ilosc >= 10 * o2.mieszkancy.liczbaMieszkancow)
                    {
                        o2.drewno.ilosc -= 20 * o2.mieszkancy.liczbaMieszkancow;
                        o2.kamień.ilosc -= 10 * o2.mieszkancy.liczbaMieszkancow;
                        o2.mieszkancy.poziomZadowolenia = 3;
                    }
                    else
                    {
                        MessageBox.Show("nie jestes w stanie spelnic zyczen mieszkancow");
                    }
                    break;
                case 3:
                    if (o2.drewno.ilosc >= 50 * o2.mieszkancy.liczbaMieszkancow && o2.kamień.ilosc >= 20 * o2.mieszkancy.liczbaMieszkancow && o2.siano.ilosc >= 10 * o2.mieszkancy.liczbaMieszkancow)
                    {
                        o2.drewno.ilosc -= 50 * o2.mieszkancy.liczbaMieszkancow;
                        o2.kamień.ilosc -= 20 * o2.mieszkancy.liczbaMieszkancow;
                        o2.siano.ilosc -= 10 * o2.mieszkancy.liczbaMieszkancow;
                        o2.mieszkancy.poziomZadowolenia = 4;
                    }
                    else
                    {
                        MessageBox.Show("nie jestes w stanie spelnic zyczen mieszkancow");
                    }
                    break;
            }
        }
    }
}
