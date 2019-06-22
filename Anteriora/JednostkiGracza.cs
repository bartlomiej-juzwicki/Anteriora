using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class JednostkiGracza : JednostkiMilitarne
    {
        //public int liczebnoscWojsk { get; set; }

        //readonly Poczatek o;

        public JednostkiGracza(string nazwa, int atakDomyslny, int obronaDomyslna, int PZDomyslne, int ilosc, int odlegloscAtaku, bool czyAtakNaBliskiDystans,
                                Bitmap obrazekPrawo, Bitmap obrazekLewo, Bitmap obrazekGora, Bitmap obrazekDol)
        {
            this.nazwa = nazwa;
            this.poziomUlepszenia = 1;
            this.atakDomyslny = atakDomyslny; 
            this.obronaDomyslna = obronaDomyslna;
            this.PZDomyslne = PZDomyslne;
            this.liczebnoscAtakujacych = ilosc;
            this.odlegloscAtaku = odlegloscAtaku;
            this.czyAtakNaBliskiDystans = czyAtakNaBliskiDystans;
            this.obrazekPrawo = obrazekPrawo;
            this.obrazekLewo = obrazekLewo;
            this.obrazekGora = obrazekGora;
            this.obrazekDol = obrazekDol;
        }

        //zwiadowca
        public JednostkiGracza()
        {
            this.atakDomyslny = 30;
            this.poziomUlepszenia = 1;
        }

        //public int ObliczLiczebnoscWojsk()
        //{
        //    return liczebnoscWojsk = o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych;
        //}
    }
}
