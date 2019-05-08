using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public class Przeciwnicy : JednostkiMilitarne
    {
       


        public Przeciwnicy(string nazwa,int atakDomyslny, int obronaDomyslna,int PZDomyslne, int odlegloscAtaku, Bitmap obrazekPrawo, Bitmap obrazekLewo, Bitmap obrazekGora, Bitmap obrazekDol)
        {
            this.poziomUlepszenia = 1;
            this.nazwa = nazwa;
            this.atakDomyslny = atakDomyslny;
            this.obronaDomyslna = obrona;
            this.PZDomyslne = PZDomyslne;
            this.odlegloscAtaku = odlegloscAtaku;
            this.obrazekPrawo = obrazekPrawo;
            this.obrazekLewo = obrazekLewo;
            this.obrazekGora = obrazekGora;
            this.obrazekDol = obrazekDol;
        }

        public Przeciwnicy()
        {
        }

      
    }
}
