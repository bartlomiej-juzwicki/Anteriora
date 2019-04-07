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
        Początek o2;
      

        public Ulepszanie(Osada c1, Początek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();
            timerSprawdzaniePoziomuUlepszenia.Start();

        }

        public string UlepszanieBudynkuCzesc1(int poziomUlepszenia, Materiały material, int ilosc, Materiały material2, int ilosc2, Budowle budowle)
        {
            if(o1.progressBar2.Value == 0)
            {
                if (budowle.pictureBox.Visible == true)
                {
                    if (material.ilosc >= (ilosc * poziomUlepszenia * poziomUlepszenia) && material2.ilosc >= (ilosc2 * poziomUlepszenia * poziomUlepszenia))
                    {
                        if (poziomUlepszenia < 3)
                        {
                            material.ilosc -= ilosc;
                            material2.ilosc -= ilosc2;
                            o1.progressBar2.Location = budowle.punkt;
                            o1.progressBar2.Visible = true;
                            timerCzasUlepszenia.Start();
                            nazwaBudowli = budowle.nazwa;
                            return nazwaBudowli;
                            
                        }
                        else
                        {
                            MessageBox.Show("Maksymalny poziom ulepszenia!");
                            return "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak określonych surowców!");
                        return "";
                    }
                }
                else
                {
                    MessageBox.Show("Budynek nie jest wybudowany!");
                    return "";
                }
            }
            else
            {
                MessageBox.Show("W jednym momencie możesz ulepszać tylko jeden budynek!");
                return "";
            }
            
        }

        public void UlepszanieBudynkuCzesc2(Budowle budowle)
        {
            o1.progressBar2.Maximum = budowle.ZwrocCzasTrwaniaUlepszania(budowle.poziomUlepszenia);
            o1.progressBar2.Increment(10);
            if (o1.progressBar2.Value == budowle.ZwrocCzasTrwaniaUlepszania(budowle.poziomUlepszenia))
            {
                timerCzasUlepszenia.Stop();
                budowle.poziomUlepszenia++;                           
                o1.progressBar2.Visible = false;
                o1.progressBar2.Value = 0;
                o1.textBoxInformacja.AppendText("Ulepszono " + budowle.nazwa + " do poziomu " + budowle.poziomUlepszenia + "!");
                o1.textBoxInformacja.AppendText(Environment.NewLine);
            }
        }

        private void timerCzasUlepszenia_Tick(object sender, EventArgs e)
        {
            switch (nazwaBudowli)
            {
                case "pierwszy tartak":
                    UlepszanieBudynkuCzesc2(o1.tartak1);
                    break;
                case "drugi tartak":
                    UlepszanieBudynkuCzesc2(o1.tartak2);
                    break;
                case "pierwszy kamieniołom":
                    UlepszanieBudynkuCzesc2(o1.kamieniolom1);
                    break;
                case "drugi kamieniołom":
                    UlepszanieBudynkuCzesc2(o1.kamieniolom2);
                    break;
                case "chatka rolnika":
                    UlepszanieBudynkuCzesc2(o1.chatkaRolnika);
                    break;
                case "magazyn":
                    UlepszanieBudynkuCzesc2(o1.magazyn);
                    break;
                case "budynek mieszkalny":
                    UlepszanieBudynkuCzesc2(o1.budynekMieszkalny);
                    break;
                case "koszary":
                    UlepszanieBudynkuCzesc2(o1.koszary);
                    break;
                case "targowisko":
                    UlepszanieBudynkuCzesc2(o1.targowisko);
                    break;
                case "kuznia":
                    UlepszanieBudynkuCzesc2(o1.kuznia);
                    break;
                case "sad":
                    UlepszanieBudynkuCzesc2(o1.chataMaga);
                    break;
                case "kwatera rybacka":
                    UlepszanieBudynkuCzesc2(o1.kwateraRybacka);
                    break;
                case "most":
                    UlepszanieBudynkuCzesc2(o1.most);
                    break;
                case "mur":
                    UlepszanieBudynkuCzesc2(o1.mur);
                    break;
                case "hodowla":
                    UlepszanieBudynkuCzesc2(o1.hodowla);
                    break;
                case "studnia":
                    UlepszanieBudynkuCzesc2(o1.studnia);
                    break;
            }

        }

        private void buttonUlepszTartak_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.tartak1.poziomUlepszenia, o2.drewno, 50, o2.kamień, 50, o1.tartak1);
        }

        private void buttonUlepszTartakDrugi_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.tartak2.poziomUlepszenia, o2.drewno, 50, o2.kamień, 50, o1.tartak2);
        }

        private void buttonUlepszKamieniolomPierwszy_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.kamieniolom1.poziomUlepszenia, o2.drewno, 100, o2.kamień, 100, o1.kamieniolom1);
        }

        private void buttonUlepszKamieniolomDrugi_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.kamieniolom2.poziomUlepszenia, o2.drewno, 100, o2.kamień, 100, o1.kamieniolom2);
        }

        private void buttonUlepszKwateraRybacka_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.kwateraRybacka.poziomUlepszenia, o2.drewno, 100, o2.siano, 100, o1.kwateraRybacka);
        }

        private void buttonUlepszChatkaRolnika_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.chatkaRolnika.poziomUlepszenia, o2.drewno, 100, o2.siano, 100, o1.chatkaRolnika);
        }

        private void buttonUlepszHodowla_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.hodowla.poziomUlepszenia, o2.drewno, 100, o2.siano, 200, o1.hodowla);
        }

        private void buttonUlepszSad_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.chataMaga.poziomUlepszenia, o2.drewno, 100, o2.siano, 50, o1.chataMaga);
        }

        private void buttonUlepszStudnie_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.studnia.poziomUlepszenia, o2.kamień, 200, o2.drewno, 0, o1.studnia);
        }

        private void buttonUlepszMagazyn_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.magazyn.poziomUlepszenia, o2.drewno, 200, o2.siano, 200, o1.magazyn);
        }

        private void buttonUlepszBudynekMieszkalny_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.budynekMieszkalny.poziomUlepszenia, o2.drewno, 200, o2.siano, 300, o1.budynekMieszkalny);
        }

        private void buttonUlepszKoszary_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.koszary.poziomUlepszenia, o2.kamień, 300, o2.siano, 0, o1.koszary);
        }

        private void buttonUlepszMur_Click(object sender, EventArgs e)
        {
            UlepszanieBudynkuCzesc1(o1.mur.poziomUlepszenia, o2.drewno, 500, o2.kamień, 300, o1.mur);
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
            magazynPoziomUlepszenia.Text = o1.magazyn.poziomUlepszenia.ToString();
            budynekMieszkalnyPoziomUlepszenia.Text = o1.budynekMieszkalny.poziomUlepszenia.ToString();
            koszaryPoziomUlepszenia.Text = o1.koszary.poziomUlepszenia.ToString();
            murPoziomUlepszenia.Text = o1.mur.poziomUlepszenia.ToString();
            studniaPoziomUlepszenia.Text = o1.studnia.poziomUlepszenia.ToString();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            timerSprawdzaniePoziomuUlepszenia.Stop();
            this.Close();
        }
    }
}
