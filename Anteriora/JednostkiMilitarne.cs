using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int liczebnoscAtakujacych { get; set; }
        public int liczebnoscBroniacych { get; set; }
        public int poziomUlepszenia { get; set; }
        public int atakDomyslny { get; set; }
        public int atak { get; set; }
        public int obronaDomyslna { get; set; }
        public int obrona { get; set; }
        public int PZDomyslne { get; set; }
        public int PZ { get; set; }
        public int stalePZ { get; set; }
        public int calkowitePZ { get; set; }
        public int odlegloscAtaku { get; set; }
        public PictureBox pictureBox { get; set; }
        public Bitmap obrazekPrawo { get; set; }
        public Bitmap obrazekLewo { get; set; }
        public Bitmap obrazekGora { get; set; }
        public Bitmap obrazekDol { get; set; }
        public ProgressBar progressBarPZ { get; set; }
        public Label labelPZ { get; set; }
        public Label labelNazwa { get; set; }
        public Label labelIlosc { get; set; }
        public Label labelAtak { get; set; }
        public Label labelObrona { get; set; }
        public bool czyAtakNaBliskiDystans { get; set; }

        public int ObliczPZJednostki()
        {
            return PZ = PZDomyslne * poziomUlepszenia;
        }
        public int ObliczCalkowitePZ()
        {
            return calkowitePZ = (stalePZ * liczebnoscAtakujacych) - (stalePZ - PZ);
        }

        public int ObliczAtakJednostki()
        {
            return atak = atakDomyslny * poziomUlepszenia;
        }

        public int ObliczObroneJednostki()
        {
            return obrona = obronaDomyslna * poziomUlepszenia;
        }

        public int ObliczCalkowityAtak()
        {
            ObliczAtakJednostki();
            return atak * liczebnoscAtakujacych;
        }
    }
}
