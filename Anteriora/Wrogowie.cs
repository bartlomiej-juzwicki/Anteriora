using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public class Wrogowie : JednostkiMilitarne
    {
       


        public Wrogowie(string nazwa, int atak, int obrona, int PZ, int odlegloscAtak, int odlegloscRuch, string obrazekPrawo, string obrazekLewo, string obrazekGora, string obrazekDol)
        {
            this.nazwa = nazwa;
            this.atak = atak;
            this.obrona = obrona;
            this.PZ = PZ;
            this.odlegloscAtak = odlegloscAtak;
            this.odlegloscRuch = odlegloscRuch;
            this.obrazekPrawo = obrazekPrawo;
            this.obrazekLewo = obrazekLewo;
            this.obrazekGora = obrazekGora;
            this.obrazekDol = obrazekDol;

            stalePZ = PZ;
        }

      
    }
}
