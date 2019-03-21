using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class Mieszkancy
    {
        public int liczbaMieszkancow { get; set; }
        public int liczbaPracujacychMieszkancow { get; set; }
        public int liczbaBezrobotnychMieszkancow { get; set; }
        public int poziomZadowolenia { get; set; }

        public Mieszkancy()
        {
            liczbaMieszkancow = 5;
            liczbaPracujacychMieszkancow = 0;
            poziomZadowolenia = 1;
            ObliczLiczbeBezrobotnychMieszkancow();
 
        }

        public int ObliczLiczbeBezrobotnychMieszkancow()
        {
            return liczbaBezrobotnychMieszkancow = liczbaMieszkancow - liczbaPracujacychMieszkancow;
        }
    }

    
}
