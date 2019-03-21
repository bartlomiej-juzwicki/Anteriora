using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    public partial class EkranLadowania : Form
    {
        Początek o1;
        Osada o2;
        public int ktoryEkranLadowania = 0;

        public EkranLadowania(Początek c1,Osada c2,string nazwaObrazu)
        {

            o1 = c1;
            o2 = c2;

            var o = Properties.Resources.ResourceManager.GetObject(nazwaObrazu);

            if(nazwaObrazu == "load2")
            {
                ktoryEkranLadowania = 1;
            }
            else if(nazwaObrazu == "load")
            {
                ktoryEkranLadowania = 2;
            }
        
          
            
            InitializeComponent();
            this.BackgroundImage = (Image)o;
            timerLadowanie.Start();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }  
       
        private void timerLadowanie_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);

            if(progressBar1.Value == 50 && ktoryEkranLadowania == 1)
            {
                new Osada(o1).Show();
                o1.Hide();
            }
            else if (progressBar1.Value == 100 && ktoryEkranLadowania == 1)
            {               
                this.Close();
            }
            else if(progressBar1.Value == 50 && ktoryEkranLadowania == 2)
            {
                new Mapa(o2, o1).Show();                                 
            }
            else if (progressBar1.Value == 100 && ktoryEkranLadowania == 2)
            {             
                this.Close();
            }
        }
    }
}
