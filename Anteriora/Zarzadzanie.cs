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
    public partial class Zarzadzanie : Form
    {
        Osada o1;
        Początek o2;

        List<Label> podatki = new List<Label>();
        List<Label> drewno = new List<Label>();
        List<Label> kamien = new List<Label>();
        List<Label> siano = new List<Label>();
        List<Label> jedzenie = new List<Label>();
        List<Label> woda = new List<Label>();

        public Zarzadzanie(Osada c1, Początek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();

            timer1.Start();

            #region Dodanie elementów do list

            podatki.Add(labelPodatekPoziom1);
            podatki.Add(labelPodatekPoziom2);
            podatki.Add(labelPodatekPoziom3);
            podatki.Add(labelPodatekPoziom4);
            podatki.Add(labelPodatekPoziom5);

            drewno.Add(labelDrewnoPoziom1);
            drewno.Add(labelDrewnoPoziom2);
            drewno.Add(labelDrewnoPoziom3);
            drewno.Add(labelDrewnoPoziom4);
            drewno.Add(labelDrewnoPoziom5);

            kamien.Add(labelKamienPoziom1);
            kamien.Add(labelKamienPoziom2);
            kamien.Add(labelKamienPoziom3);
            kamien.Add(labelKamienPoziom4);
            kamien.Add(labelKamienPoziom5);

            siano.Add(labelSianoPoziom1);
            siano.Add(labelSianoPoziom2);
            siano.Add(labelSianoPoziom3);
            siano.Add(labelSianoPoziom4);
            siano.Add(labelSianoPoziom5);

            jedzenie.Add(labelJedzeniePoziom1);
            jedzenie.Add(labelJedzeniePoziom2);
            jedzenie.Add(labelJedzeniePoziom3);
            jedzenie.Add(labelJedzeniePoziom4);
            jedzenie.Add(labelJedzeniePoziom5);

            woda.Add(labelWodaPoziom1);
            woda.Add(labelWodaPoziom2);
            woda.Add(labelWodaPoziom3);
            woda.Add(labelWodaPoziom4);
            woda.Add(labelWodaPoziom5);

            #endregion

            #region Sprawdzanie poziomu podatkow i materiałów

            SprawdzPoziomPodatkow(labelPodatekPoziom1, labelPodatekPoziom2, labelPodatekPoziom3, labelPodatekPoziom4, labelPodatekPoziom5);

            SprawdzPoziomEksploatacji(o2.drewno, labelDrewnoPoziom1, labelDrewnoPoziom2, labelDrewnoPoziom3, labelDrewnoPoziom4, labelDrewnoPoziom5);

            SprawdzPoziomEksploatacji(o2.kamień, labelKamienPoziom1, labelKamienPoziom2, labelKamienPoziom3, labelKamienPoziom4, labelKamienPoziom5);

            SprawdzPoziomEksploatacji(o2.siano, labelSianoPoziom1, labelSianoPoziom2, labelSianoPoziom3, labelSianoPoziom4, labelSianoPoziom5);

            SprawdzPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom1, labelJedzeniePoziom2, labelJedzeniePoziom3, labelJedzeniePoziom4, labelJedzeniePoziom5);

            SprawdzPoziomEksploatacji(o2.woda, labelWodaPoziom1, labelWodaPoziom2, labelWodaPoziom3, labelWodaPoziom4, labelWodaPoziom5);

            #endregion
        }

       

        #region Ustawianie poziomu podatków
        private void labelPoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomPodatkow(labelPodatekPoziom1, 1);
        }

        private void labelPoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomPodatkow(labelPodatekPoziom2, 2);

        }

        private void labelPoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomPodatkow(labelPodatekPoziom3, 3);

        }

        private void labelPoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomPodatkow(labelPodatekPoziom4, 4);

        }

        private void labelPoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomPodatkow(labelPodatekPoziom5, 5);

        }
        #endregion Ustawianie poziomu podatków

        #region Ustawianie poziomu

        #region Drewno


        private void labelDrewnoPoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.drewno, labelDrewnoPoziom1, 1, drewno);
        }

        private void labelDrewnoPoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.drewno, labelDrewnoPoziom2, 2, drewno);

        }

        private void labelDrewnoPoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.drewno, labelDrewnoPoziom3, 3, drewno);

        }

        private void labelDrewnoPoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.drewno, labelDrewnoPoziom4, 4, drewno);

        }

        private void labelDrewnoPoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.drewno, labelDrewnoPoziom5, 5, drewno);

        }

        #endregion Drewno

        #region Kamien

        private void labelKamienPoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.kamień, labelKamienPoziom1, 1, kamien);
        }

        private void labelKamienPoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.kamień, labelKamienPoziom2, 2, kamien);
        }

        private void labelKamienPoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.kamień, labelKamienPoziom3, 3, kamien);
        }

        private void labelKamienPoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.kamień, labelKamienPoziom4, 4, kamien);
        }

        private void labelKamienPoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.kamień, labelKamienPoziom5, 5, kamien);
        }

        #endregion Kamien

        #region Siano

        private void labelSianoPoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.siano, labelSianoPoziom1, 1, siano);
        }

        private void labelSianoPoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.siano, labelSianoPoziom2, 2, siano);
        }

        private void labelSianoPoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.siano, labelSianoPoziom3, 3, siano);
        }

        private void labelSianoPoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.siano, labelSianoPoziom4, 4, siano);
        }

        private void labelSianoPoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.siano, labelSianoPoziom5, 5, siano);
        }

        #endregion Siano

        #region Jedzenie

        private void labelJedzeniePoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom1, 1, jedzenie);
        }

        private void labelJedzeniePoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom2, 2, jedzenie);
        }

        private void labelJedzeniePoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom3, 3, jedzenie);
        }

        private void labelJedzeniePoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom4, 4, jedzenie);
        }

        private void labelJedzeniePoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.jedzenie, labelJedzeniePoziom5, 5, jedzenie);
        }


        #endregion Jedzenie

        #region Woda

        private void labelWodaPoziom1_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.woda, labelWodaPoziom1, 1, woda);
        }

        private void labelWodaPoziom2_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.woda, labelWodaPoziom2, 2, woda);
        }

        private void labelWodaPoziom3_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.woda, labelWodaPoziom3, 3, woda);
        }

        private void labelWodaPoziom4_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.woda, labelWodaPoziom4, 4, woda);
        }

        private void labelWodaPoziom5_Click(object sender, EventArgs e)
        {
            UstawPoziomEksploatacji(o2.woda, labelWodaPoziom5, 5, woda);
        }

        #endregion Woda

        #endregion Ustawianie poziomu

        public void UstawPoziomPodatkow(Label label, int poziomPodatkow)
        {
            foreach (var item in podatki)
            {
                item.BackColor = Color.Transparent;
            }

            label.BackColor = Color.Red;
            o1.mieszkancy.poziomPodatkow = poziomPodatkow;
        }

        public void UstawPoziomEksploatacji(Materiały material,Label label, int poziomEksploatacji, List<Label> list)
        {
            if (o1.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow() >= (material.poziomUlepszenia * poziomEksploatacji) - (material.poziomUlepszenia*material.poziomEksploatacji))
            {
                foreach (var item in list)
                {
                    item.BackColor = Color.Transparent;
                }

                label.BackColor = Color.Red;

                int poziomEksploatacjiAktualnie = material.poziomEksploatacji;

                o1.mieszkancy.liczbaPracujacychMieszkancow -= poziomEksploatacjiAktualnie * material.poziomUlepszenia;

                material.poziomEksploatacji = poziomEksploatacji;

                o1.mieszkancy.liczbaPracujacychMieszkancow += poziomEksploatacji * material.poziomUlepszenia;
            }
            else
            {
                MessageBox.Show("Nie ma ludzi do pracy");
            }
           
        }

        public void SprawdzPoziomPodatkow(Label label1, Label label2, Label label3, Label label4, Label label5)
        {
            switch (o1.mieszkancy.poziomPodatkow)
            {
                case 1:
                    label1.BackColor = Color.Red;
                    break;
                case 2:
                    label2.BackColor = Color.Red;
                    break;
                case 3:
                    label3.BackColor = Color.Red;  
                    break;
                case 4:
                    label4.BackColor = Color.Red;
                    break;
                case 5:
                    label5.BackColor = Color.Red;
                    break;
            }
        }

        public void SprawdzPoziomEksploatacji(Materiały materiał, Label label1, Label label2, Label label3, Label label4, Label label5)
        {
            switch(materiał.poziomEksploatacji)
            {
                case 1:
                    label1.BackColor = Color.Red;
                    break;
                case 2:
                    label2.BackColor = Color.Red;
                    break;
                case 3:
                    label3.BackColor = Color.Red;
                    break;
                case 4:
                    label4.BackColor = Color.Red;
                    break;
                case 5:
                    label5.BackColor = Color.Red;
                    break;
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
            podatki.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelKontrolny.Text = ("bezrobotni:" + o1.mieszkancy.liczbaBezrobotnychMieszkancow + "    " + "pracujacy:" + o1.mieszkancy.liczbaPracujacychMieszkancow + " wszystkich: " + o1.mieszkancy.liczbaMieszkancow + "poziome eksp:" + o2.drewno.poziomEksploatacji).ToString();
        }
    }
}
