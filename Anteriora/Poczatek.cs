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
    public partial class Poczatek : Form
    {
        // nowe obiekty klasy Materiały - surowce

        public Mieszkancy mieszkancy = new Mieszkancy();
        
        public Materialy drewno = new Materialy(1000);
        public Materialy siano = new Materialy(2000);
        public Materialy kamień = new Materialy(1000);
        public Materialy jedzenie = new Materialy(1000);
        public Materialy woda = new Materialy(1000);
        public Materialy skora = new Materialy(0);
        public Materialy zloto = new Materialy(100);
        public Materialy rudaZelaza = new Materialy(100);
        public Materialy rudaObsydianu = new Materialy(100);
        public Materialy welna = new Materialy(24);
        public Materialy zelazo = new Materialy(24);
        public Materialy obsydian = new Materialy(24);
        public Materialy skorzanyPasek = new Materialy(24);
        public Materialy kawalekDrewna = new Materialy(24);

        public Uzbrojenie skorzanaZbroja = new Uzbrojenie("Skórzana Zbroja", 8, 0, 0, "1X1111111", Properties.Resources.skorzana_zbroja);
        public Uzbrojenie skorzaneSpodnie = new Uzbrojenie("Skórzane Spodnie", 7, 0, 0, "1111X11X1", Properties.Resources.skorzane_spodnie);
        public Uzbrojenie skorzanyHelm = new Uzbrojenie("Skórzany Hełm", 5, 0, 0, "1111X1XXX", "XXX1111X1", Properties.Resources.skorzany_helm);
        public Uzbrojenie skorzaneButy = new Uzbrojenie("Skórzane Buty", 4, 0, 0,"XXX1X11X1", "1X11X1XXX", Properties.Resources.skorzane_buty);
        public Uzbrojenie zelaznaZbroja = new Uzbrojenie("Żelazna Zbroja", 0, 8, 0, "4X4444444", Properties.Resources.zelazna_zbroja);
        public Uzbrojenie zelazneSpodnie = new Uzbrojenie("Żelazne Spodnie", 0, 7, 0, "4444X44X4", Properties.Resources.zelazne_spodnie);
        public Uzbrojenie zelaznyHelm = new Uzbrojenie("Żelazny Hełm", 0, 5, 0, "4444X4XXX", "XXX4444X4", Properties.Resources.zelazny_helm);
        public Uzbrojenie zelazneButy = new Uzbrojenie("Żelazne Buty", 0, 4, 0, "XXX4X44X4", "4X44X4XXX", Properties.Resources.zelazne_buty);
        public Uzbrojenie obsydianowaZbroja = new Uzbrojenie("Obsydianowa Zbroja", 0, 0, 8, "5X5555555", Properties.Resources.obsydianowa_zbroja);
        public Uzbrojenie obsydianoweSpodnie = new Uzbrojenie("Obsydianowe Spodnie", 0, 0, 7, "5555X55X5", Properties.Resources.obsydianowe_spodnie);
        public Uzbrojenie obsydianowyHelm = new Uzbrojenie("Obsydianowy Helm", 0, 0, 5, "5555X5XXX", "XXX5555X5", Properties.Resources.obsydianowy_helm);
        public Uzbrojenie obsydianoweButy = new Uzbrojenie("Obsydianowe Buty", 0, 0, 4, "XXX5X55X5", "5X55X5XXX", Properties.Resources.obsydianowe_buty);
        public Uzbrojenie zelaznaTarcza = new Uzbrojenie("Żelazna tarcza", "434343434", Properties.Resources.zelazna_tarcza);
        public Uzbrojenie obsydianowaTarcza = new Uzbrojenie("Obsydianowa tarcza", "535353535", Properties.Resources.obsydianowa_tarcza);

        public Bronie kamiennyMiecz = new Bronie("Kamienny Miecz", 1, 2, 0, 0, "2XX2XX0XX", "X2XX2XX0X", "XX2XX2XX0", Properties.Resources.kamienny_miecz);                // kawalekDrewna 0, skora 1, kamien 2, drewno 3, zelazo 4, obsydian 5
        public Bronie zelaznyMiecz = new Bronie("Żelazny Miecz", 1, 0, 2, 0, "4XX4XX0XX", "X4XX4XX0X", "XX4XX4XX0", Properties.Resources.zelazny_miecz);                   // rudaZelaza 6, rudaObsydianu 7, welna 8, skorzanyPasek 9
        public Bronie obsydianowyMiecz = new Bronie("Obsydianowy Miecz", 1, 0, 0, 2, "5XX5XX0XX", "X5XX5XX0X", "XX5XX5XX0", Properties.Resources.obsydianowy_miecz);
        public Bronie luk = new Bronie("Łuk", 3, 3, "09X0X909X","X909X0X90",Properties.Resources.luk);

        public Inne ubraniaMieszkancow = new Inne("Ubrania mieszkańców", "888888888", Properties.Resources.ubrania_mieszkanców, 9);
        public Inne lozko = new Inne("Łóżko", "888999333", Properties.Resources.łóżko, 3);

        public JednostkiGracza zwiadowca = new JednostkiGracza();
        public JednostkiGracza piechur = new JednostkiGracza("Piechur", 10, 10, 100, 0, 100, true, Properties.Resources.wojownikprawo, Properties.Resources.wojowniklewo, Properties.Resources.wojownikgora, Properties.Resources.wojownikdol);
        public JednostkiGracza lucznik = new JednostkiGracza("Łucznik", 20, 5, 50, 0, 300, false, Properties.Resources.lucznikprawo, Properties.Resources.luczniklewo, Properties.Resources.lucznikgora, Properties.Resources.lucznikdol);
        public JednostkiGracza rycerz = new JednostkiGracza("Rycerz", 40, 20, 200, 0, 100, true, Properties.Resources.rycerzprawo, Properties.Resources.rycerzlewo, Properties.Resources.rycerzgora, Properties.Resources.rycerzdol);
        public JednostkiGracza czarnyRycerz = new JednostkiGracza("Czarny rycerz", 10, 10, 100, 0, 100, true, Properties.Resources.czarnyrycerzprawo, Properties.Resources.czarnyrycerzlewo, Properties.Resources.czarnyrycerzgora, Properties.Resources.czarnyrycerzdol);
        public JednostkiGracza czarnyLucznik = new JednostkiGracza("Czarny łucznik", 20, 5, 50, 0, 300, false, Properties.Resources.czarnylucznikprawo, Properties.Resources.czarnyluczniklewo, Properties.Resources.czarnylucznikgora, Properties.Resources.czarnylucznikdol);

        public Budowle magazyn = new Budowle("magazyn", 1);

        // przydaje sie przy zapobiegnięciu spamu messageBoxami
        public int flaga;
        public Random rnd = new Random();

        public Poczatek()
        {
            InitializeComponent();

            new Panel(this).Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // odpalamy czas na starcie, co 1 sekunde tick
            timerCzasGry.Start();
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
           
            //drewno.ilosc = 5000;
            //kamień.ilosc = 5000;
            //siano.ilosc = 9000;
            // wrzucamy do label wartości surowców
            
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

            

            //DialogResult dialogResult = MessageBox.Show("Czy chcesz zaatakować kraby?", "", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{                
            //    MessageBox.Show("Zginąłeś! Przegrywasz w ciągu " + czasGry + " sekund.");
            //}


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
                    MessageBox.Show("Zjada Cię rekin!");
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

        public void ZbierzMaterial(Materialy material, int ilosc1, int ilosc2, PictureBox picturebox)
        {
            material.ilosc += rnd.Next(ilosc1, ilosc2);
            picturebox.Visible = false;
        }
    }
}
