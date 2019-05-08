using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Anteriora
{
    public class Wyposazenie
    {
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public int iloscPotrzebnejSkory { get; set; }
        public int iloscPotrzebnegoKamienia { get; set; }
        public int iloscPotrzebnegoDrewna { get; set; }
        public int iloscPotrzebnegoZelaza { get; set; }
        public int iloscPotrzebnegoObsydianu { get; set; }
        public int iloscPotrzebnychKawalkowDrewna { get; set; }
        public int iloscPotrzebnejWelny { get; set; }
        public int iloscPotrzebnychSkorzanychPaskow { get; set; }
        public string kod1 { get; set; } //sekwencja znaków potrzebna do wytworzenia przedmiotu w kuźni (max 9 znaków)
        public string kod2 { get; set; }
        public string kod3 { get; set; }
        public Bitmap obrazek { get; set; }
    }
}
