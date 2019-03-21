using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    /// <summary>
    /// klasa JednostkiDefensywne dziedzicząca cechy z JednostkiMilitarnej określa potencjał obrony jednostek defensywnych
    /// </summary>
    public class JednostkiDefensywne : JednostkiMilitarne
    {
        // dla jednostki
        public int potencjalObrony { get; set; }
        // dla wszystkich jednostek
        public int potencjalObronyOgolnie { get; set; }

        public int ObliczPotencjalObrony(int ilosc, int obrona, int poziomUlepszenia)
        {
            potencjalObrony = ilosc * obrona * poziomUlepszenia;
            return potencjalObrony;
        }

        public int ObliczPotencjalObronyOgolnie(int potencjalObrony1, int potencjalObrony2, int potencjalObrony3)
        {
            potencjalObronyOgolnie = potencjalObrony1 + potencjalObrony2 + potencjalObrony3;
            return potencjalObronyOgolnie;
        }
    }
}
