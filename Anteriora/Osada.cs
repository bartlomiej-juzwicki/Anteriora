using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anteriora
{

    public partial class Osada : Form
    {
        public Poczatek o;

        //budynki w osadzie

        public Budowle tartak1 = new Budowle("pierwszy tartak", 1);
        public Budowle tartak2 = new Budowle("drugi tartak", 1);
        public Budowle kamieniolom1 = new Budowle("pierwszy kamieniołom", 2);
        public Budowle kamieniolom2 = new Budowle("drugi kamieniołom", 2);
        public Budowle kwateraRybacka = new Budowle("kwatera rybacka", 2);
        public Budowle chataMaga = new Budowle("chata maga", 1);
        public Budowle chatkaRolnika = new Budowle("chatka rolnika", 3);
        public Budowle hodowla = new Budowle("hodowla", 4);
        public Budowle studnia = new Budowle("studnia", 2);
        
        public Budowle targowisko = new Budowle("targowisko",1);
        public Budowle most = new Budowle("most", 4);
        public Budowle mur = new Budowle("mur", 10);
        public Budowle koszary = new Budowle("koszary", 6);
        public Budowle budynekMieszkalny = new Budowle("budynek mieszkalny", 4);
        public Budowle kuznia = new Budowle("kuznia", 2);

        //budynki w lodowej krainie

        public Budowle warsztatLK = new Budowle("lodowy warsztat",1);
        public Budowle kwateraRybackaLK1 = new Budowle("pierwsza lodowa kwatera rybacka",1);
        public Budowle kwateraRybackaLK2 = new Budowle("druga lodowa kwatera rybacka",1);
        public Budowle studniaLK1 = new Budowle("pierwsza lodowa studnia",1);
        public Budowle studniaLK2 = new Budowle("druga lodowa studnia",1);
        public Budowle budynekMieszkalnyLK = new Budowle("lodowy budynek mieszkalny",1);

        //budynki w osadzie goblinów

        public Budowle kopalniaKamienia = new Budowle("kopalnia kamienia", 2);
        public Budowle kopalniaRudyZelaza1 = new Budowle("pierwsza kopalnia rudy zelaza", 2);
        public Budowle kopalniaRudyZelaza2 = new Budowle("druga kopalnia rudy zelaza", 2);

        public List<Budowle> budynki = new List<Budowle>();
        public List<Materialy> surowce = new List<Materialy>();
        
        public Przeciwnicy goblin = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin2 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin3 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin4 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin5 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin6 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy goblin7 = new Przeciwnicy("Goblin", 10, 5, 20, 100, Properties.Resources.goblinprawo, Properties.Resources.goblinlewo, Properties.Resources.goblingora, Properties.Resources.goblindol);
        public Przeciwnicy ork = new Przeciwnicy("Ork", 400, 50, 400, 100, Properties.Resources.orkprawo, Properties.Resources.orklewo, Properties.Resources.orkgora, Properties.Resources.orkdol);
        public Przeciwnicy nietoperzDuzy = new Przeciwnicy("Duży nietoperz", 10, 5, 20, 100, Properties.Resources.nietoperzduzyprawo, Properties.Resources.nietoperzduzylewo, Properties.Resources.nietoperzduzygora, Properties.Resources.nietoperzduzydol);
        public Przeciwnicy nietoperzMaly = new Przeciwnicy("Mały nietoperz", 5, 1, 5, 100, Properties.Resources.nietoperzmalyprawo, Properties.Resources.nietoperzmalylewo, Properties.Resources.nietoperzmalygora, Properties.Resources.nietoperzmalydol);
        public Przeciwnicy robak = new Przeciwnicy("Robak", 30, 10, 50, 100, Properties.Resources.robakprawo, Properties.Resources.robaklewo, Properties.Resources.robakgora, Properties.Resources.robakdol);
        public Przeciwnicy wazOgnisty = new Przeciwnicy("Ognisty wąż", 10, 10, 100, 100, Properties.Resources.waz3lewo, Properties.Resources.waz3lewo, Properties.Resources.waz3lewo, Properties.Resources.waz3lewo);
        public Przeciwnicy wazJadowity = new Przeciwnicy("Jadowity wąż", 10, 10, 100, 100, Properties.Resources.waz1lewo, Properties.Resources.waz1lewo, Properties.Resources.waz1lewo, Properties.Resources.waz1lewo);
        public Przeciwnicy brak = new Przeciwnicy();

        public ObszaryInstancji osadaGoblinow1 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow2 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow3 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow4 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow5 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow6 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow7 = new ObszaryInstancji();
        public ObszaryInstancji osadaGoblinow8 = new ObszaryInstancji();

        public Instancje osadaGoblinow = new Instancje("Osada Goblinów", 120, 5, "orklewo", "orkgora", "orkdol");
        public Instancje jaskiniaWezy = new Instancje("Jaskinia Węży", 180, 10, "waz2lewo", "waz2lewo", "waz2lewo");
        public Instancje lodowaKraina = new Instancje("Lodowa kraina", 180, 10, "orklewo", "orkgora", "orkdol");
        //public Instancje zagadka = new Instancje();

        public int i, j; // zmienne związane ze sprawdzaniem przepełnienia magazynu
        public int czasBudowy;
        public string notatkaZwiadowcy;
        public string zapisDoDziennika;
        public int zwiadowcaCzas;
        public int czasDoZjedzenia;
        public int czasDoPobraniaPodatkow;
        public string nazwaBudowliBudowa;
        public string nazwaBudowliUlepszenie;

        public Random losowa = new Random();

        public Osada(Poczatek c)
        {
            o = c;
            InitializeComponent();

            pictureBoxGraczPart5.BackgroundImage = PostacGracza.obrazekGora;

            budynki.AddRange(new Budowle[] { tartak1, tartak2, kamieniolom1, kamieniolom2, kwateraRybacka, chataMaga, chatkaRolnika, hodowla, studnia, o.magazyn, targowisko, most, mur, koszary, budynekMieszkalny, kuznia });
            surowce.AddRange(new Materialy[] { o.drewno, o.kamień, o.siano, o.skora, o.welna, o.jedzenie, o.woda, o.rudaZelaza, o.rudaObsydianu, o.zelazo, o.obsydian, o.skorzanyPasek, o.kawalekDrewna });

            timerCzasGry.Start();
            //zagadka.obrazekLewo = "dinozaurmacius";
            //zagadka.obrazekDol = "dinozaurmacius";

            #region Przypisanie budowli do pictureBoxów

            // nie mogłem wrzucić tego do konstruktora?

            tartak1.pictureBox = pictureBoxTartak1;
            tartak2.pictureBox = pictureBoxTartak2;
            kamieniolom1.pictureBox = pictureBoxKamieniolom1;
            kamieniolom2.pictureBox = pictureBoxKamieniolom2;
            chatkaRolnika.pictureBox = pictureBoxChatkaRolnika;
            kwateraRybacka.pictureBox = pictureBoxKwateraRybacka;
            most.pictureBox = pictureBoxMost;
            studnia.pictureBox = pictureBoxStudnia;
            koszary.pictureBox = pictureBoxKoszary;
            budynekMieszkalny.pictureBox = pictureBoxBudynekMieszkalny;
            targowisko.pictureBox = pictureBoxTargowisko;
            hodowla.pictureBox = pictureBoxHodowla;
            chataMaga.pictureBox = pictureBoxChataMaga;
            kuznia.pictureBox = pictureBoxKuznia;
            o.magazyn.pictureBox = pictureBoxMagazyn;
            mur.pictureBox = pictureBoxMur;

            #endregion

            #region Przypisanie pozycji budowlom

            Budowle.PrzypiszPozycjeBudowli(budynki);

            #endregion


        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            PojemnośćMagazynu();

            o.mieszkancy.liczebnoscWojsk = (o.zwiadowca.liczebnoscAtakujacych + o.piechur.liczebnoscAtakujacych + o.lucznik.liczebnoscAtakujacych + o.rycerz.liczebnoscAtakujacych + o.czarnyRycerz.liczebnoscAtakujacych + o.czarnyLucznik.liczebnoscAtakujacych + o.piechur.liczebnoscBroniacych + o.lucznik.liczebnoscBroniacych + o.rycerz.liczebnoscBroniacych + o.czarnyRycerz.liczebnoscBroniacych + o.czarnyLucznik.liczebnoscBroniacych);

            if (budynekMieszkalny.pictureBox.Visible == true)
            {
                if (o.mieszkancy.czyPrzyrostMieszkancow == true)
                {
                    timerMieszkancy.Start();
                }
                else if (o.mieszkancy.czyPrzyrostMieszkancow == false)
                {
                    timerMieszkancy.Stop();
                }
            }

            WojnaAkcja(osadaGoblinow);
            WojnaAkcja(jaskiniaWezy);

            Zjedz();
            PobierzPodatek();

        }

        private void timerMieszkancy_Tick(object sender, EventArgs e)
        {
            if (o.ubraniaMieszkancow.ilosc >= 1 && o.lozko.ilosc >= 1)
            {
                o.ubraniaMieszkancow.ilosc--;
                o.lozko.ilosc--;
                o.mieszkancy.liczbaMieszkancow++;
            }
            else
            {
                new Wiadomosc("Brakuje ubrań lub łóżek dla mieszkańców.").ShowDialog();
                o.mieszkancy.czyPrzyrostMieszkancow = false;
                timerMieszkancy.Stop();
            }
        }

        private void Osada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Osada_Shown(object sender, EventArgs e)
        {
            /* DialogResult dialogResult = MessageBox.Show("Czuję, że to już niedaleko!", "", MessageBoxButtons.OK);
             if (dialogResult == DialogResult.OK)
             {
                 pictureBoxGraczPart5.Visible = false;
                 pictureBoxGraczPart6.Visible = true;
                 MessageBox.Show("Tak! Właśnie tu rozbiję swój namiot.");

             }
              */
        }
        
        private void pictureBoxMiejsceNaNamiot_Click(object sender, EventArgs e)
        {
            pictureBoxMiejsceNaNamiot.Visible = false;
            pictureBoxNamiot.Visible = true;
            pictureBoxGraczPart6.Visible = false;
            pictureBoxGraczPart5.Visible = false;
            //MessageBox.Show("Czas rozbudować osadę!");

            new Wiadomosc("To idealne miejsce na zbudowanie osady.\n\nZarządzaj ją mądrze, każdy twój ruch ma swoje konsekwencje.").Show();
        }
     
        private void pictureBoxNamiotPoziom1_Click(object sender, EventArgs e)
        {
            new Namiot(this, o).ShowDialog();
        }
        
        private void pictureBoxKoszary_Click(object sender, EventArgs e)
        {
            new Koszary(o).ShowDialog();
        }

        /// <summary>
        /// po kliknieciu na targowisko przechodzimy do okna Targowisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTargowisko_Click(object sender, EventArgs e)
        {
            new Targowisko(this, o).ShowDialog();
        }

        private void pictureBoxWarsztat_Click(object sender, EventArgs e)
        {
            new Kuznia(this, o).ShowDialog();
        }

        private void buttonCzyszczenie_Click(object sender, EventArgs e)
        {
            textBoxInformacja.Clear();
        }

        #region Sprawdzenie czy magazyn przepełniony

        public void PojemnośćMagazynu()
        {
            if (o.magazyn.poziomUlepszenia == 0)
            {
                foreach (var item in surowce)
                {
                    if (item.ilosc > 999)
                    {
                        i++;
                        item.ilosc = 1000;
                    }
                    else if (item.ilosc <= 999)
                    {
                        i = i + 0;
                    }
                }

                if (j == 0 && i > 0)
                {

                    textBoxInformacja.AppendText("Magazyn przepełniony!");
                    textBoxInformacja.AppendText(Environment.NewLine);
                    j = 1;
                }
                else if (j == 1 && i == 0)
                {
                    j = 0;
                }

                i = 0;

            }
            else if (o.magazyn.poziomUlepszenia == 1)
            {
                foreach (var item in surowce)
                {
                    if (item.ilosc > 999)
                    {
                        i++;
                        item.ilosc = 1000;
                    }
                    else if (item.ilosc <= 999)
                    {
                        i = i + 0;
                    }
                }

                if (j == 0 && i > 0)
                {
                    textBoxInformacja.AppendText("Magazyn przepełniony!");
                    textBoxInformacja.AppendText(Environment.NewLine);
                    j = 1;
                }
                else if (j == 1 && i == 0)
                {
                    j = 0;
                }

                i = 0;
            }
            else if (o.magazyn.poziomUlepszenia == 2)
            {
                foreach (var item in surowce)
                {
                    if (item.ilosc > 1999)
                    {
                        i++;
                        item.ilosc = 2000;
                    }
                    else if (item.ilosc <= 1999)
                    {
                        i = i + 0;
                    }
                }

                if (j == 0 && i > 0)
                {
                    textBoxInformacja.AppendText("Magazyn przepełniony!");
                    textBoxInformacja.AppendText(Environment.NewLine);
                    j = 1;
                }
                else if (j == 1 && i == 0)
                {
                    j = 0;
                }

                i = 0;
            }
            else if (o.magazyn.poziomUlepszenia == 3)
            {
                foreach (var item in surowce)
                {
                    if (item.ilosc > 2999)
                    {
                        i++;
                        item.ilosc = 3000;
                    }
                    else if (item.ilosc <= 2999)
                    {
                        i = i + 0;
                    }
                }

                if (j == 0 && i > 0)
                {

                    textBoxInformacja.AppendText("Magazyn przepełniony!");
                    textBoxInformacja.AppendText(Environment.NewLine);

                    j = 1;
                }
                else if (j == 1 && i == 0)
                {
                    j = 0;
                }

                i = 0;
            }
        }
        #endregion

        private void pictureBoxMapa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Visible = false;
            new EkranLadowania(o, this, new Size(1920,1080),2).Show();                        
        }

        private void buttonELO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string InformacjaNaTematInstancji(Instancje instancja, Przeciwnicy wrog1, Przeciwnicy wrog2, Przeciwnicy wrog3, Przeciwnicy wrog4, Przeciwnicy wrog5)
        {
            return "W instancji " + instancja.nazwa + " znajdziesz przeciwników takich jak: " + wrog1.nazwa + ", " + wrog2.nazwa + ", " + wrog3.nazwa + ", " + wrog4.nazwa + ", "
                    + wrog5.nazwa + "." + Environment.NewLine + Environment.NewLine;

        }

        public string InformacjaNaTematPrzeciwnika(Instancje instancja, int poziom, Przeciwnicy wrog, int ilosc, string styl)
        {
            return "W " + instancja.nazwa + " na poziomie " + poziom + " znajdziesz: " + Environment.NewLine + Environment.NewLine + wrog.nazwa + ":" + Environment.NewLine + "Sztuk: " + ilosc + Environment.NewLine +
                   "Atak jednostkowy: " + wrog.atak + Environment.NewLine + "Obrona jednostkowa: " + wrog.obronaDomyslna + Environment.NewLine + "PZ jednostkowe: " + wrog.PZ + Environment.NewLine +
                   "Styl walki: " + styl + Environment.NewLine + Environment.NewLine;

        }

        private void timerZwiadowca_Tick(object sender, EventArgs e)
        {
            #region informacje zdobyte przez zwiadowce
            if (osadaGoblinow.akcjaZwiadowca == true)
            {
                osadaGoblinow.czasZwiadowcy++;

                if (osadaGoblinow.czasZwiadowcy == osadaGoblinow.czasRuchuZwiadowcy)
                {
                    int wylosowana;
                    wylosowana = losowa.Next(0, 101);

                    if (wylosowana <= o.zwiadowca.atak)
                    {
                        MessageBox.Show("udalo sie" + wylosowana.ToString() + " " + o.zwiadowca.atak.ToString());

                        if (osadaGoblinow.licznikZwiadowca == 1)
                        {
                            notatkaZwiadowcy += InformacjaNaTematInstancji(osadaGoblinow, nietoperzMaly, nietoperzDuzy, goblin, goblin, ork) + InformacjaNaTematPrzeciwnika(osadaGoblinow, 1, nietoperzMaly, 10, "zwarcie")
                                                + InformacjaNaTematPrzeciwnika(osadaGoblinow, 1, nietoperzDuzy, 5,"zwarcie");
                        }
                        else if (osadaGoblinow.licznikZwiadowca == 2)
                        {
                            notatkaZwiadowcy += InformacjaNaTematPrzeciwnika(osadaGoblinow, 2, goblin, 10, "zwarcie") + InformacjaNaTematPrzeciwnika(osadaGoblinow, 2, goblin, 5, "zwarcie");
                        }
                        else if (osadaGoblinow.licznikZwiadowca == 3)
                        {
                            notatkaZwiadowcy += InformacjaNaTematPrzeciwnika(osadaGoblinow, 3, goblin, 15, "zwarcie") + InformacjaNaTematPrzeciwnika(osadaGoblinow, 3, ork, 1, "zwarcie");
                        }

                        osadaGoblinow.licznikZwiadowca++;
                        osadaGoblinow.czasZwiadowcy = 0;
                        osadaGoblinow.akcjaZwiadowca = false;
                        timerZwiadowca.Stop();
                    }
                    else
                    {
                        MessageBox.Show("nie udalo sie" + wylosowana.ToString() + " " + o.zwiadowca.atak.ToString());
                        osadaGoblinow.czasZwiadowcy = 0;
                        osadaGoblinow.akcjaZwiadowca = false;
                        timerZwiadowca.Stop();
                    }
                }
            }
            else if (jaskiniaWezy.akcjaZwiadowca == true)
            {
                jaskiniaWezy.czasZwiadowcy++;

                if (jaskiniaWezy.czasZwiadowcy == jaskiniaWezy.czasRuchuZwiadowcy)
                {
                    int wylosowana;
                    wylosowana = losowa.Next(0, 101);

                    if (wylosowana <= o.zwiadowca.atak)
                    {
                        MessageBox.Show("udalo sie" + wylosowana.ToString() + " " + o.zwiadowca.atak.ToString());

                        if (jaskiniaWezy.licznikZwiadowca == 1)
                        {
                            notatkaZwiadowcy += InformacjaNaTematInstancji(jaskiniaWezy, nietoperzMaly, nietoperzDuzy, robak, wazJadowity, wazOgnisty) + InformacjaNaTematPrzeciwnika(jaskiniaWezy, 1, robak, 10, "zwarcie");
                        }
                        else if (jaskiniaWezy.licznikZwiadowca == 2)
                        {
                            notatkaZwiadowcy += InformacjaNaTematPrzeciwnika(jaskiniaWezy, 2, wazOgnisty, 1, "dystans") + InformacjaNaTematPrzeciwnika(jaskiniaWezy, 2, wazJadowity, 1, "dystans");
                        }

                        jaskiniaWezy.licznikZwiadowca++;
                        jaskiniaWezy.czasZwiadowcy = 0;
                        jaskiniaWezy.akcjaZwiadowca = false;
                        timerZwiadowca.Stop();
                    }
                    else
                    {
                        MessageBox.Show("nie udalo sie" + wylosowana.ToString() + " " + o.zwiadowca.atak.ToString());
                        jaskiniaWezy.czasZwiadowcy = 0;
                        jaskiniaWezy.akcjaZwiadowca = false;
                        timerZwiadowca.Stop();
                    }
                }


            }
            #endregion
        }

        public void WojnaAkcja(Instancje instancja)
        {
            if (instancja.akcjaWrog)
            {
                instancja.czasWroga++;

                if (instancja.czasWroga == 1)
                {
                    textBoxInformacja.AppendText("Armia z " + instancja.nazwa + " zmierza w kierunku osady!");
                    textBoxInformacja.AppendText(Environment.NewLine);
                }
                else if (instancja.czasWroga == instancja.czasRuchuWrogow)
                {
                    instancja.akcjaWrog = false;
                    instancja.czasWroga = 0;
                    var o = Properties.Resources.ResourceManager.GetObject(instancja.obrazekDol);
                    pictureBoxWrog.Image = (Image)o;
                    pictureBoxWrog.Visible = true;
                    MessageBox.Show("Zostałeś zaatakowany przez " + instancja.nazwa + "!");

                }
            }
        }

        #region Konsumpcja jedzenia i wody

        // metoda Zjedz() określa czynności związane z konsumpcją jedzenia i wody przez mieszkańców
        public void Zjedz()

        {
            if(czasDoZjedzenia == 10)
            {
                int iloscDoSpozycia = (o.mieszkancy.liczbaPracujacychMieszkancow * o.mieszkancy.poziomPodatkow) + (o.mieszkancy.liczbaBezrobotnychMieszkancow * o.mieszkancy.poziomPodatkow / 2);
                

                if (o.jedzenie.ilosc < iloscDoSpozycia || o.woda.ilosc < iloscDoSpozycia)
                {
                    o.mieszkancy.poziomZadowolenia = 1;
                    o.mieszkancy.poziomPodatkow = 1;
                    ZmienNaGlod();
                }
                else
                {
                    if (Materialy.glod == 2)
                    {
                        ZmienNaDostatek();
                    }
                }

                o.jedzenie.ilosc -= iloscDoSpozycia;
                o.woda.ilosc -= iloscDoSpozycia;
                czasDoZjedzenia = 0;
            }
            else
            {
                czasDoZjedzenia++;
            }
        }

        #endregion

        public static void ZmienNaGlod()
        {
            Materialy.glod = 2;
        }

        public static void ZmienNaDostatek()
        {
            Materialy.glod = 1;
        }
               
        private void pictureBoxBudynekMieszkalny_Click(object sender, EventArgs e)
        {
            new BudynekMieszkalny(this,o).ShowDialog();
        }

        private void timerPrzyrostDrewna_Tick(object sender, EventArgs e)
        {
            o.drewno.ObliczPoziomUlepszenia(tartak1.poziomUlepszenia, tartak2.poziomUlepszenia);
            o.drewno.ZwiekszPrzyrostMaterialu();
        }

        private void timerPrzyrostKamienia_Tick(object sender, EventArgs e)
        {
            o.kamień.ObliczPoziomUlepszenia(kamieniolom1.poziomUlepszenia, kamieniolom2.poziomUlepszenia, kopalniaKamienia.poziomUlepszenia);
            o.kamień.ZwiekszPrzyrostMaterialu();
        }

        private void timerPrzyrostSiana_Tick(object sender, EventArgs e)
        {
            o.siano.ObliczPoziomUlepszenia(chatkaRolnika.poziomUlepszenia, 0);
            o.siano.ZwiekszPrzyrostMaterialu();
        }

        private void timerPrzyrostSkory_Tick(object sender, EventArgs e)
        {
            o.skora.ObliczPoziomUlepszenia(hodowla.poziomUlepszenia, 0);
            o.skora.ZwiekszPrzyrostMaterialu();
        }

        private void TimerPrzyrostWelny_Tick(object sender, EventArgs e)
        {
            o.welna.ObliczPoziomUlepszenia(hodowla.poziomUlepszenia, 0);
            o.welna.ZwiekszPrzyrostMaterialu();
        }

        private void timerPrzyrostJedzenia_Tick(object sender, EventArgs e)
        {
            o.jedzenie.ObliczPoziomUlepszenia(hodowla.poziomUlepszenia, kwateraRybacka.poziomUlepszenia);
            o.jedzenie.ZwiekszPrzyrostMaterialu();
        }

        private void timerPrzyrostWody_Tick(object sender, EventArgs e)
        {
            o.woda.ObliczPoziomUlepszenia(studnia.poziomUlepszenia, 0);
            o.woda.ZwiekszPrzyrostMaterialu();
        }

        private void TimerPrzyrostRudyZelaza_Tick(object sender, EventArgs e)
        {
            o.rudaZelaza.ObliczPoziomUlepszenia(kopalniaRudyZelaza1.poziomUlepszenia, kopalniaRudyZelaza2.poziomUlepszenia);
            o.rudaZelaza.ZwiekszPrzyrostMaterialu();
        }

        public void PobierzPodatek()
        {
            if(czasDoPobraniaPodatkow == 10)
            {
                if(Materialy.glod == 1)
                {
                    o.zloto.ilosc += (o.mieszkancy.liczbaMieszkancow * o.mieszkancy.poziomPodatkow);
                }
                else if(Materialy.glod == 2)
                {
                    o.zloto.ilosc += 0;
                }
                
                czasDoPobraniaPodatkow = 0;
            }
            else
            {
                czasDoPobraniaPodatkow++;
            }
        }

        public void Budowa2(Budowle budowle, Timer timerSurowiec)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timerCzasBudowy.Stop();
                progressBar.Visible = false;
                budowle.pictureBox.Visible = true;
                budowle.poziomUlepszenia = 1;
                progressBar.Value = 0;
                textBoxInformacja.AppendText("Wybudowano " + budowle.nazwa + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
                timerSurowiec.Start();
            }
            else
            {
                progressBar.Increment(5);
            }
        }

        public void Budowa2(Budowle budowle)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timerCzasBudowy.Stop();
                progressBar.Visible = false;
                budowle.pictureBox.Visible = true;
                budowle.poziomUlepszenia = 1;
                progressBar.Value = 0;
                textBoxInformacja.AppendText("Wybudowano " + budowle.nazwa + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
            }
            else
            {
                progressBar.Increment(5);

            }
        }

        //public void Budowa2(Budowle budowle, Timer timerSurowiec1, Timer timerSurowiec2)
        //{
        //    if (progressBar.Value == progressBar.Maximum)
        //    {
        //        timerCzasBudowy.Stop();
        //        progressBar.Visible = false;
        //        budowle.pictureBox.Visible = true;
        //        budowle.poziomUlepszenia = 1;
        //        progressBar.Value = 0;
        //        textBoxInformacja.AppendText("Wybudowano " + budowle.nazwa + "!");
        //        textBoxInformacja.AppendText(Environment.NewLine);
        //        timerSurowiec1.Start();
        //        timerSurowiec2.Start();
        //    }
        //    else
        //    {
        //        progressBar.Increment(5);
        //    }
        //}

        public void Budowa2(Budowle budowle, Timer timerSurowiec1, Timer timerSurowiec2, Timer timerSurowiec3)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timerCzasBudowy.Stop();
                progressBar.Visible = false;
                budowle.pictureBox.Visible = true;
                budowle.poziomUlepszenia = 1;
                progressBar.Value = 0;
                textBoxInformacja.AppendText("Wybudowano " + budowle.nazwa + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
                timerSurowiec1.Start();
                timerSurowiec2.Start();
                timerSurowiec3.Start();
            }
            else
            {
                progressBar.Increment(5);
            }
        }



        public void BudowaInstancje(Budowle budowla, Timer timerSurowiec)
        {
            if(budowla.progressBarBudowa.Value == budowla.progressBarBudowa.Maximum)
            {
                timerCzasBudowy.Stop();
                budowla.progressBarBudowa.Visible = false;
                budowla.pictureBox.Visible = true;
                budowla.czyBudowlaIstnieje = true;
                budowla.pictureBox.BackgroundImage = budowla.bitmap;
                budowla.poziomUlepszenia = 1;
                budowla.progressBarBudowa.Value = 0;
                textBoxInformacja.AppendText("Wybudowano " + budowla.nazwa + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
                timerSurowiec.Start();
            }
            else
            {
                budowla.progressBarBudowa.Increment(5);
            }
        }

        private void TimerCzasBudowy_Tick(object sender, EventArgs e)
        {
            switch (nazwaBudowliBudowa)
            {
                case "pierwszy tartak":
                    Budowa2(tartak1, timerPrzyrostDrewna);
                    break;
                case "drugi tartak":
                    Budowa2(tartak2, timerPrzyrostDrewna);
                    break;
                case "pierwszy kamieniołom":
                    Budowa2(kamieniolom1, timerPrzyrostKamienia);
                    break;
                case "drugi kamieniołom":
                    Budowa2(kamieniolom2, timerPrzyrostKamienia);
                    break;
                case "chatka rolnika":
                    Budowa2(chatkaRolnika, timerPrzyrostSiana);
                    break;
                case "magazyn":
                    Budowa2(o.magazyn);
                    break;
                case "budynek mieszkalny":
                    Budowa2(budynekMieszkalny);
                    break;
                case "koszary":
                    Budowa2(koszary);
                    break;
                case "targowisko":
                    Budowa2(targowisko);
                    break;
                case "kuznia":
                    Budowa2(kuznia);
                    break;
                case "chata maga":
                    Budowa2(chataMaga);
                    break;
                case "kwatera rybacka":
                    Budowa2(kwateraRybacka, timerPrzyrostJedzenia);
                    break;
                case "most":
                    Budowa2(most);
                    break;
                case "mur":
                    Budowa2(mur);
                    break;
                case "hodowla":
                    Budowa2(hodowla, timerPrzyrostJedzenia, timerPrzyrostSkory, timerPrzyrostWelny);
                    break;
                case "studnia":
                    Budowa2(studnia, timerPrzyrostWody);
                    break;
                case "kopalnia kamienia":
                    BudowaInstancje(kopalniaKamienia, timerPrzyrostKamienia);
                    break;
                case "pierwsza kopalnia rudy zelaza":
                    BudowaInstancje(kopalniaRudyZelaza1, timerPrzyrostRudyZelaza);
                    break;
                case "druga kopalnia rudy zelaza":
                    BudowaInstancje(kopalniaRudyZelaza2, timerPrzyrostRudyZelaza);
                    break;
            }

        }

        public void KosztBudowyOsada(Materialy material, int ilosc, Materialy material2, int ilosc2, Budowle budowle)
        {
            if (budowle.pictureBox.Visible == false)
            {
                if (budowle.liczbaPracownikowPotrzebnychDoBudowy <= o.mieszkancy.liczbaBezrobotnychMieszkancow)
                {
                    if (material.ilosc >= ilosc && material2.ilosc >= ilosc2)
                    {
                        if (progressBar.Visible == false)
                        {
                            material.ilosc -= ilosc;
                            material2.ilosc -= ilosc2;
                            o.mieszkancy.liczbaPracujacychMieszkancow += budowle.liczbaPracownikowPotrzebnychDoBudowy;
                            progressBar.Location = budowle.punkt;
                            progressBar.Visible = true;
                            progressBar.Maximum = budowle.ZwrocCzasTrwaniaBudowy();
                            nazwaBudowliBudowa = budowle.nazwa;
                            timerCzasBudowy.Start();
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
                else
                {
                    MessageBox.Show("Brak pracowników!");
                }
            }
            else if (budowle.pictureBox.Visible == true)
            {
                MessageBox.Show("Budynek został już wybudowany!");
            }

        }

        public void KosztBudowyInstancje(Materialy material, int ilosc, Materialy material2, int ilosc2, Budowle budowla)
        {
            if (budowla.liczbaPracownikowPotrzebnychDoBudowy <= o.mieszkancy.liczbaBezrobotnychMieszkancow)
            {
                if (material.ilosc >= ilosc && material2.ilosc >= ilosc2)
                {
                    // gdy czas jest równy 0, czyli na początku
                    if (budowla.progressBarBudowa.Visible == false)
                    {
                        material.ilosc -= ilosc;
                        material2.ilosc -= ilosc2;
                        o.mieszkancy.liczbaPracujacychMieszkancow += budowla.liczbaPracownikowPotrzebnychDoBudowy;
                        budowla.progressBarBudowa.Location = budowla.punkt;
                        budowla.progressBarBudowa.Visible = true;
                        budowla.progressBarBudowa.Maximum = budowla.ZwrocCzasTrwaniaBudowy();
                        budowla.pictureBox.Visible = false;
                        nazwaBudowliBudowa = budowla.nazwa;
                        timerCzasBudowy.Start();
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
            else
            {
                MessageBox.Show("Brak pracowników!");
            }
        }

        public void UlepszanieBudynkuOsada1(Materialy material, int ilosc, Materialy material2, int ilosc2, Budowle budowle)
        {
            if (progressBar2.Visible == false)
            {
                if (budowle.pictureBox.Visible == true)
                {
                    if (material.ilosc >= (ilosc * budowle.poziomUlepszenia^2) && material2.ilosc >= (ilosc2 * budowle.poziomUlepszenia^2))
                    {
                        if (budowle.poziomUlepszenia < 3)
                        {
                            material.ilosc -= ilosc;
                            material2.ilosc -= ilosc2;
                            progressBar2.Location = budowle.punkt;
                            progressBar2.Visible = true;
                            progressBar2.Maximum = budowle.ZwrocCzasTrwaniaUlepszania();
                            nazwaBudowliUlepszenie = budowle.nazwa;
                            timerCzasUlepszenia.Start();
                        }
                        else
                        {
                            MessageBox.Show("Maksymalny poziom ulepszenia!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak określonych surowców!");
                    }
                }
                else
                {
                    MessageBox.Show("Budynek nie jest wybudowany!");
                }
            }
            else
            {
                MessageBox.Show("W jednym momencie możesz ulepszać tylko jeden budynek!");
            }
        }

        public void UlepszanieBudynkuInstancja1(Materialy material, int ilosc, Materialy material2, int ilosc2, Budowle budowla)
        {
            if (budowla.progressBarUlepszanie.Visible == false)
            {
                if (material.ilosc >= (ilosc * budowla.poziomUlepszenia ^ 2) && material2.ilosc >= (ilosc2 * budowla.poziomUlepszenia ^ 2))
                {
                    material.ilosc -= ilosc;
                    material2.ilosc -= ilosc2;
                    budowla.progressBarUlepszanie.Location = budowla.punkt;
                    budowla.pictureBox.Visible = false;
                    budowla.progressBarUlepszanie.Visible = true;
                    budowla.progressBarUlepszanie.Maximum = budowla.ZwrocCzasTrwaniaUlepszania();
                    nazwaBudowliUlepszenie = budowla.nazwa;
                    timerCzasUlepszenia.Start();
                }
                else
                {
                    MessageBox.Show("Brak określonych surowców");
                }
            }
            else
            {
                MessageBox.Show("W jednym momencie możesz ulepszać tylko jeden budynek");
            }
        }

        public void UlepszanieBudynkuOsada2(Budowle budowle)
        {
            if (progressBar2.Value == progressBar2.Maximum)
            {
                timerCzasUlepszenia.Stop();
                budowle.poziomUlepszenia++;
                progressBar2.Visible = false;
                progressBar2.Value = 0;
                textBoxInformacja.AppendText("Ulepszono " + budowle.nazwa + " do poziomu " + budowle.poziomUlepszenia + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
            }
            else
            {
                progressBar2.Increment(10);
            }
        }

        public void UlepszanieBudynkuInstancja2(Budowle budowla)
        {
            if(budowla.progressBarUlepszanie.Value == budowla.progressBarUlepszanie.Maximum)
            {
                timerCzasUlepszenia.Stop();
                budowla.poziomUlepszenia++;
                budowla.pictureBox.Visible = true;
                budowla.progressBarUlepszanie.Visible = false;
                budowla.progressBarUlepszanie.Value = 0;
                textBoxInformacja.AppendText("Ulepszono " + budowla.nazwa + " do poziomu " + budowla.poziomUlepszenia + "!");
                textBoxInformacja.AppendText(Environment.NewLine);
            }
            else
            {
                budowla.progressBarUlepszanie.Increment(10);
            }
        }

        private void PictureBoxMur_Click(object sender, EventArgs e)
        {
            new EkranLadowania(o, this, new Size(820, 539), 4).Show();
        }

        private void TimerCzasUlepszenia_Tick(object sender, EventArgs e)
        {
            switch (nazwaBudowliUlepszenie)
            {
                case "pierwszy tartak":
                    UlepszanieBudynkuOsada2(tartak1);
                    break;
                case "drugi tartak":
                    UlepszanieBudynkuOsada2(tartak2);
                    break;
                case "pierwszy kamieniołom":
                    UlepszanieBudynkuOsada2(kamieniolom1);
                    break;
                case "drugi kamieniołom":
                    UlepszanieBudynkuOsada2(kamieniolom2);
                    break;
                case "chatka rolnika":
                    UlepszanieBudynkuOsada2(chatkaRolnika);
                    break;
                case "magazyn":
                    UlepszanieBudynkuOsada2(o.magazyn);
                    break;
                case "budynek mieszkalny":
                    UlepszanieBudynkuOsada2(budynekMieszkalny);
                    break;
                case "koszary":
                    UlepszanieBudynkuOsada2(koszary);
                    break;
                case "targowisko":
                    UlepszanieBudynkuOsada2(targowisko);
                    break;
                case "kuznia":
                    UlepszanieBudynkuOsada2(kuznia);
                    break;
                case "chata maga":
                    UlepszanieBudynkuOsada2(chataMaga);
                    break;
                case "kwatera rybacka":
                    UlepszanieBudynkuOsada2(kwateraRybacka);
                    break;
                case "most":
                    UlepszanieBudynkuOsada2(most);
                    break;
                case "mur":
                    UlepszanieBudynkuOsada2(mur);
                    break;
                case "hodowla":
                    UlepszanieBudynkuOsada2(hodowla);
                    break;
                case "studnia":
                    UlepszanieBudynkuOsada2(studnia);
                    break;
                case "kopalnia kamienia":
                    UlepszanieBudynkuInstancja2(kopalniaKamienia);
                    break;
                case "pierwsza kopalnia rudy zelaza":
                    UlepszanieBudynkuInstancja2(kopalniaRudyZelaza1);
                    break;
                case "druga kopalnia rudy zelaza":
                    UlepszanieBudynkuInstancja2(kopalniaRudyZelaza2);
                    break;
            }
        }
    }
}