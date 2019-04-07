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
    public partial class Początek : Form
    {
        // nowe obiekty klasy Materiały - surowce
        public Materiały drewno = new Materiały(100);
        public Materiały siano = new Materiały(200);
        public Materiały kamień = new Materiały(100);
        public Materiały jedzenie = new Materiały(100);
        public Materiały woda = new Materiały(100);
        
        public int czasGry;
        // przydaje sie przy zapobiegnięciu spamu messageBoxami
        public int flaga;
        public Random rnd = new Random();

        public Początek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // odpalamy czas na starcie, co 1 sekunde tick
            timerCzasGry.Start();
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
           
            // zwiększamy czas gry o 1 co 1 sekunde, czas rzeczywisty gry
            czasGry++;

            // mała pomoc

            //drewno.ilosc = 5000;
            //kamień.ilosc = 5000;
            //siano.ilosc = 9000;
            // wrzucamy do label wartości surowców
            labelCzasMapa1.Text = "  Czas gry: " + czasGry + " sekund(y)";
            labelDrewno.Text = "Drewno: " + drewno.ilosc;
            labelJedzenie.Text = "Jedzenie: " + jedzenie.ilosc;
            labelSiano.Text = "Siano: " + siano.ilosc;
            labelKamien.Text = "Kamień: " + kamień.ilosc;
            labelWoda.Text = "Woda: " + woda.ilosc;

            
            Komentarz();
        }
        public void Komentarz()
        {
            //if (czasGry == 1)
            //{
            //   MessageBox.Show("Suchy ląd!");
            //}

            //if(czasGry == 5)
            //{
            //    MessageBox.Show("Widzę tam jakieś schody!");
            //}
            
        }

        /// <summary>
        /// po kliknieciu na lodke mozemy ja rozebrac i zdobyc drewno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLodkaMapa1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Już Ci nie będzie potrzebna. Czy chcesz ją rozebrać?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pictureBoxLodkaMapa1.Visible = false;
                drewno.ilosc += rnd.Next(10, 30);
            }
            
        }

        /// <summary>
        /// po kliknieciu na kraby mozemy je zaatakowac
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxKrabyMapa1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zaatakować kraby?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {                
                MessageBox.Show("Zginąłeś! Przegrywasz w ciągu " + czasGry + " sekund.");
            }
            
        }

        /// <summary>
        /// po kliknieciu na skarb mozemy po niego poplynac
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSkarb_Click(object sender, EventArgs e)
        {
            if (pictureBoxLodkaMapa1.Visible == true)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz popłynąć łódką po skarb?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    drewno.ilosc += rnd.Next(1, 10);
                    siano.ilosc += rnd.Next(1, 10);
                    kamień.ilosc += rnd.Next(1, 10);
                    pictureBoxSkarb.Visible = false;
                    MessageBox.Show("W skrzynce znalazłeś trochę materiałów!");

                }
            }
            else if (pictureBoxLodkaMapa1.Visible == false)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz popłynąć po skarb?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Zjada Cię rekin! Przegrywasz w ciągu " + czasGry + " sekund.");
                }
            }
        }

        /// <summary>
        /// po kliknieciu na schody gracz zmienia pozycje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSchodyMapa1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.poczatek2;
            pictureBoxGraczPart1.Visible = false;
            pictureBoxSchodyMapa1.Visible = false;
            pictureBoxGraczPart2.Visible = true;
            pictureBoxDrewnoKawalek1.Visible = true;
            pictureBoxDrewnoKawalek2.Visible = true;
            pictureBoxDrewnoKawalek3.Visible = true;
            pictureBoxDrewnoKawalek4.Visible = true;
            pictureBoxDrewnoKawalek5.Visible = true;
            pictureBoxJablko1.Visible = true;
            pictureBoxJablko2.Visible = true;
            pictureBoxJablko3.Visible = true;
            pictureBoxJablko4.Visible = true;
            pictureBoxJablko5.Visible = true;
            pictureBoxJablko6.Visible = true;
            pictureBoxSiano1.Visible = true;
            pictureBoxSiano2.Visible = true;
            pictureBoxSiano3.Visible = true;
            pictureBoxSiano4.Visible = true;
            pictureBoxSiano5.Visible = true;
            pictureBoxSianoX.Visible = true;

            MessageBox.Show("Tam jest jakieś urwisko!");
        }

        /// <summary>
        /// po kliknieciu na urwisko mozemy wybudowac most
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBrakMostu_Click(object sender, EventArgs e)
        {
            pictureBoxGraczPart2.Visible = false;
            pictureBoxGraczPart3.Visible = true;
            if(flaga == 0)
            {
               MessageBox.Show("Muszę zebrać drewno, aby wybudować most!");
                flaga++;
            }            
            else if (drewno.ilosc >= 50)
            {
                drewno.ilosc -= 50;
                pictureBoxMostMapa1.Visible = true;
                pictureBoxBrakMostu.Visible = false;
                MessageBox.Show("Jest lekko niestabilny, muszę uważać.");
            }
        }

        /// <summary>
        ///  po kliknieciu na wybudowany most przechodzimy przez niego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMostMapa1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.poczatek3;
            pictureBoxKloda.Visible = true;
            pictureBoxGraczPart3.Visible = false;
            pictureBoxGraczPart4.Visible = true;
            // dźwięk zawalającego się mostu
            pictureBoxMostMapa1.Visible = false;
            pictureBoxKoniecMapa1.Visible = true;

            // zablokowanie zbioru drewna, siana, jedzenia i innych pictureBox'ów po przekroczeniu mostu
            #region Brak możliwości integracji z pictureBoxami po zawaleniu się mostu

            pictureBoxJablko1.Enabled = false;
            pictureBoxJablko2.Enabled = false;
            pictureBoxJablko3.Enabled = false;
            pictureBoxJablko4.Enabled = false;
            pictureBoxJablko5.Enabled = false;
            pictureBoxJablko6.Enabled = false;

            pictureBoxDrewnoKawalek1.Enabled = false;
            pictureBoxDrewnoKawalek2.Enabled = false;
            pictureBoxDrewnoKawalek3.Enabled = false;
            pictureBoxDrewnoKawalek4.Enabled = false;
            pictureBoxDrewnoKawalek5.Enabled = false;

            pictureBoxSiano1.Enabled = false;
            pictureBoxSiano2.Enabled = false;
            pictureBoxSiano3.Enabled = false;
            pictureBoxSiano4.Enabled = false;
            pictureBoxSiano5.Enabled = false;
            pictureBoxSianoX.Enabled = false;

            pictureBoxKrabyMapa1.Enabled = false;
            pictureBoxLodkaMapa1.Enabled = false;
            pictureBoxSkarb.Enabled = false;

            #endregion


            MessageBox.Show("Ok, bardzo niestabilny.");
            MessageBox.Show("Muszę iść dalej!");
            
        }

        /// <summary>
        ///  po kliknieciu na klode klinujemy się w niej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxKlodaMapa1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zobaczyć co jest wewnątrz?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Utknąłeś. Zanim się uwolniłeś robaczki zjadły Twoje całe jedzenie!");
                jedzenie.ilosc = 0;
            }
        }

        /// <summary>
        ///  po kliknieciu na kamien widnieje napis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxKamienDuzyMapa1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na kamieniu widnieje napis:\n\n'Bartek tu był'");
        }

        /// <summary>
        /// po kliknieciu na kraniec drogi przenosimy sie do drugiej mapy/okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxKoniecMapa1_Click(object sender, EventArgs e)
        {
            timerCzasGry.Stop();
            new EkranLadowania(this,null,"load2").Show();
        }
        
        // po kliknieciu na surowiec dostajemy losową ilość surowca
        #region Zbieranie drewna

        private void pictureBoxDrewnoKawalek1_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(drewno, 20, 40, pictureBoxDrewnoKawalek1);
        }

        private void pictureBoxDrewnoKawalek2_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(drewno, 20, 40, pictureBoxDrewnoKawalek2);
        }

        private void pictureBoxDrewnoKawalek3_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(drewno, 20, 40, pictureBoxDrewnoKawalek3);
        }

        private void pictureBoxDrewnoKawalek4_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(drewno, 20, 40, pictureBoxDrewnoKawalek4);
        }

        private void pictureBoxDrewnoKawalek5_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(drewno, 20, 40, pictureBoxDrewnoKawalek5);
        }

        #endregion

        #region Zbieranie jabłek

        private void pictureBoxJablko1_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko1);
        }

        private void pictureBoxJablko2_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko2);
        }

        private void pictureBoxJablko3_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko3);
        }

        private void pictureBoxJablko4_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko4);

        }

        private void pictureBoxJablko5_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko5);
        }

        private void pictureBoxJablko6_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(jedzenie, 1, 3, pictureBoxJablko6);
        }


        #endregion

        #region Zbieranie siana

        private void pictureBoxSiano1_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSiano1);
        }

        private void pictureBoxSiano2_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSiano2);
        }

        private void pictureBoxSiano3_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSiano3);
        }

        private void pictureBoxSiano4_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSiano4);
        }

        private void pictureBoxSiano5_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSiano5);
        }

        private void pictureBoxSianoX_Click(object sender, EventArgs e)
        {
            ZbierzMaterial(siano, 20, 40, pictureBoxSianoX);
            MessageBox.Show("Wąż czający się w zbożu zjadł całe Twoje jedzenie!");
            jedzenie.ilosc = 0;
        }

        #endregion

        public void ZbierzMaterial(Materiały material, int ilosc1, int ilosc2, PictureBox picturebox)
        {
            material.ilosc += rnd.Next(ilosc1, ilosc2);
            picturebox.Visible = false;
        }


    }
}
