using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public class Mieszkancy: Budowle
    {
        public int liczbaMiejscBudynku { get; set; }
        public int liczbaMieszkancow { get; set; }
        public int liczbaPracujacychMieszkancow { get; set; }
        public int liczbaBezrobotnychMieszkancow { get; set; }
        public int poziomZadowolenia { get; set; }
        public bool czyPrzyrostMieszkancow { get; set; }
        public int poziomPodatkow { get; set; }


        public Mieszkancy()
        {
            liczbaMiejscBudynku = 100;
            liczbaMieszkancow = 5;
            liczbaPracujacychMieszkancow = 0;
            poziomZadowolenia = 1;
            poziomPodatkow = 1;
            ObliczLiczbeBezrobotnychMieszkancow();
            czyPrzyrostMieszkancow = false;
        }

        public int ObliczLiczbeBezrobotnychMieszkancow()
        {
            return liczbaBezrobotnychMieszkancow = liczbaMieszkancow - liczbaPracujacychMieszkancow;
        }

        public int ObliczLiczbeMiejscBudynku(Budowle budowla)
        {
            return liczbaMiejscBudynku = 100 * (budowla.poziomUlepszenia * budowla.poziomUlepszenia);
        }

       
     
    }

    
}
