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

        // z każdym poziomem ulepszenia budowli(lub kilku tych samych) rośnie ilość zdobywanych surowców
        public void ZwiekszPrzyrostMaterialu(int poziomUlepszenia, int poziomUlepszenia2, int poziomUlepszenia3)
        {
            ilosc += (poziomUlepszenia + poziomUlepszenia2 + poziomUlepszenia3);
            
        }

    }
}
