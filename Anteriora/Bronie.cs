using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class Bronie : Wyposazenie
    {
        public Bronie(string nazwa, int iloscPotrzebnychKawalkowDrewna, int iloscPotrzebnegoKamienia, int iloscPotrzebnegoZelaza, int iloscPotrzebnegoObsydianu, string kod1, string kod2, string kod3, Bitmap obrazek)
        {
            this.nazwa = nazwa;
            ilosc = 0;
            this.iloscPotrzebnegoKamienia = iloscPotrzebnegoKamienia;
            this.iloscPotrzebnychKawalkowDrewna = iloscPotrzebnychKawalkowDrewna;
            this.iloscPotrzebnegoZelaza = iloscPotrzebnegoZelaza;
            this.iloscPotrzebnegoObsydianu = iloscPotrzebnegoObsydianu;
            this.kod1 = kod1;
            this.kod2 = kod2;
            this.kod3 = kod3;
            this.obrazek = obrazek;
        }

        /// <summary>
        /// konstruktor do tworzenia obiektu łuk
        /// </summary>
        /// <param name="nazwa"></param>
        /// <param name="iloscPotrzebnychKawalkowDrewna"></param>
        /// <param name="iloscPotrzebnychSkorzanychPaskow"></param>
        /// <param name="kod"></param>
        /// <param name="obrazek"></param>
        public Bronie(string nazwa, int iloscPotrzebnychKawalkowDrewna, int iloscPotrzebnychSkorzanychPaskow, string kod1, string kod2, Bitmap obrazek)
        {
            this.nazwa = nazwa;
            ilosc = 0;
            this.iloscPotrzebnychKawalkowDrewna = iloscPotrzebnychKawalkowDrewna;
            this.iloscPotrzebnychSkorzanychPaskow = iloscPotrzebnychSkorzanychPaskow;
            this.kod1 = kod1;
            this.kod2 = kod2;
            this.obrazek = obrazek;
        }
    }
}