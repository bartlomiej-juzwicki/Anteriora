using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    class PostacGracza
    {
        public static string nazwa { get; set; }
        public static Bitmap obrazekGora { get; set; }
        public static Bitmap obrazekDol { get; set; }
        public static Bitmap obrazekLewo { get; set; }
        public static Bitmap obrazekPrawo { get; set; }

        public PostacGracza(int ktoryNumer, string nazwaPostaci)
        {
            nazwa = nazwaPostaci;

            if(ktoryNumer == 1)
            {
                obrazekGora = Properties.Resources.wojownikgora;
                obrazekDol = Properties.Resources.wojownikdol;
                obrazekLewo = Properties.Resources.wojowniklewo;
                obrazekPrawo = Properties.Resources.wojownikprawo;
            }
            else if(ktoryNumer == 2)
            {
                obrazekGora = Properties.Resources.lucznikgora;
                obrazekDol = Properties.Resources.lucznikdol;
                obrazekPrawo = Properties.Resources.lucznikprawo;
                obrazekLewo = Properties.Resources.luczniklewo;
            }
            else if(ktoryNumer == 3)
            {
                // obrazki dla maga
            }
        }
    }
}
