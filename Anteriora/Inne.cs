using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Anteriora
{
    public class Inne : Wyposazenie
    {
        public Inne(string nazwa, string kod, Bitmap obrazek, int iloscPotrzebnejWelny)
        {
            this.nazwa = nazwa;
            this.iloscPotrzebnegoDrewna = 3;
            this.iloscPotrzebnychSkorzanychPaskow = 3;
            this.iloscPotrzebnejWelny = iloscPotrzebnejWelny;
            this.kod1 = kod;
            this.obrazek = obrazek;
        }
    }
}
