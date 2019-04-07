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

    public partial class Osada : Form
    {
        public Początek o;

        // nowy "surowiec"
        public Materiały zloto = new Materiały(1000);
        // mieszkancy
        public Mieszkancy mieszkancy = new Mieszkancy();

        // obiekty klasy Budowle, nasze budynki w osadzie
        
        public Budowle tartak1 = new Budowle("pierwszy tartak", 1);
        public Budowle tartak2 = new Budowle("drugi tartak", 1);
        public Budowle kamieniolom1 = new Budowle("pierwszy kamieniołom", 2);
        public Budowle kamieniolom2 = new Budowle("drugi kamieniołom", 2);
        public Budowle kwateraRybacka = new Budowle("kwatera rybacka", 2);
        public Budowle chataMaga = new Budowle("chata maga", 1);
        public Budowle chatkaRolnika = new Budowle("chatka rolnika", 3);
        public Budowle hodowla = new Budowle("hodowla", 4);
        public Budowle studnia = new Budowle("studnia", 2);
        public Budowle magazyn = new Budowle("magazyn", 1);
        public Budowle targowisko = new Budowle("targowisko",1);
        public Budowle most = new Budowle("most",4);
        public Budowle mur = new Budowle("mur", 10);
        public Budowle koszary = new Budowle("koszary", 20);
        public Budowle budynekMieszkalny = new Budowle("budynek mieszkalny", 4);
        public Budowle kuznia = new Budowle("kuznia", 2);

        // w lodowej krainie

        public Budowle warsztatLK = new Budowle("lodowy warsztat",1);
        public Budowle kwateraRybackaLK1 = new Budowle("pierwsza lodowa kwatera rybacka",1);
        public Budowle kwateraRybackaLK2 = new Budowle("druga lodowa kwatera rybacka",1);
        public Budowle studniaLK1 = new Budowle("pierwsza lodowa studnia",1);
        public Budowle studniaLK2 = new Budowle("druga lodowa studnia",1);
        public Budowle budynekMieszkalnyLK = new Budowle("lodowy budynek mieszkalny",1);



        public List<Budowle> budynki = new List<Budowle>();

        #region zmienne związane z sprawdzeniem czy magazyn jest przepełniony

        public int i = 0;
        public int j = 0;

        #endregion



        // stworzenie listy jednostek ofensywnych
        public List<JednostkiGracza> listWojownik = new List<JednostkiGracza>();
        public List<JednostkiGracza> listRycerz = new List<JednostkiGracza>();
        public List<JednostkiGracza> listKawalerzysta = new List<JednostkiGracza>();

        // i defensywnych
        public List<JednostkiDefensywne> listPeltasta = new List<JednostkiDefensywne>();
        public List<JednostkiDefensywne> listLucznik = new List<JednostkiDefensywne>();
        public List<JednostkiDefensywne> listHalabardnik = new List<JednostkiDefensywne>();

       
        public JednostkiGracza zwiadowca = new JednostkiGracza(0,1,30);

        // tworzenie obietów klasy JednostkiOfensywnne, czyli nasze jednostki atakujące
        public JednostkiGracza wojownik = new JednostkiGracza("Wojownik",1,10,10,100,3,96,96,"wojownikprawo","wojowniklewo","wojownikgora","wojownikdol");
        public JednostkiGracza rycerz = new JednostkiGracza();
        public JednostkiGracza kawalerzysta = new JednostkiGracza();
        public JednostkiGracza lucznik2 = new JednostkiGracza("Łucznik",1,20,5,50,10,96,288,"lucznikprawo", "łuczniklewo", "lucznikgora", "lucznikdol");
        public JednostkiGracza wlocznik = new JednostkiGracza("Włócznik",1,40,20,200,2,96,96,"wlocznikprawo", "wloczniklewo", "wlocznikgora", "wlocznikdol");
        public JednostkiGracza juzek = new JednostkiGracza();
        public JednostkiGracza jednostkiOfensywne = new JednostkiGracza();

        public Wrogowie goblin = new Wrogowie("Goblin", 10, 5, 20, 96, 96, "goblinprawo","goblinlewo","goblingora","goblindol");
        public Wrogowie goblin2 = new Wrogowie("Goblin", 10, 5, 20, 96, 96, "goblinprawo", "goblinlewo", "goblingora", "goblindol");
        public Wrogowie ork = new Wrogowie("Ork", 400, 50, 400, 96, 96, "orkprawo", "orklewo", "orkgora", "orkdol");
        public Wrogowie nietoperzDuzy = new Wrogowie("Duży nietoperz", 10, 5, 20, 96, 96, "nietoperzduzyprawo", "nietoperzduzylewo", "nietoperzduzygora", "nietoperzduzydol");
        public Wrogowie nietoperzMaly = new Wrogowie("Mały nietoperz", 5, 1, 5, 96, 96, "nietoperzmalyprawo", "nietoperzmalylewo", "nietoperzmalygora", "nietoperzmalydol");
        public Wrogowie robak = new Wrogowie("Robak", 30, 10, 50, 96, 96, "robakprawo", "robaklewo", "robakgora", "robakdol");
        public Wrogowie wazOgnisty = new Wrogowie("Ognisty wąż", 10, 10, 100, 96, 0, "waz4lewo", "waz4lewo", "waz4lewo", "waz4lewo");
        public Wrogowie wazJadowity = new Wrogowie("Jadowity wąż", 10, 10, 100, 96, 0, "waz3lewo", "waz3lewo", "waz3lewo", "waz3lewo");

        // tworzenie obiektów klasy JednostkiDefensywne, czyli nasze jednostki obronne
        public JednostkiDefensywne peltasta = new JednostkiDefensywne();
        public JednostkiDefensywne lucznik = new JednostkiDefensywne();
        public JednostkiDefensywne halabardnik = new JednostkiDefensywne();
        public JednostkiDefensywne jednostkiDefensywne = new JednostkiDefensywne();

        public List<Materiały> surowce = new List<Materiały>();

        public Instancje osadaGoblinow = new Instancje("Osada Goblinów", 120, 5, "orklewo", "orkgora", "orkdol");
        public Instancje jaskiniaWezy = new Instancje("Jaskinia Węży", 180, 10, "waz2lewo", "waz2lewo", "waz2lewo");
        public Instancje lodowaKraina = new Instancje("Lodowa kraina", 180, 10, "orklewo", "orkgora", "orkdol");
        //public Instancje zagadka = new Instancje();

        public int czasGry;
        public int czasBudowy;
        public string notatkaZwiadowcy;
        public string zapisDoDziennika;
        public int zwiadowcaCzas;

        public Random losowa = new Random();

        public Osada(Początek c)
        {
            o = c;
            InitializeComponent();
            // kontynuacja czasu rzeczywistego
            czasGry = o.czasGry;
            timerCzasGryMapa2.Start();
            timerJedzenie.Start();
            surowce.Add(o.drewno);
            surowce.Add(o.siano);
            surowce.Add(o.jedzenie);
            surowce.Add(o.kamień);
            surowce.Add(o.woda);
            surowce.Add(zloto);

            o.drewno.ilosc = 1000;
            o.kamień.ilosc = 1000;
            o.siano.ilosc = 1000;

            //zagadka.obrazekLewo = "dinozaurmacius";
            //zagadka.obrazekDol = "dinozaurmacius";

            #region Przypisanie budowli do pictureBoxów

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
            magazyn.pictureBox = pictureBoxMagazyn;
            mur.pictureBox = pictureBoxMur;


            #endregion

            #region Przypisanie pozycji budowlom

            tartak1.PrzypiszPozycjeBudowli();
            tartak2.PrzypiszPozycjeBudowli();
            kamieniolom1.PrzypiszPozycjeBudowli();
            kamieniolom2.PrzypiszPozycjeBudowli();
            chatkaRolnika.PrzypiszPozycjeBudowli();
            kwateraRybacka.PrzypiszPozycjeBudowli();
            most.PrzypiszPozycjeBudowli();
            studnia.PrzypiszPozycjeBudowli();
            koszary.PrzypiszPozycjeBudowli();
            budynekMieszkalny.PrzypiszPozycjeBudowli();
            targowisko.PrzypiszPozycjeBudowli();
            hodowla.PrzypiszPozycjeBudowli();
            chataMaga.PrzypiszPozycjeBudowli();
            kuznia.PrzypiszPozycjeBudowli();
            magazyn.PrzypiszPozycjeBudowli();
            mur.PrzypiszPozycjeBudowli();

            #endregion

        }


        private void timerCzasGryMapa2_Tick(object sender, EventArgs e)
        {
            czasGry++;
            // wrzucenie do labeli wartości surowców 
            labelCzasMapa1.Text = "  Czas gry: " + czasGry.ToString() + " sekund(y)";
            labelDrewno.Text = "Drewno: " + o.drewno.ilosc.ToString();
            labelKamien.Text = "Kamień: " + o.kamień.ilosc.ToString();
            labelSiano.Text = "Siano: " + o.siano.ilosc.ToString();
            labelJedzenie.Text = "Jedzenie: " + o.jedzenie.ilosc.ToString();
            labelWoda.Text = "Woda: " + o.woda.ilosc.ToString();
            labelZloto.Text = "Złoto: " + zloto.ilosc.ToString();

            ZmianaKoloruTekstuLabela(o.drewno, labelDrewno);
            ZmianaKoloruTekstuLabela(o.kamień, labelKamien);
            ZmianaKoloruTekstuLabela(o.siano, labelSiano);
            ZmianaKoloruTekstuLabela(o.jedzenie, labelJedzenie);
            ZmianaKoloruTekstuLabela(o.woda, labelWoda);
            ZmianaKoloruTekstuLabela(zloto, labelZloto);

            ZmienKolorLabelaPrzyGlodzie();

            PojemnośćMagazynu();

            //wzrost wartosci surowców
            o.drewno.ObliczPoziomUlepszenia(tartak1.poziomUlepszenia, tartak2.poziomUlepszenia, 0);
            o.drewno.ZwiekszPrzyrostMaterialu(o.drewno.poziomEksploatacji);

            o.kamień.ObliczPoziomUlepszenia(kamieniolom1.poziomUlepszenia, kamieniolom2.poziomUlepszenia, 0);
            o.kamień.ZwiekszPrzyrostMaterialu(o.kamień.poziomEksploatacji);

            o.siano.ObliczPoziomUlepszenia(chatkaRolnika.poziomUlepszenia, 0, 0);
            o.siano.ZwiekszPrzyrostMaterialu(o.siano.poziomEksploatacji);

            o.jedzenie.ObliczPoziomUlepszenia(hodowla.poziomUlepszenia, kwateraRybacka.poziomUlepszenia, 0);
            o.jedzenie.ZwiekszPrzyrostMaterialu(o.jedzenie.poziomEksploatacji);

            o.woda.ObliczPoziomUlepszenia(studnia.poziomUlepszenia, 0, 0);
            o.woda.ZwiekszPrzyrostMaterialu(o.woda.poziomEksploatacji);

            if (budynekMieszkalny.pictureBox.Visible == true)
            {
                if (mieszkancy.czyPrzyrostMieszkancow == true)
                {
                    timerMieszkancy.Start();
                }
                else if (mieszkancy.czyPrzyrostMieszkancow == false)
                {
                    timerMieszkancy.Stop();
                }
            }

           

        }

        private void timerMieszkancy_Tick(object sender, EventArgs e)
        {
            mieszkancy.liczbaMieszkancow++;
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
        }

      
        private void pictureBoxNamiotPoziom1_Click(object sender, EventArgs e)
        {
            new Namiot(this, o).ShowDialog();
        }

        
        private void pictureBoxKoszary_Click(object sender, EventArgs e)
        {
            new Koszary(this).Show();
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
            new Ulepszanie(this, o).ShowDialog();
        }

        private void buttonCzyszczenie_Click(object sender, EventArgs e)
        {
            textBoxInformacja.Clear();
        }

        private void pictureBoxHodowla_Click(object sender, EventArgs e)
        {
            new Hodowla(this, o).ShowDialog();
        }

        #region Sprawdzenie czy magazyn przepełniony
        public void PojemnośćMagazynu()
        {
            if (magazyn.poziomUlepszenia == 0)
            {
                foreach (var item in surowce)
                {
                    if (item.ilosc > 99)
                    {
                        i++;
                        item.ilosc = 100;
                    }
                    else if (item.ilosc <= 99)
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
            else if (magazyn.poziomUlepszenia == 1)
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
            else if (magazyn.poziomUlepszenia == 2)
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
            else if (magazyn.poziomUlepszenia == 3)
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

        #region Zmiana koloru tekstu labela przy przepełnieniu magazynu materiałami
        public void ZmianaKoloruTekstuLabela(Materiały material, Label label)
        {
            if (magazyn.poziomUlepszenia == 0)
            {
                if (material.ilosc >= 99)
                {
                    label.ForeColor = Color.DimGray;
                }
                else if (material.ilosc < 99)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (magazyn.poziomUlepszenia == 1)
            {
                if (material.ilosc >= 999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 999)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (magazyn.poziomUlepszenia == 2)
            {
                if (material.ilosc >= 1999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 1999)
                {
                    label.ForeColor = Color.Black;
                }
            }
            else if (magazyn.poziomUlepszenia == 3)
            {
                if (material.ilosc >= 2999)
                {
                    label.ForeColor = Color.DarkGreen;
                }
                else if (material.ilosc < 2999)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }
        #endregion


        #region Zmiana koloru labela jedzenia i wody podczas głodu
        public void ZmienKolorLabelaPrzyGlodzie()
        {
            if(o.jedzenie.ilosc< 0)
            {
                labelJedzenie.ForeColor = Color.DarkRed;
            }
            else
            {
                labelJedzenie.ForeColor = Color.Black;
            }

            if(o.woda.ilosc< 0)
            {
                labelWoda.ForeColor = Color.DarkRed;
            }
            else
            {
                labelWoda.ForeColor = Color.Black;
            }
        }

        #endregion

        private void pictureBoxMapa_Click(object sender, EventArgs e)
        {
            new EkranLadowania(o, this, "load").Show();                        
        }

        private void timerWojna_Tick(object sender, EventArgs e)
        {
            WojnaAkcja(osadaGoblinow);
            WojnaAkcja(jaskiniaWezy);
        }

        private void buttonELO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string InformacjaNaTematInstancji(Instancje instancja, Wrogowie wrog1, Wrogowie wrog2, Wrogowie wrog3, Wrogowie wrog4, Wrogowie wrog5)
        {
            return "W instancji " + instancja.nazwa + " znajdziesz przeciwników takich jak: " + wrog1.nazwa + ", " + wrog2.nazwa + ", " + wrog3.nazwa + ", " + wrog4.nazwa + ", "
                    + wrog5.nazwa + "." + Environment.NewLine + Environment.NewLine;

        }

        public string InformacjaNaTematPrzeciwnika(Instancje instancja, int poziom, Wrogowie wrog, int ilosc, string styl)
        {
            return "W " + instancja.nazwa + " na poziomie " + poziom + " znajdziesz: " + Environment.NewLine + Environment.NewLine + wrog.nazwa + ":" + Environment.NewLine + "Sztuk: " + ilosc + Environment.NewLine +
                   "Atak jednostkowy: " + wrog.atak + Environment.NewLine + "Obrona jednostkowa: " + wrog.obrona + Environment.NewLine + "PZ jednostkowe: " + wrog.PZ + Environment.NewLine +
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

                    if (wylosowana <= zwiadowca.atak)
                    {
                        MessageBox.Show("udalo sie" + wylosowana.ToString() + " " + zwiadowca.atak.ToString());

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
                        MessageBox.Show("nie udalo sie" + wylosowana.ToString() + " " + zwiadowca.atak.ToString());
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

                    if (wylosowana <= zwiadowca.atak)
                    {
                        MessageBox.Show("udalo sie" + wylosowana.ToString() + " " + zwiadowca.atak.ToString());

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
                        MessageBox.Show("nie udalo sie" + wylosowana.ToString() + " " + zwiadowca.atak.ToString());
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

        public void Zjedz()
        {
            if ((o.jedzenie.ilosc < (mieszkancy.liczbaPracujacychMieszkancow * 2) + mieszkancy.liczbaBezrobotnychMieszkancow) || (o.woda.ilosc < (mieszkancy.liczbaPracujacychMieszkancow * 2) + mieszkancy.liczbaBezrobotnychMieszkancow))
            {
                mieszkancy.poziomZadowolenia = 0;
                ZmienNaGlod();
            }
            else
            {
                ZmienNaDostatek();  
            }

            o.jedzenie.ilosc -= (mieszkancy.liczbaPracujacychMieszkancow * 2) + mieszkancy.liczbaBezrobotnychMieszkancow;
            o.woda.ilosc -= (mieszkancy.liczbaPracujacychMieszkancow * 2) + mieszkancy.liczbaBezrobotnychMieszkancow;
        }

        public static void ZmienNaGlod()
        {
            Materiały.glod = 2;

        }

        public static void ZmienNaDostatek()
        {
            Materiały.glod = 1;
        }



        private void pictureBoxBudynekMieszkalny_Click(object sender, EventArgs e)
        {
            new BudynekMieszkalny(this,o).ShowDialog();
        }

        private void timerJedzenie_Tick(object sender, EventArgs e)
        {
            Zjedz();
        }
    }
}


