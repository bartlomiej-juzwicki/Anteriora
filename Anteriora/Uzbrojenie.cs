using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Anteriora
{
    public class Uzbrojenie : Wyposazenie
    {
        public Uzbrojenie(string nazwa, int iloscPotrzebnejSkory, int iloscPotrzebnegoZelaza, int iloscPotrzebnegoObsydianu, string kod1, Bitmap obrazek)
        {
            this.nazwa = nazwa;
            ilosc = 0;
            this.iloscPotrzebnejSkory = iloscPotrzebnejSkory;
            this.iloscPotrzebnegoZelaza = iloscPotrzebnegoZelaza;
            this.iloscPotrzebnegoObsydianu = iloscPotrzebnegoObsydianu;
            this.kod1 = kod1;
            this.obrazek = obrazek;
        }
        
        public Uzbrojenie(string nazwa, int iloscPotrzebnejSkory, int iloscPotrzebnegoZelaza, int iloscPotrzebnegoObsydianu, string kod1, string kod2, Bitmap obrazek)
        {
            this.nazwa = nazwa;
            ilosc = 0;
            this.iloscPotrzebnejSkory = iloscPotrzebnejSkory;
            this.iloscPotrzebnegoZelaza = iloscPotrzebnegoZelaza;
            this.iloscPotrzebnegoObsydianu = iloscPotrzebnegoObsydianu;
            this.kod1 = kod1;
            this.kod2 = kod2;
            this.obrazek = obrazek;
        }

        //tarcza
        public Uzbrojenie(string nazwa, string kod1, Bitmap obrazek)
        {
            this.nazwa = nazwa;
            ilosc = 0;
            iloscPotrzebnegoDrewna = 4;
            iloscPotrzebnegoZelaza = 5;
            iloscPotrzebnegoObsydianu = 5;
            this.kod1 = kod1;
            this.obrazek = obrazek;
        }

        
    }
}
