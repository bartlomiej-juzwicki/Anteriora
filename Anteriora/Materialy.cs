using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    /// <summary>
    /// klasa Materiały określa cechy możliwych do zdobycia surowców
    /// </summary>
    public class Materialy
    {
        public int ilosc { get; set; }
        public int poziomUlepszenia { get; set; }
        // jesli glod = 1 to brak glodu a gdy = 2 to glod
        public static int glod = 1;
        public int poziomEksploatacji { get; set; }
        public string kod { get; set; }
        public const int iloscPotrzebnejRudy = 9;
        public Bitmap obrazek { get; set; }

        public Materialy(int ilosc)
        {
            this.ilosc = ilosc;
            poziomEksploatacji = 0;
        }

        // z każdym poziomem ulepszenia budowli(lub kilku tych samych) rośnie ilość zdobywanych surowców
        public int ZwiekszPrzyrostMaterialu()
        {
            ilosc += (poziomEksploatacji * poziomUlepszenia)/glod;
            return (poziomEksploatacji * poziomUlepszenia) / glod;
        }

        public void ObliczPoziomUlepszenia(int poziomUlepszenia1, int poziomUlepszenia2)
        {
            poziomUlepszenia = poziomUlepszenia1 + poziomUlepszenia2;
        }

        public void ObliczPoziomUlepszenia(int poziomUlepszenia1, int poziomUlepszenia2, int poziomUlepszenia3)
        {
            poziomUlepszenia = poziomUlepszenia1 + poziomUlepszenia2 + poziomUlepszenia3;
        }

    }
}
