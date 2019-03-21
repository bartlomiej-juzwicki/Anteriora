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
    public partial class MenuPolaBitwy : Form
    {
        Osada o1;
        Mapa o2;
        public int numerInstancji;
        public MenuPolaBitwy(Osada c1, Mapa c2, int numer)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            numerInstancji = numer;

            if(o1.wojownik.ilosc > 0)
            {
                labelWojownikIlosc.Text = o1.wojownik.ilosc.ToString();
                labelWojownikPZ.Text = o1.wojownik.ObliczPZJednostki().ToString();
                labelWojownikCalkowitePZ.Text = o1.wojownik.ObliczCalkowitePZ().ToString();
                labelWojownikAtak.Text = o1.wojownik.ObliczAtakJednostki().ToString();
                labelWojownikCalkowityAtak.Text = o1.wojownik.ObliczCalkowityAtak().ToString();
                labelWojownikObrona.Text = o1.wojownik.obrona.ToString();
            }
            if(o1.lucznik2.ilosc > 0)
            {
                labelLucznikIlosc.Text = o1.lucznik2.ilosc.ToString();
                labelLucznikPZ.Text = o1.lucznik2.ObliczPZJednostki().ToString();
                labelLucznikCalkowitePZ.Text = o1.lucznik2.ObliczCalkowitePZ().ToString();
                labelLucznikAtak.Text = o1.lucznik2.ObliczAtakJednostki().ToString();
                labelLucznikCalkowityAtak.Text = o1.lucznik2.ObliczCalkowityAtak().ToString();
                labelLucznikObrona.Text = o1.lucznik2.obrona.ToString();
            }
            if(o1.wlocznik.ilosc > 0)
            {
                labelWlocznikIlosc.Text = o1.wlocznik.ilosc.ToString();
                labelWlocznikPZ.Text = o1.wlocznik.ObliczPZJednostki().ToString();
                labelWlocznikCalkowitePZ.Text = o1.wlocznik.ObliczCalkowitePZ().ToString();
                labelWlocznikAtak.Text = o1.wlocznik.ObliczAtakJednostki().ToString();
                labelWlocznikCalkowityAtak.Text = o1.wlocznik.ObliczCalkowityAtak().ToString();
                labelWlocznikObrona.Text = o1.wlocznik.obrona.ToString();
            }
            if (o1.zwiadowca.ilosc > 0)
            {
                labelZwiadowcaIlosc.Text = o1.zwiadowca.ilosc.ToString();
                labelZwiadowcaAtak.Text = o1.zwiadowca.ObliczAtakJednostki().ToString() + "%";
            }
            else
            {
                labelZwiadowcaIlosc.Text = 0.ToString();
                labelZwiadowcaAtak.Text = 0.ToString() + "%";
            }

            if(numerInstancji == 1)
            {
                buttonPoziom1.Enabled = o1.osadaGoblinow.enablePoziom1;
                buttonPoziom2.Enabled = o1.osadaGoblinow.enablePoziom2;
                buttonPoziom3.Enabled = o1.osadaGoblinow.enablePoziom3;
                buttonPoziom4.Enabled = o1.osadaGoblinow.enablePoziom4;
                buttonPoziom5.Enabled = o1.osadaGoblinow.enablePoziom5;

                buttonPoziom4.Visible = false;
                buttonPoziom5.Visible = false;


                if (buttonPoziom1.Enabled == false && buttonPoziom2.Enabled == false && buttonPoziom3.Enabled == false)
                {
                    buttonWyslijZwiadowcow.Enabled = false;
                }
            }
            else if (numerInstancji == 2)
            {
                buttonPoziom1.Enabled = o1.jaskiniaWezy.enablePoziom1;
                buttonPoziom2.Enabled = o1.jaskiniaWezy.enablePoziom2;
                buttonPoziom3.Enabled = o1.jaskiniaWezy.enablePoziom3;
                buttonPoziom4.Enabled = o1.jaskiniaWezy.enablePoziom4;
                buttonPoziom5.Enabled = o1.jaskiniaWezy.enablePoziom5;

                buttonPoziom3.Visible = false;
                buttonPoziom4.Visible = false;
                buttonPoziom5.Visible = false;

                if (buttonPoziom1.Enabled == false && buttonPoziom2.Enabled == false)
                {
                    buttonWyslijZwiadowcow.Enabled = false;
                }
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
             new Dziennik(o1).ShowDialog();                   
        }

        private void buttonWyslijZwiadowcow_Click(object sender, EventArgs e)
        {
            if(numerInstancji == 1)
            {
                o2.ZwiadowcaAkcja(o1.osadaGoblinow, 4);
            }
            else if(numerInstancji == 2)
            {
                o2.ZwiadowcaAkcja(o1.jaskiniaWezy, 3);
            }

        }

        

       /* private void textBoxIloscZwiadowcow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Przez takich jak Ty musiałem pisać ten kawałek kodu");
            }
        }
        */

        private void buttonPoziom1_Click(object sender, EventArgs e)
        {
            if (numerInstancji == 1)
            {
                if (o1.osadaGoblinow.czasZwiadowcy == 0)
                {
                    new PoleBitwy(o1, o2, 1.1, 5, 15, 0, "osadagoblinow2").ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poczekaj na powrót zwiadowcy!");
                }
            }
            else if (numerInstancji == 2)
            {
                if (o1.jaskiniaWezy.czasZwiadowcy == 0)
                {
                    new PoleBitwy(o1, o2, 2.1, 30, 20, 10, "osadagoblinow2").ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poczekaj na powrót zwiadowcy!");
                }
            }



        }

        private void buttonPoziom2_Click(object sender, EventArgs e)
        {
            if (numerInstancji == 1)
            {
                if (o1.osadaGoblinow.czasZwiadowcy == 0)
                {
                    new PoleBitwy(o1, o2, 1.2, 10, 15, 0, "osadagoblinow1").ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poczekaj na powrót zwiadowcy!");
                }
            }
            else if (numerInstancji == 2)
            {
                if (o1.jaskiniaWezy.czasZwiadowcy == 0)
                {
                    new PoleBitwy(o1, o2, 2.2, 1, 1, 0, "jaskiniawezyfull2").ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poczekaj na powrót zwiadowcy!");
                }
            }
           

        }

        private void buttonPoziom3_Click(object sender, EventArgs e)
        {
            if(numerInstancji == 1)
            {
                if (o1.osadaGoblinow.czasZwiadowcy == 0)
                {
                    new PoleBitwy(o1, o2, 1.3, 15, 15, 1, "osadagoblinow3").ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poczekaj na powrót zwiadowcy!");
                }
            }
        }
    }
}
