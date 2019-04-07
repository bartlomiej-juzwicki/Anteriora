using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    /// <summary>
    /// klasa Materiały określa cechy możliwych do zdobycia surowców
    /// </summary>
    public class Materiały
    {
        public int ilosc { get; set; }
        public int poziomUlepszenia { get; set; }
        // jesli glod = 1 to brak glodu a gdy = 2 to glod
        public static int glod = 1;
        public int poziomEksploatacji { get; set; }

        public Materiały(int ilosc)
        {
            this.ilosc = ilosc;
            poziomEksploatacji = 1;
        }

        // z każdym poziomem ulepszenia budowli(lub kilku tych samych) rośnie ilość zdobywanych surowców
        public void ZwiekszPrzyrostMaterialu(int poziomEksploatacji)
        {
            ilosc += (poziomEksploatacji * poziomUlepszenia)/glod;
        }

        public void ObliczPoziomUlepszenia(int poziomUlepszenia, int poziomUlepszenia2, int poziomUlepszenia3)
        {
            this.poziomUlepszenia = poziomUlepszenia + poziomUlepszenia2 + poziomUlepszenia3;
        }

    }
}
