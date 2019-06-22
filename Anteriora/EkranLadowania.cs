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
        Poczatek o1;
        Osada o2;
        Mapa o3;

        public int ktoryEkranLadowania = 0;

        public EkranLadowania(Poczatek c1,Osada c2, Size size, int numer)
        {
            o1 = c1;
            o2 = c2;

            InitializeComponent();

            if (numer == 1)
            {
                ktoryEkranLadowania = 1;
            }
            else if (numer == 2)
            {
                ktoryEkranLadowania = 2;
            }
            else if (numer == 4)
            {
                progressBar1.Maximum = 20;
                pictureBox1.Location = new Point(92, 205);
                ktoryEkranLadowania = 4;
            }

            this.Size = size;

            timerLadowanie.Start();
        }

        public EkranLadowania(Poczatek c1, Osada c2,Mapa c3, int numer)
        {

            o1 = c1;
            o2 = c2;
            o3 = c3;

            if (numer == 1)
            {
                ktoryEkranLadowania = 1;
            }
            else if (numer == 2)
            {
                ktoryEkranLadowania = 2;
            }
            else if(numer == 3)
            {
                ktoryEkranLadowania = 3;
            }



            InitializeComponent();
            timerLadowanie.Start();
        }

        public EkranLadowania(int numer)
        {
            if (numer == 5)
            {
                ktoryEkranLadowania = 5;
            }

            InitializeComponent();
            timerLadowanie.Start();
        }

        private void timerLadowanie_Tick(object sender, EventArgs e)
        {
            //do zmiany cala mechanika
            pictureBox1.Size = new Size(pictureBox1.Width + 100, pictureBox1.Height);

            if (progressBar1.Value == 20 && ktoryEkranLadowania == 1)
            {
                new Osada(o1).Show();
                
                o1.Hide();
            }
            else if (progressBar1.Value == 20 && ktoryEkranLadowania == 2)
            {
                new Mapa(o2, o1).Show();
            }
            else if (progressBar1.Value == 20 && ktoryEkranLadowania == 3)
            {
                new OsadaGoblinow(o2, o1, o3).Show();
            }
            else if(progressBar1.Value == 0 && ktoryEkranLadowania == 4)
            {
                new Mur(o1, o2).Show();
            }
            else if (progressBar1.Value == 20 && ktoryEkranLadowania == 5)
            {
                new Poczatek().Show();
            }
            else if (progressBar1.Value == 40 && (ktoryEkranLadowania == 1 || ktoryEkranLadowania == 2 || ktoryEkranLadowania == 3 || ktoryEkranLadowania == 5))
            {
                this.Close();
            }
            else if(progressBar1.Value == 20 && ktoryEkranLadowania == 4)
            {
                this.Close();
            }

            progressBar1.Increment(5);
        }
    }
}
