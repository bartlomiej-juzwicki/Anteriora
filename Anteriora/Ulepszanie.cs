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
    public partial class Ulepszanie : Form
    {
        Osada o1;
        public string nazwaBudowli;
        Poczatek o2;
      

        public Ulepszanie(Osada c1, Poczatek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();
            timerSprawdzaniePoziomuUlepszenia.Start();

        }
      
        private void buttonUlepszTartak_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 50, o2.kamień, 50, o1.tartak1);
        }

        private void buttonUlepszTartakDrugi_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 50, o2.kamień, 50, o1.tartak2);
        }

        private void buttonUlepszKamieniolomPierwszy_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.kamień, 100, o1.kamieniolom1);
        }

        private void buttonUlepszKamieniolomDrugi_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.kamień, 100, o1.kamieniolom2);
        }

        private void buttonUlepszKwateraRybacka_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.siano, 100, o1.kwateraRybacka);
        }

        private void buttonUlepszChatkaRolnika_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.siano, 100, o1.chatkaRolnika);
        }

        private void buttonUlepszHodowla_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.siano, 200, o1.hodowla);
        }

        private void buttonUlepszSad_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 100, o2.siano, 50, o1.chataMaga);
        }

        private void buttonUlepszStudnie_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.kamień, 200, o2.drewno, 0, o1.studnia);
        }

        private void buttonUlepszMagazyn_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 200, o2.siano, 200, o2.magazyn);
        }

        private void buttonUlepszBudynekMieszkalny_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 200, o2.siano, 300, o1.budynekMieszkalny);
        }

        private void buttonUlepszKoszary_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.kamień, 300, o2.siano, 0, o1.koszary);
        }

        private void buttonUlepszMur_Click(object sender, EventArgs e)
        {
            o1.UlepszanieBudynkuOsada1(o2.drewno, 500, o2.kamień, 300, o1.mur);
        }

        private void timerSprawdzaniePoziomuUlepszenia_Tick(object sender, EventArgs e)
        {
            tartak1PoziomUlepszenia.Text = o1.tartak1.poziomUlepszenia.ToString();
            tartak2PoziomUlepszenia.Text = o1.tartak2.poziomUlepszenia.ToString();
            kamieniolom1PoziomUlepszenia.Text = o1.kamieniolom1.poziomUlepszenia.ToString();
            kamieniolom2PoziomUlepszenia.Text = o1.kamieniolom2.poziomUlepszenia.ToString();
            chatkaRolnikaPoziomUlepszenia.Text = o1.chatkaRolnika.poziomUlepszenia.ToString();
            kwateraRybackaPoziomUlepszenia.Text = o1.kwateraRybacka.poziomUlepszenia.ToString();
            hodowlaPoziomUlepszenia.Text = o1.hodowla.poziomUlepszenia.ToString();
            sadPoziomUlepszenia.Text = o1.chataMaga.poziomUlepszenia.ToString();
            magazynPoziomUlepszenia.Text = o2.magazyn.poziomUlepszenia.ToString();
            budynekMieszkalnyPoziomUlepszenia.Text = o1.budynekMieszkalny.poziomUlepszenia.ToString();
            koszaryPoziomUlepszenia.Text = o1.koszary.poziomUlepszenia.ToString();
            murPoziomUlepszenia.Text = o1.mur.poziomUlepszenia.ToString();
            studniaPoziomUlepszenia.Text = o1.studnia.poziomUlepszenia.ToString();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
