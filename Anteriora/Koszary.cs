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
    
    public partial class Koszary : Form
    {
        readonly Poczatek o;
        int zmianaObrazka = 1;

        public Koszary(Poczatek c)
        {
            o = c;
            InitializeComponent();
            UstawLabele();
            timerKoszary.Start();
        }


        #region werbowanie jednostek

        private void ButtonWerbujZwiadowca_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if (o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if (o.skorzanaZbroja.ilosc >= 1 && o.skorzaneButy.ilosc >= 1 && o.skorzaneSpodnie.ilosc >= 1 && o.skorzanyHelm.ilosc >= 1)
                {
                    if (o.zloto.ilosc >= 30)
                    {
                        o.skorzanaZbroja.ilosc--;
                        o.skorzaneButy.ilosc--;
                        o.skorzaneSpodnie.ilosc--;
                        o.skorzanyHelm.ilosc--;
                        o.zloto.ilosc -= 30;
                        o.zwiadowca.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        private void buttonWerbujPiechur_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if(o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if(o.skorzanaZbroja.ilosc >= 1 && o.skorzaneButy.ilosc >= 1 && o.skorzaneSpodnie.ilosc >= 1 && o.skorzanyHelm.ilosc >= 1 && o.kamiennyMiecz.ilosc >= 1)
                {
                    if(o.zloto.ilosc >= 10)
                    {
                        o.skorzanaZbroja.ilosc--;
                        o.skorzaneButy.ilosc--;
                        o.skorzaneSpodnie.ilosc--;
                        o.skorzanyHelm.ilosc--;
                        o.kamiennyMiecz.ilosc--;
                        o.zloto.ilosc -= 10;
                        o.piechur.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        private void buttonWerbujLucznik_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if (o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if (o.skorzanaZbroja.ilosc >= 1 && o.skorzaneButy.ilosc >= 1 && o.skorzaneSpodnie.ilosc >= 1 && o.skorzanyHelm.ilosc >= 1 && o.luk.ilosc >= 1)
                {
                    if (o.zloto.ilosc >= 15)
                    {
                        o.skorzanaZbroja.ilosc--;
                        o.skorzaneButy.ilosc--;
                        o.skorzaneSpodnie.ilosc--;
                        o.skorzanyHelm.ilosc--;
                        o.luk.ilosc--;
                        o.zloto.ilosc -= 15;
                        o.lucznik.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        private void buttonWerbujRycerz_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if (o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if (o.zelaznaZbroja.ilosc >= 1 && o.zelazneButy.ilosc >= 1 && o.zelazneSpodnie.ilosc >= 1 && o.zelaznyHelm.ilosc >= 1 && o.zelaznyMiecz.ilosc >= 1 && o.zelaznaTarcza.ilosc >= 1)
                {
                    if (o.zloto.ilosc >= 50)
                    {
                        o.zelaznaZbroja.ilosc--;
                        o.zelazneButy.ilosc--;
                        o.zelazneSpodnie.ilosc--;
                        o.zelaznyHelm.ilosc--;
                        o.zelaznyMiecz.ilosc--;
                        o.zelaznaTarcza.ilosc--;
                        o.zloto.ilosc -= 50;
                        o.rycerz.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        private void ButtonWerbujCzarnyRycerz_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if (o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if (o.obsydianowaZbroja.ilosc >= 1 && o.obsydianoweButy.ilosc >= 1 && o.obsydianoweSpodnie.ilosc >= 1 && o.obsydianowyHelm.ilosc >= 1 && o.obsydianowyMiecz.ilosc >= 1 && o.obsydianowaTarcza.ilosc >= 1)
                {
                    if (o.zloto.ilosc >= 100)
                    {
                        o.obsydianowaZbroja.ilosc--;
                        o.obsydianoweButy.ilosc--;
                        o.obsydianoweSpodnie.ilosc--;
                        o.obsydianowyHelm.ilosc--;
                        o.obsydianowyMiecz.ilosc--;
                        o.obsydianowaTarcza.ilosc--;
                        o.zloto.ilosc -= 100;
                        o.czarnyRycerz.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        private void ButtonWerbujCzarnyLucznik_Click(object sender, EventArgs e)
        {
            o.mieszkancy.ObliczLiczbeBezrobotnychMieszkancow();

            if (o.mieszkancy.liczbaBezrobotnychMieszkancow > 0)
            {
                if (o.obsydianowaZbroja.ilosc >= 1 && o.obsydianoweButy.ilosc >= 1 && o.obsydianoweSpodnie.ilosc >= 1 && o.obsydianowyHelm.ilosc >= 1 && o.luk.ilosc >= 1)
                {
                    if (o.zloto.ilosc >= 150)
                    {
                        o.obsydianowaZbroja.ilosc--;
                        o.obsydianoweButy.ilosc--;
                        o.obsydianoweSpodnie.ilosc--;
                        o.obsydianowyHelm.ilosc--;
                        o.luk.ilosc--;
                        o.zloto.ilosc -= 150;
                        o.czarnyLucznik.liczebnoscAtakujacych++;
                    }
                    else
                    {
                        new Wiadomosc("Niewystarczająca ilość monet.").ShowDialog();
                    }
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość wyposażenia").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Brak rekrutów").ShowDialog();
            }

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

        }

        #endregion werbowanie jednostek

        #region ulepszanie jednostek

        private void ButtonUlepszZwiadowca_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.zwiadowca, 500);
        }

        private void ButtonUlepszPiechur_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.piechur, 500);
        }

        private void ButtonUlepszLucznik_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.lucznik, 750);
        }

        private void ButtonUlepszRycerz_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.rycerz, 1000);
        }

        private void ButtonUlepszCzarnyRycerz_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.czarnyRycerz, 2000);
        }

        private void ButtonUlepszCzarnyLucznik_Click(object sender, EventArgs e)
        {
            UlepszJednostke(o.czarnyLucznik, 2500);
        }

        public void UlepszJednostke(JednostkiGracza jednostka, int iloscMonet)
        {
            if(jednostka.poziomUlepszenia < 3)
            {
                int kosztUlepszenia = iloscMonet * jednostka.poziomUlepszenia;
                if(o.zloto.ilosc >= kosztUlepszenia)
                {
                    o.zloto.ilosc -= kosztUlepszenia;
                    jednostka.poziomUlepszenia++;
                }
                else
                {
                    new Wiadomosc("Niewystarczająca ilość monet.\n\nPotrzebujesz " + kosztUlepszenia + " monet, aby ulepszyć jednostkę do " + (jednostka.poziomUlepszenia+1) +" poziomu.").ShowDialog();
                }
            }
            else
            {
                new Wiadomosc("Osiągnięto maksymalny poziom ulepszenia jednostki.").ShowDialog();
            }
        }

        #endregion ulepszanie jednostek


        #region timer
        private void timerKoszary_Tick(object sender, EventArgs e)
        {
            UstawLabele();

            zmianaObrazka++;

            switch(zmianaObrazka)
            {
                case 1:
                    pictureBoxZwiadowca.Image = Properties.Resources.zwiadowcaprawo;
                    pictureBoxPiechur.Image = Properties.Resources.wojownikprawo;
                    pictureBoxLucznik.Image = Properties.Resources.lucznikprawo;
                    pictureBoxRycerz.Image = Properties.Resources.rycerzprawo;
                    pictureBoxCzarnyRycerz.Image = Properties.Resources.czarnyrycerzprawo;
                    pictureBoxCzarnyLucznik.Image = Properties.Resources.czarnylucznikprawo;
                    break;
                case 2:
                    pictureBoxZwiadowca.Image = Properties.Resources.zwiadowcadol;
                    pictureBoxPiechur.Image = Properties.Resources.wojownikdol;
                    pictureBoxLucznik.Image = Properties.Resources.lucznikdol;
                    pictureBoxRycerz.Image = Properties.Resources.rycerzdol;
                    pictureBoxCzarnyRycerz.Image = Properties.Resources.czarnyrycerzdol;
                    pictureBoxCzarnyLucznik.Image = Properties.Resources.czarnylucznikdol;
                    break;
                case 3:
                    pictureBoxZwiadowca.Image = Properties.Resources.zwiadowcalewo;
                    pictureBoxPiechur.Image = Properties.Resources.wojowniklewo;
                    pictureBoxLucznik.Image = Properties.Resources.luczniklewo;
                    pictureBoxRycerz.Image = Properties.Resources.rycerzlewo;
                    pictureBoxCzarnyRycerz.Image = Properties.Resources.czarnyrycerzlewo;
                    pictureBoxCzarnyLucznik.Image = Properties.Resources.czarnyluczniklewo;
                    break;
                case 4:
                    pictureBoxZwiadowca.Image = Properties.Resources.zwiadowcagora;
                    pictureBoxPiechur.Image = Properties.Resources.wojownikgora;
                    pictureBoxLucznik.Image = Properties.Resources.lucznikgora;
                    pictureBoxRycerz.Image = Properties.Resources.rycerzgora;
                    pictureBoxCzarnyRycerz.Image = Properties.Resources.czarnyrycerzgora;
                    pictureBoxCzarnyLucznik.Image = Properties.Resources.czarnylucznikgora;
                    zmianaObrazka = 0;
                    break;
            }
        }

        #endregion timer

        #region informacje o jednostce po kliknieciu na pictureboxa

        // koszt wrzucic do klasy JednostkiMilitarne

        private void PictureBoxZwiadowca_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Zwiadowca\n\nJednostka rozpoznawcza wysyłana w celu zaczerpnięcia informacji na temat wrogiego obszaru.\n\nSzansa na powodzenie misji rozpoznawczej: " + o.zwiadowca.ObliczAtakJednostki() + "%." + "\n\nWyposażenie: skórzany hełm, skórzana zbroja, skórzane spodnie, skórzane buty." + "\n\nKoszt: 30 monet.").Show();
        }

        private void PictureBoxPiechur_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Piechur\n\nJednostka walcząca w zwarciu.\n\nAtak jednostki: " + o.piechur.ObliczAtakJednostki() + ".\n\nObrona jednostki: " + o.piechur.ObliczObroneJednostki() + ".\n\nWyposażenie: skórzany hełm, skórzana zbroja, skórzane spodnie, skórzane buty.\n\nBroń: kamienny miecz.\n\nKoszt: 10 monet.").ShowDialog();
        }

        private void PictureBoxLucznik_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Łucznik\n\nJednostka walcząca na dystans.\n\nAtak jednostki: " + o.lucznik.ObliczAtakJednostki() + ".\n\nObrona jednostki: " + o.lucznik.ObliczObroneJednostki() + ".\n\nWyposażenie: skórzany hełm, skórzana zbroja, skórzane spodnie, skórzane buty.\n\nBroń: łuk.\n\nKoszt: 15 monet.").ShowDialog();
        }

        private void PictureBoxRycerz_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Rycerz\n\nJednostka walcząca w zwarciu.\n\nAtak jednostki: " + o.rycerz.ObliczAtakJednostki() + ".\n\nObrona jednostki: " + o.rycerz.ObliczObroneJednostki() + ".\n\nWyposażenie: żelazny hełm, żelazna zbroja, żelazne spodnie, żelazne buty, żelazna tarcza.\n\nBroń: żelazny miecz.\n\nKoszt: 50 monet.").ShowDialog();
        }

        private void PictureBoxCzarnyRycerz_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Czarny rycerz\n\nJednostka walcząca w zwarciu.\n\nAtak jednostki: " + o.czarnyRycerz.ObliczAtakJednostki() + ".\n\nObrona jednostki: " + o.czarnyRycerz.ObliczObroneJednostki() + ".\n\nWyposażenie: obsydianowy hełm, obsydianowa zbroja, obsydianowe spodnie, obsydianowe buty, obsydianowa tarcza.\n\nBroń: obsydianowy miecz.\n\nKoszt: 100 monet.").ShowDialog();
        }

        private void PictureBoxCzarnyLucznik_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Czarny łucznik\n\nJednostka walcząca na dystans.\n\nAtak jednostki: " + o.czarnyLucznik.ObliczAtakJednostki() + ".\n\nObrona jednostki: " + o.czarnyLucznik.ObliczObroneJednostki() + ".\n\nWyposażenie: obsydianowy hełm, obsydianowa zbroja, obsydianowe spodnie, obsydianowe buty.\n\nBroń: łuk.\n\nKoszt: 150 monet.").ShowDialog();
        }

        #endregion informacje o jednostce po kliknieciu na pictureboxa

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        public void UstawLabele()
        {
            labelLiczebnoscZwiadowca.Text = "Liczebność: " + o.zwiadowca.liczebnoscAtakujacych.ToString();
            labelPoziomZwiadowca.Text = "Poziom: " + o.zwiadowca.poziomUlepszenia.ToString();
            labelWartoscAtakuZwiadowca.Text = "Skuteczność: " + o.zwiadowca.ObliczAtakJednostki().ToString() + "%";

            labelLiczebnoscPiechur.Text = "Liczebność: " + o.piechur.liczebnoscAtakujacych.ToString();
            labelPoziomPiechur.Text = "Poziom: " + o.piechur.poziomUlepszenia.ToString();
            labelWartoscAtakuPiechur.Text = "Wartość ataku: " + o.piechur.ObliczAtakJednostki().ToString();
            labelWartoscObronyPiechur.Text = "Wartość obrony: " + o.piechur.ObliczObroneJednostki().ToString();

            labelLiczebnoscLucznik.Text = "Liczebność: " + o.lucznik.liczebnoscAtakujacych.ToString();
            labelPoziomLucznik.Text = "Poziom: " + o.lucznik.poziomUlepszenia.ToString();
            labelWartoscAtakuLucznik.Text = "Wartość ataku: " + o.lucznik.ObliczAtakJednostki().ToString();
            labelWartoscObronyLucznik.Text = "Wartość obrony: " + o.lucznik.ObliczObroneJednostki().ToString();

            labelLiczebnoscRycerz.Text = "Liczebność: " + o.rycerz.liczebnoscAtakujacych.ToString();
            labelPoziomRycerz.Text = "Poziom: " + o.rycerz.poziomUlepszenia.ToString();
            labelWartoscAtakuRycerz.Text = "Wartość ataku: " + o.rycerz.ObliczAtakJednostki().ToString();
            labelWartoscObronyRycerz.Text = "Wartość obrony: " + o.rycerz.ObliczObroneJednostki().ToString();

            labelLiczebnoscCzarnyRycerz.Text = "Liczebność: " + o.czarnyRycerz.liczebnoscAtakujacych.ToString();
            labelPoziomCzarnyRycerz.Text = "Poziom: " + o.czarnyRycerz.poziomUlepszenia.ToString();
            labelWartoscAtakuCzarnyRycerz.Text = "Wartość ataku: " + o.czarnyRycerz.ObliczAtakJednostki().ToString();
            labelWartoscObronyCzarnyRycerz.Text = "Wartość obrony: " + o.czarnyRycerz.ObliczObroneJednostki().ToString();

            labelLiczebnoscCzarnyLucznik.Text = "Liczebność: " + o.czarnyLucznik.liczebnoscAtakujacych.ToString();
            labelPoziomCzarnyLucznik.Text = "Poziom: " + o.czarnyLucznik.poziomUlepszenia.ToString();
            labelWartoscAtakuCzarnyLucznik.Text = "Wartość ataku: " + o.czarnyLucznik.ObliczAtakJednostki().ToString();
            labelWartoscObronyCzarnyLucznik.Text = "Wartość obrony: " + o.czarnyLucznik.ObliczObroneJednostki().ToString();
        }
    }
}
