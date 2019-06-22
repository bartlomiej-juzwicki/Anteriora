using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class ObszaryInstancji
    {
        public Przeciwnicy przeciwnik0 { get; set; }
        public Przeciwnicy przeciwnik1 { get; set; }
        public Przeciwnicy przeciwnik2 { get; set; }
        public Przeciwnicy przeciwnik3 { get; set; }
        public Przeciwnicy przeciwnik4 { get; set; }
        public Przeciwnicy przeciwnik5 { get; set; }
        public Przeciwnicy przeciwnik6 { get; set; }

        public bool czyBitwa { get; set; }
        public bool czyOdblokowane { get; set; }

        public ObszaryInstancji()
        {

        }

        public void ZdefiniujPrzeciwnikówNaObszarze(Przeciwnicy przeciwnik1, int ilosc1, Przeciwnicy przeciwnik2, int ilosc2, Przeciwnicy przeciwnik3, int ilosc3, Przeciwnicy przeciwnik4, int ilosc4, Przeciwnicy przeciwnik5, int ilosc5,
                                                Przeciwnicy przeciwnik6, int ilosc6, Przeciwnicy przeciwnik7, int ilosc7) 
        {
            this.przeciwnik0 = przeciwnik1;
            this.przeciwnik0.liczebnoscAtakujacych = ilosc1;
            this.przeciwnik1 = przeciwnik2;
            this.przeciwnik1.liczebnoscAtakujacych = ilosc2;
            this.przeciwnik2 = przeciwnik3;
            this.przeciwnik2.liczebnoscAtakujacych = ilosc3;
            this.przeciwnik3 = przeciwnik4;
            this.przeciwnik3.liczebnoscAtakujacych = ilosc4;
            this.przeciwnik4 = przeciwnik5;
            this.przeciwnik4.liczebnoscAtakujacych = ilosc5;
            this.przeciwnik5 = przeciwnik6;
            this.przeciwnik5.liczebnoscAtakujacych = ilosc6;
            this.przeciwnik6 = przeciwnik7;
            this.przeciwnik6.liczebnoscAtakujacych = ilosc7;
        }
    }
}
