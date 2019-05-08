using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public class Mieszkancy : Budowle
    {
        public int liczbaMiejscBudynku { get; set; }
        public int liczbaMieszkancow { get; set; }
        public int liczbaPracujacychMieszkancow { get; set; }
        public int liczbaBezrobotnychMieszkancow { get; set; }
        public int poziomZadowolenia { get; set; }
        public int liczebnoscWojsk { get; set; }
        public bool czyPrzyrostMieszkancow { get; set; }
        public int poziomPodatkow { get; set; }


        public Mieszkancy()
        {
            liczbaMiejscBudynku = 100;
            liczbaMieszkancow = 20;
            ObliczLiczbeBezrobotnychMieszkancow();
            czyPrzyrostMieszkancow = false;
        }

        public int ObliczLiczbeBezrobotnychMieszkancow()
        {
            return liczbaBezrobotnychMieszkancow = liczbaMieszkancow - liczbaPracujacychMieszkancow - liczebnoscWojsk;
        }

        public int ObliczLiczbeMiejscBudynku(Budowle budowla)
        {
            return liczbaMiejscBudynku = 100 * (budowla.poziomUlepszenia * budowla.poziomUlepszenia);
        }

        public void OkreslZyczeniaMieszkancow(TextBox textBox, Mieszkancy mieszkancy)
        {
            switch(poziomZadowolenia)
            {
                case 0:
                    textBox.Text = "Drewno: " + 5 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Siano:" + 5 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;
                case 1:
                    textBox.Text = "Drewno: " + 10 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Siano:" + 10 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;
                case 2:
                    textBox.Text = "Drewno: " + 20 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Siano:" + 15 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Kamień:" + 10 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;
                case 3:
                    textBox.Text = "Drewno: " + 50 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Kamień :" + 20 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Siano: " + 10 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;
                case 4:
                    textBox.Text = "Kamień: " + 50 * mieszkancy.liczbaMieszkancow + " sztuk" + Environment.NewLine + "Żelazo: " + 20 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;
                case 5:
                    textBox.Text = "Żelazo: " + 50 * mieszkancy.liczbaMieszkancow + " sztuk";
                    break;


                    // to do: dokończyć dla kilku poziomow zadowolenia, pomixować materialy potrzebne do spelnienia zyczen
            }
        }
    }
}
