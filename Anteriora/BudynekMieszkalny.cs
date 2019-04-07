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
        Początek o2;
        public BudynekMieszkalny(Osada c1, Początek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            timerBudynekMieszkalny.Start();
        }       

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerBudynekMieszkalny_Tick(object sender, EventArgs e)
        {
            if(o1.mieszkancy.liczbaMiejscBudynku == o1.mieszkancy.liczbaMieszkancow)
            {
                o1.mieszkancy.czyPrzyrostMieszkancow = false;
            }

            labelLiczbaMiejscBudynku.Text = o1.mieszkancy.ObliczLiczbeMiejscBudynku(o1.budynekMieszkalny).ToString();
            labelLiczbaMieszkancow.Text = o1.mieszkancy.liczbaMieszkancow.ToString();
            labelLiczbaPracujacychMieszkancow.Text = o1.mieszkancy.liczbaPracujacychMieszkancow.ToString();
            labelLiczbaBezrobotynchMieszkancow.Text = o1.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow().ToString();
            labelPoziomZadowolenia.Text = o1.mieszkancy.poziomZadowolenia.ToString();

            if(o1.mieszkancy.czyPrzyrostMieszkancow == true)
            {
                pictureBoxStrzalka1.Visible = true;
                pictureBoxStrzalka2.Visible = true;
            }
            else if(o1.mieszkancy.czyPrzyrostMieszkancow == false)
            {
                pictureBoxStrzalka1.Visible = false;
                pictureBoxStrzalka2.Visible = false;
            }
        }

        private void buttonOtwarty_Click(object sender, EventArgs e)
        {
            o1.mieszkancy.czyPrzyrostMieszkancow = true;
        }

        private void buttonZamkniety_Click(object sender, EventArgs e)
        {
            o1.mieszkancy.czyPrzyrostMieszkancow = false;
        }
    }
}
