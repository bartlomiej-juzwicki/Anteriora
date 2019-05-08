using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Anteriora
{
    public partial class Kuznia : Form
    {

        Osada o1;
        Poczatek o2;

        List<PictureBox> sloty = new List<PictureBox>();

        Bitmap skora = Properties.Resources.skora;
        Bitmap kamien = Properties.Resources.kamien;
        Bitmap drewno = Properties.Resources.drewno;
        Bitmap zelazo = Properties.Resources.zelazo;
        Bitmap obsydian = Properties.Resources.obsydian;
        Bitmap rudaObsydianu = Properties.Resources.ruda_obsydianu;
        Bitmap rudaZelaza = Properties.Resources.ruda_zelaza;
        Bitmap welna = Properties.Resources.welna;
        Bitmap skorzanyPasek = Properties.Resources.skorzany_pasek;
        Bitmap kawalekDrewna = Properties.Resources.patyk;

        string zawartosc;
        int iloscWytwarzanychPrzedmiotow;


        public Kuznia(Osada c1, Poczatek c2)
        {
            o1 = c1;
            o2 = c2;

            InitializeComponent();

            sloty.AddRange(new PictureBox[] { pictureBoxSlot1, pictureBoxSlot2, pictureBoxSlot3, pictureBoxSlot4, pictureBoxSlot5, pictureBoxSlot6, pictureBoxSlot7, pictureBoxSlot8, pictureBoxSlot9 });

            foreach (var item in sloty)
            {
                item.AllowDrop = true;
            }

            pictureBoxSkora.BackgroundImage = skora;
            pictureBoxKamien.BackgroundImage = kamien;
            pictureBoxDrewno.BackgroundImage = drewno;
            pictureBoxZelazo.BackgroundImage = zelazo;
            pictureBoxObsydian.BackgroundImage = obsydian;
            pictureBoxRudaZelaza.BackgroundImage = rudaZelaza;
            pictureBoxRudaObsydianu.BackgroundImage = rudaObsydianu;
            pictureBoxWelna.BackgroundImage = welna;
            pictureBoxKawalekDrewna.BackgroundImage = kawalekDrewna;
            pictureBoxSkorzanyPasek.BackgroundImage = skorzanyPasek;
        }

        private void pictureBoxKowadlo_Click(object sender, EventArgs e)
        {
            iloscWytwarzanychPrzedmiotow = Convert.ToInt16(textBoxIlosc.Text);  // ilosc przedmiotow, które chcemy wytworzyć
            zawartosc = "";

            foreach (var item in sloty)
            {
                if (item.BackgroundImage == skora)
                {
                    zawartosc += "1";
                }
                else if (item.BackgroundImage == kamien)
                {
                    zawartosc += "2";
                }
                else if (item.BackgroundImage == drewno)
                {
                    zawartosc += "3";
                }
                else if (item.BackgroundImage == zelazo)
                {
                    zawartosc += "4";
                }
                else if (item.BackgroundImage == obsydian)
                {
                    zawartosc += "5";
                }
                else if(item.BackgroundImage == rudaZelaza)
                {
                    zawartosc += "6";
                }
                else if(item.BackgroundImage == rudaObsydianu)
                {
                    zawartosc += "7";
                }
                else if(item.BackgroundImage == welna)
                {
                    zawartosc += "8";
                }
                else if(item.BackgroundImage == skorzanyPasek)
                {
                    zawartosc += "9";
                }
                else if(item.BackgroundImage == kawalekDrewna)
                {
                    zawartosc += "0";
                }
                else
                {
                    zawartosc += "X";
                }
            }

            WytworzUzbrojenieSkorzane(o2.skorzanaZbroja);
            WytworzUzbrojenieSkorzane(o2.skorzaneSpodnie);
            WytworzUzbrojenieSkorzane(o2.skorzanyHelm);
            WytworzUzbrojenieSkorzane(o2.skorzaneButy);
            WytworzUzbrojenieZelazne(o2.zelaznaZbroja);
            WytworzUzbrojenieZelazne(o2.zelazneSpodnie);
            WytworzUzbrojenieZelazne(o2.zelaznyHelm);
            WytworzUzbrojenieZelazne(o2.zelazneButy);
            WytworzUzbrojenieObsydianowe(o2.obsydianowaZbroja);
            WytworzUzbrojenieObsydianowe(o2.obsydianoweSpodnie);
            WytworzUzbrojenieObsydianowe(o2.obsydianowyHelm);
            WytworzUzbrojenieObsydianowe(o2.obsydianoweButy);
            PrzetopRude(o2.zelazo, o2.rudaZelaza, rudaZelaza, zelazo);
            PrzetopRude(o2.obsydian, o2.rudaObsydianu, rudaObsydianu, obsydian);
            WytworzKamiennaBron(o2.kamiennyMiecz);
            WytworzZelaznaBron(o2.zelaznyMiecz);
            WytworzObsydianowaBron(o2.obsydianowyMiecz);
            WytworzLuk(o2.luk);
            WytworzZelaznaTarcze();
            WytworzObsydianowaTarcze();
            WytworzUbraniaMieszkancow();
            WytworzLozko();
            RabDrewno();
            TnijSkore();

        }

        public void WytworzUzbrojenieSkorzane(Uzbrojenie uzbrojenie)
        {
            if (zawartosc == uzbrojenie.kod1 || zawartosc == uzbrojenie.kod2)
            {
                int iloscPotrzebnegoMaterialu = uzbrojenie.iloscPotrzebnejSkory * iloscWytwarzanychPrzedmiotow;
                if (o2.skora.ilosc >= iloscPotrzebnegoMaterialu)
                {
                    uzbrojenie.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.skora.ilosc -= iloscPotrzebnegoMaterialu;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = uzbrojenie.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzUzbrojenieZelazne(Uzbrojenie uzbrojenie)
        {
            if (zawartosc == uzbrojenie.kod1 || zawartosc == uzbrojenie.kod2)
            {
                int iloscPotrzebnegoMaterialu = uzbrojenie.iloscPotrzebnegoZelaza * iloscWytwarzanychPrzedmiotow;
                if (o2.zelazo.ilosc >= iloscPotrzebnegoMaterialu)
                {
                    uzbrojenie.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.zelazo.ilosc -= iloscPotrzebnegoMaterialu;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = uzbrojenie.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzUzbrojenieObsydianowe(Uzbrojenie uzbrojenie)
        {
            if (zawartosc == uzbrojenie.kod1 || zawartosc == uzbrojenie.kod2)
            {
                int iloscPotrzebnegoMaterialu = uzbrojenie.iloscPotrzebnegoObsydianu * iloscWytwarzanychPrzedmiotow;
                if (o2.obsydian.ilosc >= iloscPotrzebnegoMaterialu)
                {
                    uzbrojenie.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.obsydian.ilosc -= iloscPotrzebnegoMaterialu;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = uzbrojenie.obrazek;
                    MessageBox.Show("Wytworzyłeś " + iloscWytwarzanychPrzedmiotow + " " + uzbrojenie.nazwa);
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void PrzetopRude(Materialy material, Materialy material2, Bitmap obrazek1, Bitmap obrazek2)
        {
            if (sloty.FindAll(x => x.BackgroundImage == obrazek1).Count == Materialy.iloscPotrzebnejRudy)
            {
                int iloscPotrzebnegoMaterialu = Materialy.iloscPotrzebnejRudy * iloscWytwarzanychPrzedmiotow;
                if (material2.ilosc >= iloscPotrzebnegoMaterialu)
                {
                    material.ilosc += iloscWytwarzanychPrzedmiotow;
                    material2.ilosc -= iloscPotrzebnegoMaterialu;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = obrazek2;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void RabDrewno()
        {
            if (sloty.FindAll(x => x.BackgroundImage == drewno).Count == 1 && sloty.FindAll(x => x.BackgroundImage == null).Count == 8)
            {
                if(o2.drewno.ilosc >= iloscWytwarzanychPrzedmiotow)
                {
                    o2.kawalekDrewna.ilosc += 4 * iloscWytwarzanychPrzedmiotow;
                    o2.drewno.ilosc -= iloscWytwarzanychPrzedmiotow;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = kawalekDrewna;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void TnijSkore()
        {
            if (sloty.FindAll(x => x.BackgroundImage == skora).Count == 1 && sloty.FindAll(x => x.BackgroundImage == null).Count == 8)
            {
                if (o2.skora.ilosc >= iloscWytwarzanychPrzedmiotow)
                {
                    o2.skorzanyPasek.ilosc += 4 * iloscWytwarzanychPrzedmiotow;
                    o2.skora.ilosc -= iloscWytwarzanychPrzedmiotow;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = skorzanyPasek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzKamiennaBron(Bronie bron)
        {
            if(zawartosc == bron.kod1 || zawartosc == bron.kod2 || zawartosc == bron.kod3)
            {
                int iloscPotrzebnychKawalkowDrewna = bron.iloscPotrzebnychKawalkowDrewna * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoKamienia = bron.iloscPotrzebnegoKamienia * iloscWytwarzanychPrzedmiotow;

                if(o2.kawalekDrewna.ilosc >= iloscPotrzebnychKawalkowDrewna && o2.kamień.ilosc >= iloscPotrzebnegoKamienia)
                {
                    bron.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.kawalekDrewna.ilosc -= iloscPotrzebnychKawalkowDrewna;
                    o2.kamień.ilosc -= iloscPotrzebnegoKamienia;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = bron.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów");
                }
            }
        }

        public void WytworzZelaznaBron(Bronie bron)
        {
            if (zawartosc == bron.kod1 || zawartosc == bron.kod2 || zawartosc == bron.kod3)
            {
                int iloscPotrzebnychKawalkowDrewna = bron.iloscPotrzebnychKawalkowDrewna * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoZelaza = bron.iloscPotrzebnegoZelaza * iloscWytwarzanychPrzedmiotow;

                if(o2.drewno.ilosc >= iloscPotrzebnychKawalkowDrewna && o2.zelazo.ilosc >= iloscPotrzebnegoZelaza)
                {
                    bron.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.kawalekDrewna.ilosc -= iloscPotrzebnychKawalkowDrewna;
                    o2.zelazo.ilosc -= iloscPotrzebnegoZelaza;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = bron.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzObsydianowaBron(Bronie bron)
        {
            if (zawartosc == bron.kod1 || zawartosc == bron.kod2 || zawartosc == bron.kod3)
            {
                int iloscPotrzebnychKawalkowDrewna = bron.iloscPotrzebnychKawalkowDrewna * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoObsydianu = bron.iloscPotrzebnegoObsydianu * iloscWytwarzanychPrzedmiotow;

                if(o2.drewno.ilosc >= iloscPotrzebnychKawalkowDrewna&& o2.obsydian.ilosc >= iloscPotrzebnegoObsydianu)
                {
                    bron.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.kawalekDrewna.ilosc -= iloscPotrzebnychKawalkowDrewna;
                    o2.obsydian.ilosc -= iloscPotrzebnegoObsydianu;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = bron.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzLuk(Bronie bron)
        {
            if(zawartosc == bron.kod1 || zawartosc == bron.kod2)
            {
                int iloscPotrzebnychKawałkowDrewna = bron.iloscPotrzebnychKawalkowDrewna * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnychSkorzanychPaskow = bron.iloscPotrzebnychSkorzanychPaskow * iloscWytwarzanychPrzedmiotow;

                if(o2.kawalekDrewna.ilosc >= iloscPotrzebnychKawałkowDrewna && o2.skorzanyPasek.ilosc >= iloscPotrzebnychSkorzanychPaskow)
                {
                    bron.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.kawalekDrewna.ilosc -= iloscPotrzebnychKawałkowDrewna;
                    o2.skorzanyPasek.ilosc -= iloscPotrzebnychSkorzanychPaskow;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = bron.obrazek;
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }

            }
        }

        public void WytworzZelaznaTarcze()
        {
            if (zawartosc == o2.zelaznaTarcza.kod1)
            {
                int iloscPotrzebnegoZelaza = o2.zelaznaTarcza.iloscPotrzebnegoZelaza * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoDrewna = o2.zelaznaTarcza.iloscPotrzebnegoDrewna * iloscWytwarzanychPrzedmiotow;

                if (o2.zelazo.ilosc >= iloscPotrzebnegoZelaza && o2.drewno.ilosc >= iloscPotrzebnegoDrewna)
                {
                    o2.zelaznaTarcza.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.zelazo.ilosc -= iloscPotrzebnegoZelaza;
                    o2.drewno.ilosc -= iloscPotrzebnegoDrewna;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = o2.zelaznaTarcza.obrazek;
                    MessageBox.Show("Wytworzyłeś " + iloscWytwarzanychPrzedmiotow + " " + o2.zelaznaTarcza.nazwa);
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzObsydianowaTarcze()
        {
            if (zawartosc == o2.obsydianowaTarcza.kod1)
            {
                int iloscPotrzebnegoObsydianu = o2.obsydianowaTarcza.iloscPotrzebnegoObsydianu * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoDrewna = o2.obsydianowaTarcza.iloscPotrzebnegoDrewna * iloscWytwarzanychPrzedmiotow;

                if (o2.obsydian.ilosc >= iloscPotrzebnegoObsydianu && o2.drewno.ilosc >= iloscPotrzebnegoDrewna)
                {
                    o2.obsydianowaTarcza.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.obsydian.ilosc -= iloscPotrzebnegoObsydianu;
                    o2.drewno.ilosc -= iloscPotrzebnegoDrewna;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = o2.obsydianowaTarcza.obrazek;
                    MessageBox.Show("Wytworzyłeś " + iloscWytwarzanychPrzedmiotow + " " + o2.obsydianowaTarcza.nazwa);
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzUbraniaMieszkancow()
        {
            if(zawartosc == o2.ubraniaMieszkancow.kod1)
            {
                int iloscPotrzebnejWelny = o2.ubraniaMieszkancow.iloscPotrzebnejWelny * iloscWytwarzanychPrzedmiotow;

                if(o2.welna.ilosc >= iloscPotrzebnejWelny)
                {
                    o2.ubraniaMieszkancow.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.welna.ilosc -= iloscPotrzebnejWelny;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = o2.ubraniaMieszkancow.obrazek;
                    MessageBox.Show("Wytworzyłeś " + iloscWytwarzanychPrzedmiotow + " " + o2.ubraniaMieszkancow.nazwa);
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        public void WytworzLozko()
        {
            if(zawartosc == o2.lozko.kod1)
            {
                int iloscPotrzebnejWelny = o2.lozko.iloscPotrzebnejWelny * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnychSkorzanychPaskow = o2.lozko.iloscPotrzebnychSkorzanychPaskow * iloscWytwarzanychPrzedmiotow;
                int iloscPotrzebnegoDrewna = o2.lozko.iloscPotrzebnegoDrewna * iloscWytwarzanychPrzedmiotow;

                if(o2.welna.ilosc >= iloscPotrzebnejWelny && o2.skorzanyPasek.ilosc >= iloscPotrzebnychSkorzanychPaskow && o2.drewno.ilosc >= iloscPotrzebnegoDrewna)
                {
                    o2.lozko.ilosc += iloscWytwarzanychPrzedmiotow;
                    o2.welna.ilosc -= iloscPotrzebnejWelny;
                    o2.skorzanyPasek.ilosc -= iloscPotrzebnychSkorzanychPaskow;
                    o2.drewno.ilosc -= iloscPotrzebnegoDrewna;
                    pictureBoxStworzonyPrzedmiot.BackgroundImage = o2.lozko.obrazek;
                    MessageBox.Show("Wytworzyłeś " + iloscWytwarzanychPrzedmiotow + " " + o2.lozko.nazwa);
                }
                else
                {
                    MessageBox.Show("Niewystarczająca ilość materiałów!");
                }
            }
        }

        private void pictureBoxSlot1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot2_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot2.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot3.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot4_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot4.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot5_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot5.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot6_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot6.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot7_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot7.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot8_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot8.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSlot9_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxSlot9_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxSlot9.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxSkora_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSkora.DoDragDrop(pictureBoxSkora.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBoxKamien_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxKamien.DoDragDrop(pictureBoxKamien.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBoxDrewno_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDrewno.DoDragDrop(pictureBoxDrewno.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBoxZelazo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxZelazo.DoDragDrop(pictureBoxZelazo.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxObsydian_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxObsydian.DoDragDrop(pictureBoxObsydian.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxRudaZelaza_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRudaZelaza.DoDragDrop(pictureBoxRudaZelaza.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxRudaObsydianu_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRudaObsydianu.DoDragDrop(pictureBoxRudaObsydianu.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxWelna_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxWelna.DoDragDrop(pictureBoxWelna.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxKawalekDrewna_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxKawalekDrewna.DoDragDrop(pictureBoxKawalekDrewna.BackgroundImage, DragDropEffects.Copy);
        }

        private void PictureBoxSkorzanyPasek_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSkorzanyPasek.DoDragDrop(pictureBoxSkorzanyPasek.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBoxSlot1_Click(object sender, EventArgs e)
        {
            pictureBoxSlot1.BackgroundImage = null;
        }

        private void pictureBoxSlot2_Click(object sender, EventArgs e)
        {
            pictureBoxSlot2.BackgroundImage = null;
        }

        private void pictureBoxSlot3_Click(object sender, EventArgs e)
        {
            pictureBoxSlot3.BackgroundImage = null;
        }

        private void pictureBoxSlot4_Click(object sender, EventArgs e)
        {
            pictureBoxSlot4.BackgroundImage = null;
        }

        private void pictureBoxSlot5_Click(object sender, EventArgs e)
        {
            pictureBoxSlot5.BackgroundImage = null;
        }

        private void pictureBoxSlot6_Click(object sender, EventArgs e)
        {
            pictureBoxSlot6.BackgroundImage = null;
        }

        private void pictureBoxSlot7_Click(object sender, EventArgs e)
        {
            pictureBoxSlot7.BackgroundImage = null;
        }

        private void pictureBoxSlot8_Click(object sender, EventArgs e)
        {
            pictureBoxSlot8.BackgroundImage = null;
        }

        private void pictureBoxSlot9_Click(object sender, EventArgs e)
        {
            pictureBoxSlot9.BackgroundImage = null;
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void WyczyscSloty()
        {
            foreach (var item in sloty)
            {
                item.BackgroundImage = null;
            }

            pictureBoxStworzonyPrzedmiot.BackgroundImage = null;
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            WyczyscSloty();
        }

        private void textBoxIlosc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxKowadlo.Focus();
            }
        }

        private void PictureBoxStworzonyPrzedmiot_Click(object sender, EventArgs e)
        {
            pictureBoxStworzonyPrzedmiot.BackgroundImage = null;
        }
    }
}
