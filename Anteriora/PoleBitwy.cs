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
    public partial class PoleBitwy : Form
    {
        Poczatek o1;

        Instancje instancje;

        Przeciwnicy przeciwnik0;
        Przeciwnicy przeciwnik1;
        Przeciwnicy przeciwnik2;
        Przeciwnicy przeciwnik3;
        Przeciwnicy przeciwnik4;
        Przeciwnicy przeciwnik5;
        Przeciwnicy przeciwnik6;
        ObszaryInstancji obszaryInstancji;
           
        List<Button> buttonsLista = new List<Button>();

        List<JednostkiGracza> jednostkiGraczaLista = new List<JednostkiGracza>();
        List<Label> nazwaJednostkiGraczaLista = new List<Label>();
        List<Label> iloscPZJednostkiGraczaLista = new List<Label>();
        List<Label> liczebnoscJednostkiGraczaLista = new List<Label>();
        List<Label> atakJednostkiGraczaLista = new List<Label>();
        List<Label> obronaJednostkiGraczaLista = new List<Label>();
        List<ProgressBar> progressBarPZGraczaLista = new List<ProgressBar>();
        List<PictureBox> pictureBoxJednostekGraczaLista = new List<PictureBox>();
         
        List<Przeciwnicy> przeciwnicyLista = new List<Przeciwnicy>();
        List<Label> nazwaPrzeciwnicyLista = new List<Label>();
        List<Label> iloscPZPrzeciwnikaLista = new List<Label>();
        List<Label> liczebnoscPrzeciwnikaLista = new List<Label>();
        List<Label> atakPrzeciwnikaLista = new List<Label>();
        List<Label> obronaPrzeciwnikaLista = new List<Label>();
        List<ProgressBar> progressBarPZPrzeciwnikaLista = new List<ProgressBar>();

        private bool czyRundaGracza = true;
        private int rundaGracza;
        private int rundaPrzeciwnika;
        private int ktoryPrzeciwnikMaZostacZaatakowany;
        private int numerRundyJednostki;
        private int numerRundyPrzeciwnika;

        public PoleBitwy(Poczatek c1, Instancje instancja, ObszaryInstancji obszarInstancji, Bitmap obrazek)
        {
            o1 = c1;

            instancje = instancja;
            obszaryInstancji = obszarInstancji;

            przeciwnik0 = obszaryInstancji.przeciwnik0;
            przeciwnik1 = obszaryInstancji.przeciwnik1;
            przeciwnik2 = obszaryInstancji.przeciwnik2;
            przeciwnik3 = obszaryInstancji.przeciwnik3;
            przeciwnik4 = obszaryInstancji.przeciwnik4;
            przeciwnik5 = obszaryInstancji.przeciwnik5;
            przeciwnik6 = obszaryInstancji.przeciwnik6;

            InitializeComponent();

            this.BackgroundImage = obrazek;

            nazwaJednostkiGraczaLista.AddRange(new Label[] { labelNazwaJednostkiGracza0, labelNazwaJednostkiGracza1, labelNazwaJednostkiGracza2, labelNazwaJednostkiGracza3, labelNazwaJednostkiGracza4 });
            iloscPZJednostkiGraczaLista.AddRange(new Label[] { labelJednostkaGracza0PZ, labelJednostkaGracza1PZ, labelJednostkaGracza2PZ, labelJednostkaGracza3PZ, labelJednostkaGracza4PZ });
            liczebnoscJednostkiGraczaLista.AddRange(new Label[] { labelLiczebnoscJednostkiGracza0, labelLiczebnoscJednostkiGracza1, labelLiczebnoscJednostkiGracza2, labelLiczebnoscJednostkiGracza3, labelLiczebnoscJednostkiGracza4 });
            atakJednostkiGraczaLista.AddRange(new Label[] { labelAtakJednostkiGracza0, labelAtakJednostkiGracza1, labelAtakJednostkiGracza2, labelAtakJednostkiGracza3, labelAtakJednostkiGracza4 });
            obronaJednostkiGraczaLista.AddRange(new Label[] { labelObronaJednostkiGracza0, labelObronaJednostkiGracza1, labelObronaJednostkiGracza2, labelObronaJednostkiGracza3, labelObronaJednostkiGracza4 });
            progressBarPZGraczaLista.AddRange(new ProgressBar[] { progressBarJednostka0, progressBarJednostka1, progressBarJednostka2, progressBarJednostka3, progressBarJednostka4 });

            nazwaPrzeciwnicyLista.AddRange(new Label[] { labelNazwaPrzeciwnika0, labelNazwaPrzeciwnika1, labelNazwaPrzeciwnika2, labelNazwaPrzeciwnika3, labelNazwaPrzeciwnika4, labelNazwaPrzeciwnika5, labelNazwaPrzeciwnika6 });
            iloscPZPrzeciwnikaLista.AddRange(new Label[] {labelPrzeciwnika0PZ,labelPrzeciwnika1PZ,labelPrzeciwnika2PZ,labelPrzeciwnika3PZ,labelPrzeciwnika4PZ,labelPrzeciwnika5PZ,labelPrzeciwnika6PZ });
            liczebnoscPrzeciwnikaLista.AddRange(new Label[] { labelLiczebnoscPrzeciwnika0, labelLiczebnoscPrzeciwnika1, labelLiczebnoscPrzeciwnika2, labelLiczebnoscPrzeciwnika3, labelLiczebnoscPrzeciwnika4, labelLiczebnoscPrzeciwnika5, labelLiczebnoscPrzeciwnika6 });
            atakPrzeciwnikaLista.AddRange(new Label[] { labelAtakPrzeciwnika0, labelAtakPrzeciwnika1, labelAtakPrzeciwnika2, labelAtakPrzeciwnika3, labelAtakPrzeciwnika4, labelAtakPrzeciwnika5,labelAtakPrzeciwnika6 });
            obronaPrzeciwnikaLista.AddRange(new Label[] { labelObronaPrzeciwnika0, labelObronaPrzeciwnika1, labelObronaPrzeciwnika2, labelObronaPrzeciwnika3, labelObronaPrzeciwnika4, labelObronaPrzeciwnika5, labelObronaPrzeciwnika6 });
            progressBarPZPrzeciwnikaLista.AddRange(new ProgressBar[] { progressBarPrzeciwnik0, progressBarPrzeciwnik1, progressBarPrzeciwnik2, progressBarPrzeciwnik3, progressBarPrzeciwnik4, progressBarPrzeciwnik5, progressBarPrzeciwnik6 });

            #region dodanie buttonow do listy

            buttonsLista.AddRange(new Button[]{ buttonA1, buttonA2, buttonA3, buttonA4, buttonA5, buttonA6, buttonA7, buttonA8, buttonA9, buttonA10, buttonA11, buttonA12, buttonA13, buttonA14, buttonA15, buttonB1, buttonB2, buttonB3,
                             buttonB4, buttonB5, buttonB6, buttonB7, buttonB8, buttonB9, buttonB10, buttonB11, buttonB12, buttonB13, buttonB14, buttonB15, buttonC1, buttonC2, buttonC3, buttonC4, buttonC5, buttonC6,
                             buttonC7, buttonC8, buttonC9, buttonC10, buttonC11, buttonC12, buttonC13, buttonC14, buttonC15, buttonD1, buttonD2, buttonD3, buttonD4, buttonD5, buttonD6, buttonD7, buttonD8, buttonD9,
                             buttonD10, buttonD11, buttonD12, buttonD13, buttonD14, buttonD15, buttonE1, buttonE2, buttonE3, buttonE4, buttonE5, buttonE6, buttonE7, buttonE8, buttonE9, buttonE10, buttonE11,
                             buttonE12, buttonE13, buttonE14, buttonE15, buttonF1, buttonF2, buttonF3, buttonF4, buttonF5, buttonF6, buttonF7, buttonF8, buttonF9, buttonF10, buttonF11, buttonF12, buttonF13,
                             buttonF14, buttonF15, buttonG1, buttonG2, buttonG3, buttonG4, buttonG5, buttonG6, buttonG7, buttonG8, buttonG9, buttonG10, buttonG11, buttonG12, buttonG13, buttonG14, buttonG15});

            #endregion dodanie buttonow do listy buttons

            o1.piechur.pictureBox = pictureBoxPiechur;
            o1.lucznik.pictureBox = pictureBoxLucznik;
            o1.rycerz.pictureBox = pictureBoxWlocznik;
            o1.czarnyRycerz.pictureBox = pictureBoxCzarnyRycerz;
            o1.czarnyLucznik.pictureBox = pictureBoxCzarnyLucznik;

            DodajJednostkiGraczaDoListyOrazOkreslIloscJednostek();

            DodajJednostkiPrzeciwnikaDoListyOrazOkreslIloscJednostekPrzeciwnika();

            timerGra.Start();
        }

        #region Pola, po których poruszają się jednostki

        private void ButtonA1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA1);
        }

        private void ButtonA2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA2);
        }

        private void ButtonA3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA3);
        }

        private void ButtonA4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA4);
        }

        private void ButtonA5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA5);
        }

        private void ButtonA6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA6);
        }

        private void ButtonA7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA7);
        }

        private void ButtonA8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA8);
        }

        private void ButtonA9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA9);
        }

        private void ButtonA10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA10);
        }

        private void ButtonA11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA11);
        }

        private void ButtonA12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA12);
        }

        private void ButtonA13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA13);
        }

        private void ButtonA14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA14);
        }

        private void ButtonA15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonA15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonB1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB1);
        }

        private void ButtonB2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB2);
        }

        private void ButtonB3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB3);
        }

        private void ButtonB4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB4);
        }

        private void ButtonB5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB5);
        }

        private void ButtonB6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB6);
        }

        private void ButtonB7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB7);
        }

        private void ButtonB8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB8);
        }

        private void ButtonB9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB9);
        }

        private void ButtonB10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB10);
        }

        private void ButtonB11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB11);
        }

        private void ButtonB12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB12);
        }

        private void ButtonB13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB13);
        }

        private void ButtonB14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB14);
        }

        private void ButtonB15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonB15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonC1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC1);
        }

        private void ButtonC2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC2);
        }

        private void ButtonC3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC3);
        }

        private void ButtonC4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC4);
        }

        private void ButtonC5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC5);
        }

        private void ButtonC6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC6);
        }

        private void ButtonC7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC7);
        }

        private void ButtonC8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC8);
        }

        private void ButtonC9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC9);
        }

        private void ButtonC10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC10);
        }

        private void ButtonC11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC11);
        }

        private void ButtonC12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC12);
        }

        private void ButtonC13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC13);
        }

        private void ButtonC14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC14);
        }

        private void ButtonC15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonC15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonD1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD1);
        }

        private void ButtonD2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD2);
        }

        private void ButtonD3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD3);
        }

        private void ButtonD4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD4);
        }

        private void ButtonD5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD5);
        }

        private void ButtonD6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD6);
        }

        private void ButtonD7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD7);
        }

        private void ButtonD8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD8);
        }

        private void ButtonD9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD9);
        }

        private void ButtonD10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD10);
        }

        private void ButtonD11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD11);
        }

        private void ButtonD12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD12);
        }

        private void ButtonD13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD13);
        }

        private void ButtonD14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD14);
        }

        private void ButtonD15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonD15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonE1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE1);
        }

        private void ButtonE2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE2);
        }

        private void ButtonE3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE3);
        }

        private void ButtonE4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE4);
        }

        private void ButtonE5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE5);
        }

        private void ButtonE6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE6);
        }

        private void ButtonE7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE7);
        }

        private void ButtonE8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE8);
        }

        private void ButtonE9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE9);
        }

        private void ButtonE10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE10);
        }

        private void ButtonE11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE11);
        }

        private void ButtonE12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE12);
        }

        private void ButtonE13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE13);
        }

        private void ButtonE14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE14);
        }

        private void ButtonE15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonE15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonF1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF1);
        }
                
        private void ButtonF2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF2);
        }

        private void ButtonF3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF3);
        }

        private void ButtonF4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF4);
        }

        private void ButtonF5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF5);
        }

        private void ButtonF6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF6);
        }

        private void ButtonF7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF7);
        }

        private void ButtonF8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF8);
        }

        private void ButtonF9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF9);
        }

        private void ButtonF10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF10);
        }

        private void ButtonF11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF11);
        }

        private void ButtonF12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF12);
        }

        private void ButtonF13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF13);
        }

        private void ButtonF14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF14);
        }

        private void ButtonF15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonF15);
        }

        //-----------------------------------------------------------------------------------

        private void ButtonG1_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG1);
        }

        private void ButtonG2_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG2);
        }

        private void ButtonG3_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG3);
        }

        private void ButtonG4_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG4);
        }

        private void ButtonG5_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG5);
        }

        private void ButtonG6_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG6);
        }

        private void ButtonG7_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG7);
        }

        private void ButtonG8_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG8);
        }

        private void ButtonG9_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG9);
        }

        private void ButtonG10_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG10);
        }

        private void ButtonG11_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG11);
        }

        private void ButtonG12_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG12);
        }

        private void ButtonG13_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG13);
        }

        private void ButtonG14_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG14);
        }

        private void ButtonG15_Click(object sender, EventArgs e)
        {
            RuchJednostek(buttonG15);
        }

        #endregion pola, po których poruszają się jednostki

        #region Ruch jednostek po planszy

        public void RuchJednostek(Button button)
        {
            if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= button.Location.X - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= button.Location.X && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == button.Location.Y)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekPrawo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;                
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= button.Location.X + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= button.Location.X && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == button.Location.Y)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekLewo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekDol;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekGora;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X - 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekPrawo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X + 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekLewo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X - 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekPrawo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= button.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= button.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == button.Location.X + 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekLewo;
                jednostkiGraczaLista[rundaGracza].pictureBox.Location = button.Location;
                rundaGracza++;
                czyRundaGracza = false;
            }
            else
            {
                Cursor.Current = Cursors.No;
                
            }

            if (rundaGracza == jednostkiGraczaLista.Count)
            {
                rundaGracza = 0;
            }
        }

        #endregion Ruch jednostek po planszy

        #region Dodaj jednostki gracza do listy oraz okresl ilosc jednostek gracza

        public void DodajJednostkiGraczaDoListyOrazOkreslIloscJednostek()
        {
            if (o1.piechur.liczebnoscAtakujacych>0)
            {
                jednostkiGraczaLista.Add(o1.piechur);
                UstawAtrybutyJednostkiGracza();
                numerRundyJednostki++;
            }          

            if(o1.rycerz.liczebnoscAtakujacych > 0)
            {
                jednostkiGraczaLista.Add(o1.rycerz);
                UstawAtrybutyJednostkiGracza();
                numerRundyJednostki++;
            }

            if(o1.czarnyRycerz.liczebnoscAtakujacych > 0)
            {
                jednostkiGraczaLista.Add(o1.czarnyRycerz);
                UstawAtrybutyJednostkiGracza();
                numerRundyJednostki++;
            }

            if (o1.lucznik.liczebnoscAtakujacych > 0)
            {
                jednostkiGraczaLista.Add(o1.lucznik);
                UstawAtrybutyJednostkiGracza();
                numerRundyJednostki++;
            }

            if (o1.czarnyLucznik.liczebnoscAtakujacych > 0)
            {
                jednostkiGraczaLista.Add(o1.czarnyLucznik);
                UstawAtrybutyJednostkiGracza();
                numerRundyJednostki++;
            }
        }

        #endregion Dodaj jednostki gracza do listy oraz okresl ilosc jednostek gracza

        #region Dodaj jednostki przeciwnika do listy oraz okresl ilosc jednostek wroga

        public void DodajJednostkiPrzeciwnikaDoListyOrazOkreslIloscJednostekPrzeciwnika()
        {
            if(przeciwnik0.liczebnoscAtakujacych > 0)
            {
                przeciwnik0.pictureBox = pictureBoxPrzeciwnik0;
                przeciwnicyLista.Add(przeciwnik0);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik1.liczebnoscAtakujacych > 0)
            {
                przeciwnik1.pictureBox = pictureBoxPrzeciwnik1;
                przeciwnicyLista.Add(przeciwnik1);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik2.liczebnoscAtakujacych > 0)
            {
                przeciwnik2.pictureBox = pictureBoxPrzeciwnik2;
                przeciwnicyLista.Add(przeciwnik2);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik3.liczebnoscAtakujacych > 0)
            {
                przeciwnik3.pictureBox = pictureBoxPrzeciwnik3;
                przeciwnicyLista.Add(przeciwnik3);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik4.liczebnoscAtakujacych > 0)
            {
                przeciwnik4.pictureBox = pictureBoxPrzeciwnik4;
                przeciwnicyLista.Add(przeciwnik4);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik5.liczebnoscAtakujacych > 0)
            {
                przeciwnik5.pictureBox = pictureBoxPrzeciwnik5;
                przeciwnicyLista.Add(przeciwnik5);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

            if (przeciwnik6.liczebnoscAtakujacych > 0)
            {
                przeciwnik6.pictureBox = pictureBoxPrzeciwnik6;
                przeciwnicyLista.Add(przeciwnik6);
                UstawAtrybutyPrzeciwnika();
                numerRundyPrzeciwnika++;
            }

        }

        #endregion Dodaj jednostki wroga do listy oraz okresl ilosc jednostek wroga

        #region Sprawdz zasieg ruchu jednostki

        public void SprawdzZasiegRuchuJednostek()
        {
            if(czyRundaGracza == true && jednostkiGraczaLista.Count > 0)
            {
                foreach (var item in buttonsLista)
                {
                    if ((jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= (item.Location.X - 100) && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == item.Location.Y)
                        && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= (item.Location.X + 100) && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == item.Location.Y)
                        || (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= (item.Location.Y - 100) && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= item.Location.X - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= item.Location.X + 100))  // || jednostka.pictureBox.Location.X == item.Location.X))
                        && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= (item.Location.Y + 100) && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= item.Location.X - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= item.Location.X + 100)))
                    {
                        item.Image = Properties.Resources.iks;
                    }
                    else
                    {
                        item.Image = null;
                    }
                }
            }
            else
            {
                foreach (var item in buttonsLista)
                {
                    item.Image = null;
                }
            }
        }

        #endregion Sprawdz zasieg ruchu jednostki

        #region Mechanika przeciwników

        public void MechanikaPrzeciwnik()
        {
           if(czyRundaGracza == false && przeciwnicyLista.Count > 0)
            {
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X + 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X - 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y + 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekGora;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y - 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekDol;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y + 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X + 100)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekGora;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y + 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X - 100)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekGora;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y - 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X + 100)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekDol;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y - 100 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X - 100)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekDol;
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostceGracza(item);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X >= item.pictureBox.Location.X && 
                        przeciwnicyLista.Count(x=>x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X <= item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y < item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekDol;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y > item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X == item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekGora;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y < item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X > item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y > item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X > item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                        goto Koniec;
                    }
                }

                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y < item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                        goto Koniec;
                    }
                }

                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y > item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                        goto Koniec;
                    }
                }
                foreach(var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 1 &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 1 &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y) == 1 &&
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y >= 200)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y -100);
                        goto Koniec;
                    }
                }
                foreach (var item in jednostkiGraczaLista)
                {
                    if (przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y == item.pictureBox.Location.Y && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X < item.pictureBox.Location.X &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 1 &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 1 &&
                        przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X + 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y) == 1 &&
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y <= 600)
                    {
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekPrawo;
                        przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                        goto Koniec;
                    }
                }

                // pozwolmy jednak jednostka sie ruszac w przypadu niespelnionych powyzszych warunkow - dopisze kiedy indziej warunki wyzej tak aby dzialalo w kazdej sytuacji bez tych warunkow ponizej

                if (przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y) == 0
                    && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X >= 310)
                {
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y);
                }
                else if (przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0
                         && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y >= 200)
                {
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekGora;
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                }
                else if (przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0
                       && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y <= 600)
                {
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekDol;
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                }
                else if (przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100) == 0
                        && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X >= 310 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y >= 200)
                {
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y - 100);
                }
                else if (przeciwnicyLista.Count(x => x.pictureBox.Location.X == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100 && x.pictureBox.Location.Y == przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100) == 0
                        && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X >= 310 && przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y <= 600)
                {
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Image = przeciwnicyLista[rundaPrzeciwnika].obrazekLewo;
                    przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location = new Point(przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.X - 100, przeciwnicyLista[rundaPrzeciwnika].pictureBox.Location.Y + 100);
                }

            Koniec:

                rundaPrzeciwnika++;
                czyRundaGracza = true;

                if (rundaPrzeciwnika >= przeciwnicyLista.Count)
                {
                    rundaPrzeciwnika = 0;
                }
            }
        }

        #endregion

        #region Zadaj obrazenia przeciwnikowi

        public void ZadajObrazeniaPrzeciwnikowi()
        {
            var przeciwnik = przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany];

            if (jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak() >= przeciwnik.calkowitePZ)
            {
                przeciwnik.pictureBox.Visible = false;
                przeciwnik.liczebnoscAtakujacych = 0;
                przeciwnik.PZ = 0;
                przeciwnik.calkowitePZ = 0;
                przeciwnik.progressBarPZ.ForeColor = Color.Black;
                przeciwnik.progressBarPZ.Value = przeciwnik.progressBarPZ.Maximum;
                przeciwnik.labelIlosc.Text = "0";
                przeciwnik.labelPZ.Text = "0";
                przeciwnicyLista.Remove(przeciwnik);

                if (rundaPrzeciwnika >= przeciwnicyLista.Count)
                {
                    rundaPrzeciwnika = 0;
                }
            }
            else
            {
                if (jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak() == przeciwnik.PZ)
                {
                    if (przeciwnik.liczebnoscAtakujacych == 1)
                    {
                        przeciwnik.liczebnoscAtakujacych--;
                        przeciwnik.pictureBox.Visible = false;
                        przeciwnik.PZ = 0;
                        przeciwnik.calkowitePZ = 0;
                        przeciwnik.progressBarPZ.ForeColor = Color.Black;
                        przeciwnik.progressBarPZ.Value = przeciwnik.progressBarPZ.Maximum;
                        przeciwnik.labelIlosc.Text = "0";
                        przeciwnik.labelPZ.Text = "0";
                        przeciwnicyLista.Remove(przeciwnik);

                        if (rundaPrzeciwnika >= przeciwnicyLista.Count)
                        {
                            rundaPrzeciwnika = 0;
                        }
                    }
                    else
                    {
                        przeciwnik.liczebnoscAtakujacych--;
                        przeciwnik.PZ = przeciwnik.stalePZ;
                        przeciwnik.calkowitePZ -= jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak();
                    }
                }
                else if (jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak() > przeciwnik.PZ)
                {
                    if (przeciwnik.liczebnoscAtakujacych == 1)
                    {
                        przeciwnik.liczebnoscAtakujacych--;
                        przeciwnik.pictureBox.Visible = false;
                        przeciwnik.PZ = 0;
                        przeciwnik.calkowitePZ = 0;
                        przeciwnik.progressBarPZ.ForeColor = Color.Black;
                        przeciwnik.progressBarPZ.Value = przeciwnik.progressBarPZ.Maximum;
                        przeciwnik.labelIlosc.Text = "0";
                        przeciwnik.labelPZ.Text = "0";
                        przeciwnicyLista.Remove(przeciwnik);

                        if (rundaPrzeciwnika >= przeciwnicyLista.Count)
                        {
                            rundaPrzeciwnika = 0;
                        }

                    }
                    else
                    {
                        int resztaPZ;
                        przeciwnik.calkowitePZ -= jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak();
                        przeciwnik.PZ -= jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak();

                        //for (int i = 0; i < jednostkiGracza[rundaGracza].ObliczCalkowityAtak(); i++)
                        //{
                        //    if (przeciwnicy.PZ <= 0)
                        //    {
                        //        resztaPZ = przeciwnicy.PZ;
                        //        przeciwnicy.PZ = przeciwnicy.stalePZ + resztaPZ;
                        //    }
                        //    else if (przeciwnicy.PZ > 0)
                        //    {
                        //        przeciwnicy.liczebnoscAtakujacych -= i;
                        //        break;
                        //    }
                        //}

                        while(przeciwnik.PZ <= 0)
                        {
                            int iloscZabitychPrzeciwnikow = 0;

                            if (przeciwnik.PZ <= 0)
                            {
                                resztaPZ = przeciwnik.PZ;
                                przeciwnik.PZ = przeciwnik.stalePZ + resztaPZ;
                                iloscZabitychPrzeciwnikow++;
                            }

                            if (przeciwnik.PZ > 0)
                            {
                                przeciwnik.liczebnoscAtakujacych -= iloscZabitychPrzeciwnikow;
                                break;
                            }
                        }
                    }
                }
                else if (jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak() < przeciwnik.PZ)
                {
                    przeciwnik.PZ -= jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak();
                    przeciwnik.calkowitePZ -= jednostkiGraczaLista[rundaGracza].ObliczCalkowityAtak();
                }
            }

            rundaGracza++;

            if (rundaGracza >= jednostkiGraczaLista.Count)
            {
                rundaGracza = 0;
            }

            czyRundaGracza = false;
        }

        #endregion Zadaj obrazenia przeciwnikowi

        #region Zadaj obrazenia jednostce gracza

        public void ZadajObrazeniaJednostceGracza(JednostkiGracza jednostka)
        {
            if (przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak() >= jednostka.calkowitePZ)
            {
                jednostka.pictureBox.Visible = false;
                o1.mieszkancy.liczbaMieszkancow -= jednostka.liczebnoscAtakujacych;
                jednostka.liczebnoscAtakujacych = 0;
                jednostka.PZ = 0;
                jednostka.calkowitePZ = 0;
                jednostka.progressBarPZ.ForeColor = Color.Black;
                jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
                jednostka.labelIlosc.Text = "0";
                jednostka.labelPZ.Text = "0";
                //jednostkiGraczaLista.Remove(jednostka);

                //if(iloscJednostekGracza > 0)
                //{
                //    iloscJednostekGracza--;
                //}

                //if(rundaGracza > 0)
                //{
                //    rundaGracza--;
                //}

                if (rundaGracza == jednostkiGraczaLista.IndexOf(jednostka))
                {
                    if (rundaGracza == jednostkiGraczaLista.Count - 1)
                    {
                        rundaGracza = 0;
                    }
                    else
                    {
                        rundaGracza = jednostkiGraczaLista.IndexOf(jednostka);
                    }
                }
                else if (rundaGracza > jednostkiGraczaLista.IndexOf(jednostka))
                {
                    rundaGracza--;
                }

                jednostkiGraczaLista.Remove(jednostka);
            }
            else
            {
                if (przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak() == jednostka.PZ)
                {
                    if (jednostka.liczebnoscAtakujacych == 1)
                    {
                        jednostka.liczebnoscAtakujacych--;
                        o1.mieszkancy.liczbaMieszkancow--;
                        jednostka.pictureBox.Visible = false;
                        jednostka.PZ = 0;
                        jednostka.calkowitePZ = 0;
                        jednostka.progressBarPZ.ForeColor = Color.Black;
                        jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
                        jednostka.labelIlosc.Text = "0";
                        jednostka.labelPZ.Text = "0";
                        //jednostkiGraczaLista.Remove(jednostka);

                        //if (iloscJednostekGracza > 0)
                        //{
                        //    iloscJednostekGracza--;
                        //}

                        //if (rundaGracza > 0)
                        //{
                        //    rundaGracza--;
                        //}

                        if (rundaGracza == jednostkiGraczaLista.IndexOf(jednostka))
                        {
                            if (rundaGracza == jednostkiGraczaLista.Count - 1)
                            {
                                rundaGracza = 0;
                            }
                            else
                            {
                                rundaGracza = jednostkiGraczaLista.IndexOf(jednostka);
                            }
                        }
                        else if (rundaGracza > jednostkiGraczaLista.IndexOf(jednostka))
                        {
                            rundaGracza--;
                        }

                        jednostkiGraczaLista.Remove(jednostka);
                    }
                    else
                    {
                        jednostka.liczebnoscAtakujacych--;
                        o1.mieszkancy.liczbaMieszkancow--;
                        jednostka.PZ = jednostka.stalePZ;
                        jednostka.calkowitePZ -= przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak();
                    }
                }
                else if (przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak() > jednostka.PZ)
                {
                    if (jednostka.liczebnoscAtakujacych == 1)
                    {
                        jednostka.liczebnoscAtakujacych--;
                        o1.mieszkancy.liczbaMieszkancow--;
                        jednostka.pictureBox.Visible = false;
                        jednostka.PZ = 0;
                        jednostka.calkowitePZ = 0;
                        jednostka.progressBarPZ.ForeColor = Color.Black;
                        jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
                        jednostka.labelIlosc.Text = "0";
                        jednostka.labelPZ.Text = "0";
                        //jednostkiGraczaLista.Remove(jednostka);

                        //if (iloscJednostekGracza > 0)
                        //{
                        //    iloscJednostekGracza--;
                        //}

                        //if (rundaGracza > 0)
                        //{
                        //    rundaGracza--;
                        //}

                        if (rundaGracza == jednostkiGraczaLista.IndexOf(jednostka))
                        {
                            if (rundaGracza == jednostkiGraczaLista.Count - 1)
                            {
                                rundaGracza = 0;
                            }
                            else
                            {
                                rundaGracza = jednostkiGraczaLista.IndexOf(jednostka);
                            }
                        }
                        else if (rundaGracza > jednostkiGraczaLista.IndexOf(jednostka))
                        {
                            rundaGracza--;
                        }

                        jednostkiGraczaLista.Remove(jednostka);
                    }
                    else
                    {
                        int resztaPZ;

                        jednostka.calkowitePZ -= przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak();
                        jednostka.PZ -= przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak();

                        //for (int i = 0; i < przeciwnicy[rundaGracza].ObliczCalkowityAtak(); i++)
                        //{
                        //if (jednostka.PZ <= 0)
                        //{
                        //    resztaPZ = jednostka.PZ;
                        //    jednostka.PZ = jednostka.stalePZ + resztaPZ;
                        //}
                        //else if (jednostka.PZ > 0)
                        //{
                        //    jednostka.liczebnoscAtakujacych -= i;
                        //    break;
                        //}
                        //}

                        while (jednostka.PZ <= 0)
                        {
                            int iloscZabitychJednostekGracza = 0;

                            if (jednostka.PZ <= 0)
                            {
                                resztaPZ = jednostka.PZ;
                                jednostka.PZ = jednostka.stalePZ + resztaPZ;
                                iloscZabitychJednostekGracza++;
                            }
                                
                            if (jednostka.PZ > 0)
                            {
                                jednostka.liczebnoscAtakujacych -= iloscZabitychJednostekGracza;
                                o1.mieszkancy.liczbaMieszkancow -= iloscZabitychJednostekGracza;
                                break;
                            }
                        }
                    }
                }
                else if (przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak() < jednostka.PZ)
                {
                    jednostka.PZ -= przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak();
                    jednostka.calkowitePZ -= przeciwnicyLista[rundaPrzeciwnika].ObliczCalkowityAtak();
                }
            }
        }

        #endregion Zadaj obrazenia jednostce gracza

        #region Zaatakuj przeciwnika z bliska 

        public void ZaatakujPrzeciwnikaBliskiDystans()
        {
            if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekPrawo;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekLewo;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekGora;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekDol;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X - 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekDol;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y - 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X + 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekDol;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X - 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekGora;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y + 100 && jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X == przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X + 100)
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekGora;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
        }

        #endregion Zaatakuj przeciwnika z bliska

        #region Zaatakuj przeciwnika z daleka

        public void ZaatakujPrzeciwnikaDalekiDystans()
        {
            if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X && jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X - 300 && ((jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y - 300) && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y + 300)))
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekPrawo;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }
            else if (jednostkiGraczaLista[rundaGracza].pictureBox.Location.X >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X && przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.X + 300 >= jednostkiGraczaLista[rundaGracza].pictureBox.Location.X && ((jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y >= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y - 300) && (jednostkiGraczaLista[rundaGracza].pictureBox.Location.Y <= przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.Location.Y + 300)))
            {
                jednostkiGraczaLista[rundaGracza].pictureBox.Image = jednostkiGraczaLista[rundaGracza].obrazekLewo;
                przeciwnicyLista[ktoryPrzeciwnikMaZostacZaatakowany].pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi();
            }           
        }

        #endregion Zaatakuj przeciwnika z daleka

        #region Timer

        private void TimerGra_Tick(object sender, EventArgs e)
        {
            SprawdzZasiegRuchuJednostek();
            MechanikaPrzeciwnik();

            foreach (var item in jednostkiGraczaLista)
            {
                item.progressBarPZ.Value = item.ObliczCalkowitePZ();
                item.labelPZ.Text = item.ObliczCalkowitePZ().ToString();
                item.labelIlosc.Text = item.liczebnoscAtakujacych.ToString();
                item.labelAtak.Text = item.ObliczCalkowityAtak().ToString();
                item.labelObrona.Text = item.obronaDomyslna.ToString();
            }

            foreach(var item in przeciwnicyLista)
            {
                item.progressBarPZ.Value = item.ObliczCalkowitePZ();
                item.labelPZ.Text = item.ObliczCalkowitePZ().ToString();
                item.labelIlosc.Text = item.liczebnoscAtakujacych.ToString();
                item.labelAtak.Text = item.ObliczCalkowityAtak().ToString();
                item.labelObrona.Text = item.obronaDomyslna.ToString();
            }

            if (jednostkiGraczaLista.Count == 0)
            {
                obszaryInstancji.czyBitwa = false;
                obszaryInstancji.czyOdblokowane = false;
                Close();
                MessageBox.Show("Poniosłeś porażkę");
            }

            if (przeciwnicyLista.Count == 0)
            {
                obszaryInstancji.czyBitwa = false;
                obszaryInstancji.czyOdblokowane = true;
                instancje.timerMapa.Start();
                Close();
                MessageBox.Show("Zwyciężyłeś");
            }
        }

        #endregion Timer

        #region Ustaw atrybuty

        public void UstawAtrybutyJednostkiGracza()
        {
            jednostkiGraczaLista[numerRundyJednostki].ObliczPZJednostki();
            jednostkiGraczaLista[numerRundyJednostki].ObliczAtakJednostki();
            jednostkiGraczaLista[numerRundyJednostki].ObliczCalkowityAtak();
            jednostkiGraczaLista[numerRundyJednostki].stalePZ = jednostkiGraczaLista[numerRundyJednostki].PZ;
            jednostkiGraczaLista[numerRundyJednostki].ObliczCalkowitePZ();
            jednostkiGraczaLista[numerRundyJednostki].pictureBox.Visible = true;
            jednostkiGraczaLista[numerRundyJednostki].progressBarPZ = progressBarPZGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelNazwa = nazwaJednostkiGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelPZ = iloscPZJednostkiGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelIlosc = liczebnoscJednostkiGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelAtak = atakJednostkiGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelObrona = obronaJednostkiGraczaLista[numerRundyJednostki];
            jednostkiGraczaLista[numerRundyJednostki].labelNazwa.Text = jednostkiGraczaLista[numerRundyJednostki].nazwa;
            jednostkiGraczaLista[numerRundyJednostki].progressBarPZ.Maximum = jednostkiGraczaLista[numerRundyJednostki].calkowitePZ;
            jednostkiGraczaLista[numerRundyJednostki].progressBarPZ.Visible = true;
        }

        public void UstawAtrybutyPrzeciwnika()
        {
            przeciwnicyLista[numerRundyPrzeciwnika].ObliczPZJednostki();
            przeciwnicyLista[numerRundyPrzeciwnika].ObliczCalkowityAtak();
            przeciwnicyLista[numerRundyPrzeciwnika].stalePZ = przeciwnicyLista[numerRundyPrzeciwnika].PZ;
            przeciwnicyLista[numerRundyPrzeciwnika].ObliczCalkowitePZ();
            przeciwnicyLista[numerRundyPrzeciwnika].pictureBox.Visible = true;
            przeciwnicyLista[numerRundyPrzeciwnika].pictureBox.Image = przeciwnicyLista[numerRundyPrzeciwnika].obrazekLewo;
            przeciwnicyLista[numerRundyPrzeciwnika].progressBarPZ = progressBarPZPrzeciwnikaLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelNazwa = nazwaPrzeciwnicyLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelPZ = iloscPZPrzeciwnikaLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelIlosc = liczebnoscPrzeciwnikaLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelAtak = atakPrzeciwnikaLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelObrona = obronaPrzeciwnikaLista[numerRundyPrzeciwnika];
            przeciwnicyLista[numerRundyPrzeciwnika].labelNazwa.Text = przeciwnicyLista[numerRundyPrzeciwnika].nazwa;
            przeciwnicyLista[numerRundyPrzeciwnika].progressBarPZ.Maximum = przeciwnicyLista[numerRundyPrzeciwnika].calkowitePZ;
            przeciwnicyLista[numerRundyPrzeciwnika].progressBarPZ.Visible = true;
        }

        #endregion Ustaw atrybuty

        #region PictureBoxy przeciwnika

        private void PictureBoxPrzeciwnik0_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik0);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if(jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        private void PictureBoxPrzeciwnik1_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik1);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        private void PictureBoxPrzeciwnik2_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik2);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        private void PictureBoxPrzeciwnik3_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik3);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }          
        }

        private void PictureBoxPrzeciwnik4_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik4);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        private void PictureBoxPrzeciwnik5_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik5);

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        private void PictureBoxPrzeciwnik6_Click(object sender, EventArgs e)
        {
            ktoryPrzeciwnikMaZostacZaatakowany = przeciwnicyLista.IndexOf(przeciwnik6); ;

            if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == true)
            {
                ZaatakujPrzeciwnikaBliskiDystans();
            }
            else if (jednostkiGraczaLista[rundaGracza].czyAtakNaBliskiDystans == false)
            {
                ZaatakujPrzeciwnikaDalekiDystans();
            }
            else
            {
                Cursor.Current = Cursors.No;

            }
        }

        #endregion PictureBoxy przeciwnika

        private void ButtonObrona_Click(object sender, EventArgs e)
        {
            if(czyRundaGracza == true)
            {
                if(rundaGracza == jednostkiGraczaLista.Count - 1)
                {
                    rundaGracza = 0;
                }
                else
                {
                    rundaGracza++;
                }

                czyRundaGracza = false;
            }
        }

        private void ButtonOpusc_Click(object sender, EventArgs e)
        {
            this.Close();
            obszaryInstancji.czyBitwa = false;
            obszaryInstancji.czyOdblokowane = false;
        }
    }
}
