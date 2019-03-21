using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    /// <summary>
    ///  klasa JednostkiOfensywne dziedzicząca cechy z JednostkiMilitarne określa potencjał ataku składający się z cech jednostki
    /// </summary>
    public class JednostkiGracza : JednostkiMilitarne
    {
        // potencjał ataku dla określonego typu jednostki
        public int potencjalAtaku { get; set; }
        // potencjał ataku dla wszystkich jednostek offensywnych
        public int potencjalAtakuOgolnie { get; set; }

        // potencjał ataku określonej jednostki
        public int ObliczPotencjalAtaku(int ilosc,int atak, int poziomUlepszenia)
        {
            return potencjalAtaku = ilosc * atak * poziomUlepszenia;
        }

        // suma wszystkich potencjałów
        public int ObliczPotencjalAtakuWszystkichJednostek(int potencjalAtaku1, int potencjalAtaku2, int potencjalAtaku3)
        {
            return potencjalAtakuOgolnie = potencjalAtaku1 + potencjalAtaku2 + potencjalAtaku3; 
        }

        public JednostkiGracza(string nazwa, int poziomUlepszenia, int atakDomyslny, int obrona, int PZDomyslne, int ilosc, int odlegloscRuch,
               int odlegloscAtak, string obrazekPrawo, string obrazekLewo, string obrazekGora, string obrazekDol)
        {
            this.nazwa = nazwa;
            this.poziomUlepszenia = poziomUlepszenia;
            this.atakDomyslny = atakDomyslny;
            this.obrona = obrona;
            this.PZDomyslne = PZDomyslne;
            this.ilosc = ilosc;
            this.odlegloscRuch = odlegloscRuch;
            this.odlegloscAtak = odlegloscAtak;
            this.obrazekPrawo = obrazekPrawo;
            this.obrazekLewo = obrazekLewo;
            this.obrazekGora = obrazekGora;
            this.obrazekDol = obrazekDol;
            
        }

        public JednostkiGracza()
        {

        }

        public JednostkiGracza(int ilosc, int poziomUlepszenia, int atakDomyslny)
        {
            this.ilosc = ilosc;
            this.poziomUlepszenia = poziomUlepszenia;
            this.atakDomyslny = atakDomyslny;
        }
    }
}
