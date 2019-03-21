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
    public partial class Budowa : Form
    {      
        Osada o;
        public string nazwaBudowli;
        Początek o2;

        public Budowa(Osada c, Początek c2)
        {
            o = c;
            o2 = c2;
            InitializeComponent();
        }

        /// <summary>
        /// helpy dla nowych graczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Opis budowli
        private void buttonTartakOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja drewna (można wybudować dwa tartaki).");
        }

        private void buttonKamieniolomOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja kamienia (można wybudować dwa kamieniołomy).");
        }

        private void buttonChatkaRolnikaOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja siana.");
        }

        private void buttonHodowlaOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja jedzenia.");
        }

        private void buttonSadOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja jedzenia.");
        }

        private void buttonKwateraRybackaOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja jedzenia.");
        }

        private void buttonStudniaOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkcja wody.");
        }

        private void buttonMagazynOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skład materiałów.");
        }

        private void buttonBudynekMieszkalnyOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wzrost liczby osadników.");
        }

        private void buttonWarsztatOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ulepszanie budowli.");
        }

        private void buttonTargowiskoOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Handel materiałami.");
        }

        private void buttonKoszaryOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rekrutacja jednostek militarnych.");
        }

        private void buttonMostOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pozwala dostać się na południowo-wschodnią część mapy.");
        }

        private void buttonMurOpis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ochrona przed atakami najeźdźców.");
        }

        #endregion


        
        #region Budowanie cz.1 

        /// <summary>
        /// jeśli po kliknięciu na button budowania budynek nie jest wybudowany to wykona się metoda Budowa1 (dla tartaku i kamieniołomu ta część jest rozbudowana o możliwość wybudowania kolejnego tartaku/kamieniołomu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTartakBudowa_Click(object sender, EventArgs e)                           // wstawic odpowiednie wartosci zgodnie z zawartoscia metody
        {
            if (o.pictureBoxTartak1.Visible == false)
            {
                KosztBudowyJeden(o2.drewno, 50, o2.siano,0, o.tartak1);
               

            }
            else if (o.pictureBoxTartak1.Visible == true)
            {
                KosztBudowyJeden(o2.drewno, 50,o2.siano,0, o.tartak2);
                
            }
        }

        private void buttonKamieniolomBudowa_Click(object sender, EventArgs e)
        {
            if (o.pictureBoxKamieniolom1.Visible == false)
            {
                KosztBudowyJeden(o2.drewno, 200,o2.siano,0, o.kamieniolom1);
            }
            else if(o.pictureBoxKamieniolom1.Visible == true)
            {
                KosztBudowyJeden(o2.drewno, 200,o2.siano,0, o.kamieniolom2);
            }
        }

        private void buttonChatkaRolnikaBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 50,o2.siano,50, o.chatkaRolnika);
        }

        private void buttonHodowlaBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 100,o2.siano,100, o.hodowla);
        }

        private void buttonSadBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 50, o2.siano, 50, o.chataMaga);
        }

        private void buttonKwateraRybacka_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 50,o2.siano,50, o.kwateraRybacka);
        }

        private void buttonStudniaBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 50,o2.kamień,100, o.studnia);
        }

        private void buttonMagazynBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 100,o2.siano,100, o.magazyn);
        }

        private void buttonBudynekMieszkalnyBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 100,o2.siano,100, o.budynekMieszkalny);
        }

        private void buttonWarsztatBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 200,o2.siano,0, o.warsztat);
        }
        private void buttonTargowiskoBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 300,o2.kamień,150, o.targowisko);
        }

        private void buttonKoszaryBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 50,o2.kamień,300, o.koszary);
        }

        private void buttonMostBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 100,o2.siano,0, o.most);
        }

        private void buttonMurBudowa_Click(object sender, EventArgs e)
        {
            KosztBudowyJeden(o2.drewno, 300,o2.siano,0, o.mur);
        }
        
        #endregion



        private void timerCzasBudowy_Tick(object sender, EventArgs e)
        {
            #region Budowanie cz.2

            // po nazwie orientuje się program, który budynek powinien się pojawić
            switch (nazwaBudowli)
            {                                                                                         // to samo
                case "pierwszy tartak":
                    Budowa2(o.tartak1);
                    break;
                case "drugi tartak":
                    Budowa2(o.tartak2);
                    break;
                case "pierwszy kamieniołom":
                    Budowa2(o.kamieniolom1);
                    break;
                case "drugi kamieniołom":
                    Budowa2(o.kamieniolom2);
                    break;
                case "chatka rolnika":
                    Budowa2(o.chatkaRolnika);
                    break;
                case "magazyn":
                    Budowa2(o.magazyn);
                    break;
                case "budynek mieszkalny":
                    Budowa2(o.budynekMieszkalny);
                    break;
                case "koszary":
                    Budowa2(o.koszary);
                    break;
                case "targowisko":
                    Budowa2(o.targowisko);
                    break;
                case "warsztat":
                    Budowa2(o.warsztat);
                    break;
                case "chata maga":
                    Budowa2(o.chataMaga);
                    break;
                case "kwatera rybacka":
                    Budowa2(o.kwateraRybacka);
                    break;
                case "most":
                    Budowa2(o.most);
                    break;
                case "mur":
                    Budowa2(o.mur);
                    break;
                case "hodowla":
                    Budowa2(o.hodowla);
                    break;
                case "studnia":
                    Budowa2(o.studnia);
                    break;
            }

            #endregion

        }


        /// <summary>
        /// metoda Budowa2 określa incrementacje progressBara, jeśli wartość wyniesie wartość czasBudowy budowli to określony budynek pojawi się na mapie
        /// </summary>
        /// <param name="budowle"></param>
        /// <param name="pictureBox"></param>
        public void Budowa2(Budowle budowle)
        {
            o.progressBar.Maximum = budowle.ZwrocCzasTrwaniaBudowy(budowle.poziomUlepszenia);
            o.progressBar.Increment(5);
            if (o.progressBar.Value == budowle.ZwrocCzasTrwaniaBudowy(budowle.poziomUlepszenia))
            {
                timerCzasBudowy.Stop();
                o.progressBar.Visible = false;
                budowle.pictureBox.Visible = true;
                budowle.poziomUlepszenia = 1;
                // reset wartości progressBar
                o.progressBar.Value = 0;
                o.textBoxInformacja.AppendText("Wybudowano " + budowle.nazwa + "!");
                o.textBoxInformacja.AppendText(Environment.NewLine);
            }
        }

        private void buttonAnulujBudowa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metoda KosztBudowyJeden odpowiedzialna jest za wybudowanie budynku wraz ze sprawdzeniem czy wystarczy nam surowców(jednego) 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="ilosc"></param>
        /// <param name="pictureBox"></param>
        /// <param name="budowle"></param>
        /// <param name="point"></param>
        /// <param name="nazwa"></param>
        /// <returns></returns>
        public string KosztBudowyJeden(Materiały material,int ilosc,Materiały material2,int ilosc2,Budowle budowle)
        {
            // jesli nie jest wybudowany i mamy surowce
            if (budowle.pictureBox.Visible == false)
            {
                if(material.ilosc >= ilosc && material2.ilosc >= ilosc2)
                {
                    // gdy czas jest równy 0, czyli na początku
                    if (o.progressBar.Value == 0)
                    {
                        // start
                        timerCzasBudowy.Start();
                        // zabranie surowcow
                        material.ilosc -= ilosc;
                        material2.ilosc -= ilosc2;
                        // przejscie progressBara do określonej lokalizacji budynku
                        o.progressBar.Location = budowle.punkt;
                        // pojawienie sie go na mapie
                        o.progressBar.Visible = true;
                        // przypisanie do nazwyBudowli nazwy budowli
                        nazwaBudowli = budowle.nazwa;
                        // i "wyrzucenie" tej nazwy z metody na zewnątrz
                        return nazwaBudowli;
                    }
                    else
                    {
                        MessageBox.Show("W jednym momencie możesz budować tylko jeden obiekt!");
                    }
                }
                else
                {
                    MessageBox.Show("Brak odpowiednich surowców!");
                }
            }
            else if(budowle.pictureBox.Visible == true)
            {
                MessageBox.Show("Budynek został już wybudowany!");
            }
            
            return "";
        }

      
      
    }
}
