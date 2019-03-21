using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    /// <summary>
    /// klasa określająca cechy jednostek militarnych
    /// </summary>
    public class JednostkiMilitarne
    {
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public int poziomUlepszenia { get; set; }
        public int atakDomyslny { get; set; }
        public int atak { get; set; }
        public int obrona { get; set; }
        public int PZDomyslne { get; set; }
        public int PZ { get; set; }
        public int stalePZ { get; set; }
        public int calkowitePZ { get; set; }
        public PictureBox pictureBox { get; set; }
        public int odlegloscRuch { get; set; }
        public int odlegloscAtak { get; set; }
        public string obrazekPrawo { get; set; }
        public string obrazekLewo { get; set; }
        public string obrazekGora { get; set; }
        public string obrazekDol { get; set; }
        public ProgressBar progressBarPZ { get; set; }
        public Label labelPZ { get; set; }

        public int ObliczPZJednostki()
        {
            if(ilosc == 0)
            {
                return PZ = 0;
            }
            else
            {
                return PZ = PZDomyslne * poziomUlepszenia;
            }
        }
        public int ObliczCalkowitePZ()
        {
            return calkowitePZ = PZ * ilosc;

        }

        public int ObliczAtakJednostki()
        {
            if(ilosc == 0)
            {
                return atak = 0;
            }
            else
            {
                return atak = atakDomyslny * poziomUlepszenia;
            }
           
        }

        public int ObliczCalkowityAtak()
        {
            return atak * ilosc;
        }




    }
}
