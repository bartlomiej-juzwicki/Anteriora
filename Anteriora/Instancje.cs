using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class Instancje
    {
        public string nazwa { get; set; }
        public int czasRuchuWrogow { get; set; }
        public int czasWroga { get; set; }
        public int czasRuchuZwiadowcy { get; set; }
        public int czasZwiadowcy { get; set; }
        public int licznikZwiadowca { get; set; }
        public bool akcjaWrog { get; set; }
        public bool akcjaZwiadowca { get; set; }
        public string obrazekLewo { get; set; }
        public string obrazekGora { get; set; }
        public string obrazekDol { get; set; }
        public bool enablePoziom1 { get; set; }
        public bool enablePoziom2 { get; set; }
        public bool enablePoziom3 { get; set; }
        public bool enablePoziom4 { get; set; }
        public bool enablePoziom5 { get; set; }
        public int postep { get; set; }
        public bool czyBlokadaIstnieje { get; set; }



        public Instancje(string nazwa, int czasRuchuWrogow, int czasRuchuZwiadowcy, string obrazekLewo, string obrazekGora, string obrazekDol)
        {
            this.nazwa = nazwa;
            this.czasRuchuWrogow = czasRuchuWrogow;
            this.czasRuchuZwiadowcy = czasRuchuZwiadowcy;
            this.obrazekLewo = obrazekLewo;
            this.obrazekGora = obrazekGora;
            this.obrazekDol = obrazekDol;

            czyBlokadaIstnieje = true;
            czasWroga = 0;
            czasZwiadowcy = 0;
            licznikZwiadowca = 1;
            postep = 1;
            akcjaWrog = false;
            akcjaZwiadowca = false;
            enablePoziom1 = true;
            enablePoziom2 = false;
            enablePoziom3 = false;
            enablePoziom4 = false;
            enablePoziom5 = false;
        }
    }

    




}
