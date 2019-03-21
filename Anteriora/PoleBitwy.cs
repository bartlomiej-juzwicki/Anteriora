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
        #region Points
        Point A1 = new Point(49, 49);
        Point A2 = new Point(145, 49);
        Point A3 = new Point(241, 49);
        Point A4 = new Point(337, 49);
        Point A5 = new Point(433, 49);
        Point A6 = new Point(529, 49);
        Point A7 = new Point(625, 49);
        Point A8 = new Point(721, 49);
        Point A9 = new Point(817, 49);

        Point B1 = new Point(49, 145);
        Point B2 = new Point(145, 145);
        Point B3 = new Point(241, 145);
        Point B4 = new Point(337, 145);
        Point B5 = new Point(433, 145);
        Point B6 = new Point(529, 145);
        Point B7 = new Point(625, 145);
        Point B8 = new Point(721, 145);
        Point B9 = new Point(817, 145);

        Point C1 = new Point(49, 241);
        Point C2 = new Point(145, 241);
        Point C3 = new Point(241, 241);
        Point C4 = new Point(337, 241);
        Point C5 = new Point(433, 241);
        Point C6 = new Point(529, 241);
        Point C7 = new Point(625, 241);
        Point C8 = new Point(721, 241);
        Point C9 = new Point(817, 241);

        Point D1 = new Point(49, 337);
        Point D2 = new Point(145, 337);
        Point D3 = new Point(241, 337);
        Point D4 = new Point(337, 337);
        Point D5 = new Point(433, 337);
        Point D6 = new Point(529, 337);
        Point D7 = new Point(625, 337);
        Point D8 = new Point(721, 337);
        Point D9 = new Point(817, 337);

        Point E1 = new Point(49, 433);
        Point E2 = new Point(145, 433);
        Point E3 = new Point(241, 433);
        Point E4 = new Point(337, 433);
        Point E5 = new Point(433, 433);
        Point E6 = new Point(529, 433);
        Point E7 = new Point(625, 433);
        Point E8 = new Point(721, 433);
        Point E9 = new Point(817, 433);

        #endregion  

        List<Button> buttons = new List<Button>();
        List<JednostkiGracza> wojska = new List<JednostkiGracza>();
        List<Wrogowie> wrogowie = new List<Wrogowie>();

        Osada o;
        Mapa o2;
        public int rundaTwoja = 1;
        public int rundaPrzeciwnika;
        public double ktoraMapa;

        public PoleBitwy(Osada c, Mapa c2, double numerMapy, int iloscPrzeciwnik1, int iloscPrzeciwnik2, int iloscPrzeciwnik3, string tlo)
        {
            o = c;
            o2 = c2;
            InitializeComponent();

            ktoraMapa = numerMapy;

            var obrazek = Properties.Resources.ResourceManager.GetObject(tlo);
            this.BackgroundImage = (Image)obrazek;


            if (o.wojownik.ilosc > 0)
            {
                o.wojownik.ObliczAtakJednostki();
                o.wojownik.ObliczPZJednostki();
                o.wojownik.stalePZ = o.wojownik.PZ;
                o.wojownik.ObliczCalkowitePZ();
                o.wojownik.pictureBox = pictureBoxJednostka1;
                o.wojownik.pictureBox.Visible = true;
                o.wojownik.progressBarPZ = progressBarJednostka1;
                o.wojownik.labelPZ = labelJednostka1PZ;
                o.wojownik.progressBarPZ.Maximum = o.wojownik.calkowitePZ;
                wojska.Add(o.wojownik);
            }
            else
            {
                pictureBoxJednostka1.Visible = false;
            }

            if (o.lucznik2.ilosc > 0)
            {
                o.lucznik2.ObliczAtakJednostki();
                o.lucznik2.ObliczPZJednostki();
                o.lucznik2.stalePZ = o.lucznik2.PZ;
                o.lucznik2.ObliczCalkowitePZ();
                o.lucznik2.pictureBox = pictureBoxJednostka2;
                o.lucznik2.pictureBox.Visible = true;
                o.lucznik2.progressBarPZ = progressBarJednostka2;
                o.lucznik2.labelPZ = labelJednostka2PZ;
                o.lucznik2.progressBarPZ.Maximum = o.lucznik2.calkowitePZ;
                wojska.Add(o.lucznik2);
            }
            else
            {
                pictureBoxJednostka2.Visible = false;
            }

            if (o.wlocznik.ilosc > 0)
            {
                o.wlocznik.ObliczAtakJednostki();
                o.wlocznik.ObliczPZJednostki();
                o.wlocznik.stalePZ = o.wlocznik.PZ;
                o.wlocznik.ObliczCalkowitePZ();
                o.wlocznik.pictureBox = pictureBoxJednostka3;
                o.wlocznik.pictureBox.Visible = true;
                o.wlocznik.progressBarPZ = progressBarJednostka3;
                o.wlocznik.labelPZ = labelJednostka3PZ;
                o.wlocznik.progressBarPZ.Maximum = o.wlocznik.calkowitePZ;
                wojska.Add(o.wlocznik);

            }
            else
            {
                o.wlocznik.pictureBox.Visible = false;
            }

            #region widmo
            o.juzek.pictureBox = pictureBoxJuzek;
            o.juzek.odlegloscAtak = 0;
            o.juzek.odlegloscRuch = 0;
            #endregion

            if (ktoraMapa == 1.1)
            {
                o.nietoperzDuzy.ilosc = iloscPrzeciwnik1;
                o.nietoperzDuzy.pictureBox = pictureBoxPrzeciwnik1;
                o.nietoperzDuzy.pictureBox.Image = Properties.Resources.nietoperzduzylewo;
                o.nietoperzDuzy.pictureBox.Visible = true;
                o.nietoperzDuzy.progressBarPZ = progressBarPrzeciwnik1;
                o.nietoperzDuzy.stalePZ = o.nietoperzDuzy.PZ;
                o.nietoperzDuzy.labelPZ = labelPrzeciwnik1PZ;
                o.nietoperzDuzy.ObliczCalkowitePZ();
                o.nietoperzDuzy.progressBarPZ.Maximum = o.nietoperzDuzy.calkowitePZ;

                o.nietoperzMaly.ilosc = iloscPrzeciwnik2;
                o.nietoperzMaly.pictureBox = pictureBoxPrzeciwnik2;
                o.nietoperzMaly.pictureBox.Image = Properties.Resources.nietoperzmalylewo;
                o.nietoperzMaly.pictureBox.Visible = true;
                o.nietoperzMaly.progressBarPZ = progressBarPrzeciwnik2;
                o.nietoperzMaly.labelPZ = labelPrzeciwnik2PZ;
                o.nietoperzMaly.ObliczCalkowitePZ();
                o.nietoperzMaly.progressBarPZ.Maximum = o.nietoperzMaly.calkowitePZ;

                wrogowie.Add(o.nietoperzDuzy);
                wrogowie.Add(o.nietoperzMaly);
            }
            else if (ktoraMapa == 1.2)
            {
                o.goblin.ilosc = iloscPrzeciwnik1;
                o.goblin.pictureBox = pictureBoxPrzeciwnik1;
                o.goblin.pictureBox.Image = Properties.Resources.goblinlewo;
                o.goblin.pictureBox.Visible = true;
                o.goblin.progressBarPZ = progressBarPrzeciwnik1;
                o.goblin.labelPZ = labelPrzeciwnik1PZ;
                o.goblin.ObliczCalkowitePZ();
                o.goblin.progressBarPZ.Maximum = o.goblin.calkowitePZ;

                o.nietoperzDuzy.ilosc = iloscPrzeciwnik2;
                o.nietoperzDuzy.pictureBox = pictureBoxPrzeciwnik2;
                o.nietoperzDuzy.pictureBox.Image = Properties.Resources.nietoperzduzylewo;
                o.nietoperzDuzy.pictureBox.Visible = true;
                o.nietoperzDuzy.progressBarPZ = progressBarPrzeciwnik2;
                o.nietoperzDuzy.labelPZ = labelPrzeciwnik2PZ;
                o.nietoperzDuzy.ObliczCalkowitePZ();
                o.nietoperzDuzy.progressBarPZ.Maximum = o.nietoperzDuzy.calkowitePZ;

                wrogowie.Add(o.goblin);
                wrogowie.Add(o.nietoperzDuzy);
            }
            else if (ktoraMapa == 1.3)
            {
                o.goblin.ilosc = iloscPrzeciwnik1;
                o.goblin.pictureBox = pictureBoxPrzeciwnik1;
                o.goblin.pictureBox.Image = Properties.Resources.goblinlewo;
                o.goblin.pictureBox.Visible = true;
                o.goblin.progressBarPZ = progressBarPrzeciwnik1;
                o.goblin.labelPZ = labelPrzeciwnik1PZ;
                o.goblin.ObliczCalkowitePZ();
                o.goblin.progressBarPZ.Maximum = o.goblin.calkowitePZ;

                o.goblin2.ilosc = iloscPrzeciwnik2;
                o.goblin2.pictureBox = pictureBoxPrzeciwnik2;
                o.goblin2.pictureBox.Image = Properties.Resources.goblinlewo;
                o.goblin2.pictureBox.Visible = true;
                o.goblin2.progressBarPZ = progressBarPrzeciwnik2;
                o.goblin2.labelPZ = labelPrzeciwnik2PZ;
                o.goblin2.ObliczCalkowitePZ();
                o.goblin2.progressBarPZ.Maximum = o.goblin2.calkowitePZ;

                o.ork.ilosc = iloscPrzeciwnik3;
                o.ork.pictureBox = pictureBoxPrzeciwnik3;
                o.ork.pictureBox.Image = Properties.Resources.orklewo;
                o.ork.pictureBox.Visible = true;
                o.ork.progressBarPZ = progressBarPrzeciwnik3;
                o.ork.labelPZ = labelPrzeciwnik3PZ;
                o.ork.ObliczCalkowitePZ();
                o.ork.progressBarPZ.Maximum = o.ork.calkowitePZ;

                wrogowie.Add(o.goblin);
                wrogowie.Add(o.goblin2);
                wrogowie.Add(o.ork);
            }
            else if (ktoraMapa == 2.1)
            {
                o.nietoperzDuzy.ilosc = iloscPrzeciwnik1;
                o.nietoperzDuzy.pictureBox = pictureBoxPrzeciwnik1;
                o.nietoperzDuzy.pictureBox.Image = Properties.Resources.nietoperzduzylewo;
                o.nietoperzDuzy.pictureBox.Visible = true;
                o.nietoperzDuzy.progressBarPZ = progressBarPrzeciwnik1;
                o.nietoperzDuzy.labelPZ = labelPrzeciwnik1PZ;
                o.nietoperzDuzy.ObliczCalkowitePZ();
                o.nietoperzDuzy.progressBarPZ.Maximum = o.nietoperzDuzy.calkowitePZ;

                o.nietoperzMaly.ilosc = iloscPrzeciwnik2;
                o.nietoperzMaly.pictureBox = pictureBoxPrzeciwnik2;
                o.nietoperzMaly.pictureBox.Image = Properties.Resources.nietoperzmalylewo;
                o.nietoperzMaly.pictureBox.Visible = true;
                o.nietoperzMaly.progressBarPZ = progressBarPrzeciwnik2;
                o.nietoperzMaly.labelPZ = labelPrzeciwnik2PZ;
                o.nietoperzMaly.ObliczCalkowitePZ();
                o.nietoperzMaly.progressBarPZ.Maximum = o.nietoperzMaly.calkowitePZ;

                o.robak.ilosc = iloscPrzeciwnik3;
                o.robak.pictureBox = pictureBoxPrzeciwnik3;
                o.robak.pictureBox.Image = Properties.Resources.robaklewo;
                o.robak.pictureBox.Visible = true;
                o.robak.progressBarPZ = progressBarPrzeciwnik3;
                o.robak.labelPZ = labelPrzeciwnik3PZ;
                o.robak.ObliczCalkowitePZ();
                o.robak.progressBarPZ.Maximum = o.robak.calkowitePZ;

                wrogowie.Add(o.nietoperzDuzy);
                wrogowie.Add(o.nietoperzMaly);
                wrogowie.Add(o.robak);


            }
            else if (ktoraMapa == 2.2)
            {
                o.wazOgnisty.ilosc = iloscPrzeciwnik1;
                o.wazOgnisty.pictureBox = pictureBoxPrzeciwnik1;
                o.wazOgnisty.pictureBox.Image = Properties.Resources.waz2lewo;
                o.wazOgnisty.pictureBox.Visible = true;
                o.wazOgnisty.progressBarPZ = progressBarPrzeciwnik1;
                o.wazOgnisty.labelPZ = labelPrzeciwnik1PZ;
                o.wazOgnisty.ObliczCalkowitePZ();
                o.wazOgnisty.progressBarPZ.Maximum = o.wazOgnisty.calkowitePZ;

                o.wazJadowity.ilosc = iloscPrzeciwnik2;
                o.wazJadowity.pictureBox = pictureBoxPrzeciwnik2;
                o.wazJadowity.pictureBox.Image = Properties.Resources.waz1lewo;
                o.wazJadowity.pictureBox.Visible = true;
                o.wazJadowity.progressBarPZ = progressBarPrzeciwnik2;
                o.wazJadowity.labelPZ = labelPrzeciwnik2PZ;
                o.wazJadowity.ObliczCalkowitePZ();
                o.wazJadowity.progressBarPZ.Maximum = o.wazJadowity.calkowitePZ;

                wrogowie.Add(o.wazOgnisty);
                wrogowie.Add(o.wazJadowity);

                buttonA8.Visible = false;
                buttonA9.Visible = false;
                buttonB8.Visible = false;
                buttonB9.Visible = false;
                buttonC8.Visible = false;
                buttonC9.Visible = false;
                buttonD8.Visible = false;
                buttonD9.Visible = false;
                buttonE8.Visible = false;
                buttonE9.Visible = false;

            }


            #region wrzucenie przycisków do listy przycisków

            buttons.Add(buttonA1);
            buttons.Add(buttonA2);
            buttons.Add(buttonA3);
            buttons.Add(buttonA4);
            buttons.Add(buttonA5);
            buttons.Add(buttonA6);
            buttons.Add(buttonA7);
            buttons.Add(buttonA8);
            buttons.Add(buttonA9);

            buttons.Add(buttonB1);
            buttons.Add(buttonB2);
            buttons.Add(buttonB3);
            buttons.Add(buttonB4);
            buttons.Add(buttonB5);
            buttons.Add(buttonB6);
            buttons.Add(buttonB7);
            buttons.Add(buttonB8);
            buttons.Add(buttonB9);

            buttons.Add(buttonC1);
            buttons.Add(buttonC2);
            buttons.Add(buttonC3);
            buttons.Add(buttonC4);
            buttons.Add(buttonC5);
            buttons.Add(buttonC6);
            buttons.Add(buttonC7);
            buttons.Add(buttonC8);
            buttons.Add(buttonC9);

            buttons.Add(buttonD1);
            buttons.Add(buttonD2);
            buttons.Add(buttonD3);
            buttons.Add(buttonD4);
            buttons.Add(buttonD5);
            buttons.Add(buttonD6);
            buttons.Add(buttonD7);
            buttons.Add(buttonD8);
            buttons.Add(buttonD9);

            buttons.Add(buttonE1);
            buttons.Add(buttonE2);
            buttons.Add(buttonE3);
            buttons.Add(buttonE4);
            buttons.Add(buttonE5);
            buttons.Add(buttonE6);
            buttons.Add(buttonE7);
            buttons.Add(buttonE8);
            buttons.Add(buttonE9);
            #endregion  

            timerRunda.Start();
        }

        #region Kwadraty i ruch jednostek

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA1, A1, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA1, A1, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA1, A1, o.wlocznik);
            }

        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA2, A2, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA2, A2, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA2, A2, o.wlocznik);
            }

        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA3, A3, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA3, A3, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA3, A3, o.wlocznik);
            }

        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA4, A4, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA4, A4, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA4, A4, o.wlocznik);
            }

        }

        private void buttonA5_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA5, A5, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA5, A5, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA5, A5, o.wlocznik);
            }

        }

        private void buttonA6_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA6, A6, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA6, A6, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA6, A6, o.wlocznik);
            }

        }

        private void buttonA7_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA7, A7, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA7, A7, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA7, A7, o.wlocznik);
            }

        }

        private void buttonA8_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA8, A8, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA8, A8, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA8, A8, o.wlocznik);
            }

        }

        private void buttonA9_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonA9, A9, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonA9, A9, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonA9, A9, o.wlocznik);
            }

        }

        private void buttonB9_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB9, B9, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB9, B9, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB9, B9, o.wlocznik);
            }

        }

        private void buttonB8_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB8, B8, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB8, B8, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB8, B8, o.wlocznik);
            }

        }

        private void buttonB7_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB7, B7, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB7, B7, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB7, B7, o.wlocznik);
            }

        }

        private void buttonB6_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB6, B6, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB6, B6, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB6, B6, o.wlocznik);
            }

        }

        private void buttonB5_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB5, B5, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB5, B5, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB5, B5, o.wlocznik);
            }

        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB4, B4, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB4, B4, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB4, B4, o.wlocznik);
            }

        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB3, B3, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB3, B3, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB3, B3, o.wlocznik);
            }

        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB2, B2, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB2, B2, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB2, B2, o.wlocznik);
            }

        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonB1, B1, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonB1, B1, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonB1, B1, o.wlocznik);
            }

        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC1, C1, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC1, C1, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC1, C1, o.wlocznik);
            }

        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC2, C2, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC2, C2, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC2, C2, o.wlocznik);
            }

        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC3, C3, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC3, C3, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC3, C3, o.wlocznik);
            }

        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC4, C4, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC4, C4, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC4, C4, o.wlocznik);
            }

        }

        private void buttonC5_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC5, C5, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC5, C5, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC5, C5, o.wlocznik);
            }

        }

        private void buttonC6_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC6, C6, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC6, C6, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC6, C6, o.wlocznik);
            }

        }

        private void buttonC7_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC7, C7, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC7, C7, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC7, C7, o.wlocznik);
            }

        }

        private void buttonC8_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC8, C8, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC8, C8, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC8, C8, o.wlocznik);
            }

        }

        private void buttonC9_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonC9, C9, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonC9, C9, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonC9, C9, o.wlocznik);
            }

        }

        private void buttonD1_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD1, D1, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD1, D1, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD1, D1, o.wlocznik);
            }

        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD2, D2, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD2, D2, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD2, D2, o.wlocznik);
            }

        }

        private void buttonD3_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD3, D3, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD3, D3, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD3, D3, o.wlocznik);
            }

        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD4, D4, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD4, D4, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD4, D4, o.wlocznik);
            }

        }

        private void buttonD5_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD5, D5, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD5, D5, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD5, D5, o.wlocznik);
            }

        }

        private void buttonD6_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD6, D6, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD6, D6, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD6, D6, o.wlocznik);
            }

        }

        private void buttonD7_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD7, D7, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD7, D7, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD7, D7, o.wlocznik);
            }

        }

        private void buttonD8_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD8, D8, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD8, D8, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD8, D8, o.wlocznik);
            }

        }

        private void buttonD9_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonD9, D9, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonD9, D9, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonD9, D9, o.wlocznik);
            }

        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE1, E1, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE1, E1, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE1, E1, o.wlocznik);
            }

        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE2, E2, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE2, E2, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE2, E2, o.wlocznik);
            }

        }

        private void buttonE3_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE3, E3, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE3, E3, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE3, E3, o.wlocznik);
            }

        }

        private void buttonE4_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE4, E4, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE4, E4, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE4, E4, o.wlocznik);
            }

        }

        private void buttonE5_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE5, E5, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE5, E5, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE5, E5, o.wlocznik);
            }

        }

        private void buttonE6_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE6, E6, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE6, E6, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE6, E6, o.wlocznik);
            }

        }

        private void buttonE7_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE7, E7, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE7, E7, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE7, E7, o.wlocznik);
            }

        }

        private void buttonE8_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE8, E8, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE8, E8, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE8, E8, o.wlocznik);
            }

        }

        private void buttonE9_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                RuchMalyZasieg(buttonE9, E9, o.wojownik);
            }
            else if (rundaTwoja == 2)
            {
                RuchMalyZasieg(buttonE9, E9, o.lucznik2);
            }
            else if (rundaTwoja == 3)
            {
                RuchMalyZasieg(buttonE9, E9, o.wlocznik);
            }

        }

        #endregion

        #region PictureBox przeciwników
        private void pictureBoxPrzeciwnik1_Click(object sender, EventArgs e)
        {
            if (ktoraMapa == 1.1)
            {
                SprawdzCzyMoznaZaatakowac(o.nietoperzDuzy);
            }
            else if (ktoraMapa == 1.2)
            {
                SprawdzCzyMoznaZaatakowac(o.goblin);
            }
            else if (ktoraMapa == 1.3)
            {
                SprawdzCzyMoznaZaatakowac(o.goblin);
            }
            else if (ktoraMapa == 2.1)
            {
                SprawdzCzyMoznaZaatakowac(o.nietoperzDuzy);
            }
            else if (ktoraMapa == 2.2)
            {
                SprawdzCzyMoznaZaatakowac(o.wazOgnisty);
            }

        }

        private void pictureBoxPrzeciwnik2_Click(object sender, EventArgs e)
        {
            if (ktoraMapa == 1.1)
            {
                SprawdzCzyMoznaZaatakowac(o.nietoperzMaly);
            }
            else if (ktoraMapa == 1.2)
            {
                SprawdzCzyMoznaZaatakowac(o.nietoperzDuzy);
            }
            else if (ktoraMapa == 1.3)
            {
                SprawdzCzyMoznaZaatakowac(o.goblin2);
            }
            else if (ktoraMapa == 2.1)
            {
                SprawdzCzyMoznaZaatakowac(o.nietoperzMaly);
            }
            else if (ktoraMapa == 2.2)
            {
                SprawdzCzyMoznaZaatakowac(o.wazJadowity);
            }
        }

        private void pictureBoxPrzeciwnik3_Click(object sender, EventArgs e)
        {
            if (ktoraMapa == 1.1)
            {

            }
            else if (ktoraMapa == 1.2)
            {

            }
            else if (ktoraMapa == 1.3)
            {
                SprawdzCzyMoznaZaatakowac(o.ork);
            }
            else if (ktoraMapa == 2.1)
            {
                SprawdzCzyMoznaZaatakowac(o.robak);
            }
            else if (ktoraMapa == 2.2)
            {

            }
        }

        #endregion

        #region Timery

        private void timerRunda_Tick(object sender, EventArgs e)
        {
            labelJednostka1.Text = (o.wojownik.nazwa + "(" + o.wojownik.ilosc + ")").ToString();
            labelJednostka1PZ.Text = o.wojownik.calkowitePZ.ToString();
            progressBarJednostka1.Value = o.wojownik.calkowitePZ;
            labelJednostka2.Text = (o.lucznik2.nazwa + "(" + o.lucznik2.ilosc + ")").ToString();
            labelJednostka2PZ.Text = o.lucznik2.calkowitePZ.ToString();
            progressBarJednostka2.Value = o.lucznik2.calkowitePZ;
            labelJednostka3.Text = (o.wlocznik.nazwa + "(" + o.wlocznik.ilosc + ")").ToString();
            labelJednostka3PZ.Text = o.wlocznik.calkowitePZ.ToString();
            progressBarJednostka3.Value = o.wlocznik.calkowitePZ;

            if (ktoraMapa == 1.1)
            {
                labelPrzeciwnik1.Text = (o.nietoperzDuzy.nazwa + "(" + o.nietoperzDuzy.ilosc + ")").ToString();
                labelPrzeciwnik1PZ.Text = o.nietoperzDuzy.calkowitePZ.ToString();
                progressBarPrzeciwnik1.Value = o.nietoperzDuzy.calkowitePZ;
                labelPrzeciwnik2.Text = (o.nietoperzMaly.nazwa + "(" + o.nietoperzMaly.ilosc + ")").ToString();
                labelPrzeciwnik2PZ.Text = o.nietoperzMaly.calkowitePZ.ToString();
                progressBarPrzeciwnik2.Value = o.nietoperzMaly.calkowitePZ;
            }
            else if (ktoraMapa == 1.2)
            {
                labelPrzeciwnik1.Text = (o.goblin.nazwa + "(" + o.goblin.ilosc + ")").ToString();
                labelPrzeciwnik1PZ.Text = o.goblin.calkowitePZ.ToString();
                progressBarPrzeciwnik1.Value = o.goblin.calkowitePZ;
                labelPrzeciwnik2.Text = (o.nietoperzDuzy.nazwa + "(" + o.nietoperzDuzy.ilosc + ")").ToString();
                labelPrzeciwnik2PZ.Text = o.nietoperzDuzy.calkowitePZ.ToString();
                progressBarPrzeciwnik2.Value = o.nietoperzDuzy.calkowitePZ;

            }
            else if (ktoraMapa == 1.3)
            {
                labelPrzeciwnik1.Text = (o.goblin.nazwa + "(" + o.goblin.ilosc + ")").ToString();
                labelPrzeciwnik1PZ.Text = o.goblin.calkowitePZ.ToString();
                progressBarPrzeciwnik1.Value = o.goblin.calkowitePZ;
                labelPrzeciwnik2.Text = (o.goblin2.nazwa + "(" + o.goblin2.ilosc + ")").ToString();
                labelPrzeciwnik2PZ.Text = o.goblin2.calkowitePZ.ToString();
                progressBarPrzeciwnik2.Value = o.goblin2.calkowitePZ;
                labelPrzeciwnik3.Text = (o.ork.nazwa + "(" + o.ork.ilosc + ")").ToString();
                labelPrzeciwnik3PZ.Text = o.ork.calkowitePZ.ToString();
                progressBarPrzeciwnik3.Value = o.ork.calkowitePZ;
            }
            else if (ktoraMapa == 2.1)
            {
                labelPrzeciwnik1.Text = (o.nietoperzDuzy.nazwa + "(" + o.nietoperzDuzy.ilosc + ")").ToString();
                labelPrzeciwnik1PZ.Text = o.nietoperzDuzy.calkowitePZ.ToString();
                progressBarPrzeciwnik1.Value = o.nietoperzDuzy.calkowitePZ;
                labelPrzeciwnik2.Text = (o.nietoperzMaly.nazwa + "(" + o.nietoperzMaly.ilosc + ")").ToString();
                labelPrzeciwnik2PZ.Text = o.nietoperzMaly.calkowitePZ.ToString();
                progressBarPrzeciwnik2.Value = o.nietoperzMaly.calkowitePZ;
                labelPrzeciwnik3.Text = (o.robak.nazwa + "(" + o.robak.ilosc + ")").ToString();
                labelPrzeciwnik3PZ.Text = o.robak.calkowitePZ.ToString();
                progressBarPrzeciwnik3.Value = o.robak.calkowitePZ;
            }
            else if (ktoraMapa == 2.2)
            {
                labelPrzeciwnik1.Text = (o.wazOgnisty.nazwa + "(" + o.wazOgnisty.ilosc + ")").ToString();
                labelPrzeciwnik1PZ.Text = o.wazOgnisty.calkowitePZ.ToString();
                progressBarPrzeciwnik1.Value = o.wazOgnisty.calkowitePZ;
                labelPrzeciwnik2.Text = (o.wazJadowity.nazwa + "(" + o.wazJadowity.ilosc + ")").ToString();
                labelPrzeciwnik2PZ.Text = o.wazJadowity.calkowitePZ.ToString();
                progressBarPrzeciwnik2.Value = o.wazJadowity.calkowitePZ;
            }


            if (pictureBoxJednostka1.Visible == false && pictureBoxJednostka2.Visible == false && pictureBoxJednostka3.Visible == false)
            {
                wojska.Clear();

                wojska.Add(o.wojownik);
                wojska.Add(o.lucznik2);
                wojska.Add(o.wlocznik);

                foreach (var item in wojska)
                {
                    item.PZ = item.stalePZ;
                }
                foreach (var item in wrogowie)
                {
                    item.PZ = item.stalePZ;
                }

                wojska.Clear();

                timerRunda.Stop();

                if (ktoraMapa == 1.1 || ktoraMapa == 1.2 || ktoraMapa == 1.3)
                {
                    o.osadaGoblinow.akcjaWrog = true;
                    o.timerWojna.Start();
                }
                else if (ktoraMapa == 2.1 || ktoraMapa == 2.2)
                {
                    o.jaskiniaWezy.akcjaWrog = true;
                    o.timerWojna.Start();
                }

                MessageBox.Show("Porażka!");
                this.Close();

            }
            else if (pictureBoxPrzeciwnik1.Visible == false && pictureBoxPrzeciwnik2.Visible == false && pictureBoxPrzeciwnik3.Visible == false)
            {
                wojska.Clear();

                wojska.Add(o.wojownik);
                wojska.Add(o.lucznik2);
                wojska.Add(o.wlocznik);


                foreach (var item in wojska)
                {
                    item.PZ = item.stalePZ;
                }

                foreach (var item2 in wrogowie)
                {
                    item2.PZ = item2.stalePZ;
                }

                if (ktoraMapa == 1.1)
                {
                    o.osadaGoblinow.enablePoziom1 = false;
                    o.osadaGoblinow.enablePoziom2 = true;
                    if (o.osadaGoblinow.licznikZwiadowca == 1)
                    {
                        o.osadaGoblinow.licznikZwiadowca = 2;
                    }

                }
                else if (ktoraMapa == 1.2)
                {
                    o.osadaGoblinow.enablePoziom2 = false;
                    o.osadaGoblinow.enablePoziom3 = true;
                    if (o.osadaGoblinow.licznikZwiadowca == 2)
                    {
                        o.osadaGoblinow.licznikZwiadowca = 3;
                    }
                }
                else if (ktoraMapa == 1.3)
                {
                    o.osadaGoblinow.enablePoziom3 = false;
                    if (o.osadaGoblinow.licznikZwiadowca == 3)
                    {
                        o.osadaGoblinow.licznikZwiadowca = 4;
                    }

                    o2.pictureBoxJaskiniaWezy.Visible = true;
                }
                else if (ktoraMapa == 2.1)
                {
                    o.jaskiniaWezy.enablePoziom1 = false;
                    o.jaskiniaWezy.enablePoziom2 = true;
                    if (o.jaskiniaWezy.licznikZwiadowca == 1)
                    {
                        o.osadaGoblinow.licznikZwiadowca = 2;
                    }
                }
                else if (ktoraMapa == 2.2)
                {
                    o.jaskiniaWezy.enablePoziom2 = false;
                    if (o.jaskiniaWezy.licznikZwiadowca == 2)
                    {
                        o.jaskiniaWezy.licznikZwiadowca = 3;
                    }
                }

                wojska.Clear();

                timerRunda.Stop();

                MessageBox.Show("Zwycięstwo!");



                this.Close();
            }

            if (rundaTwoja == 1 && pictureBoxJednostka1.Visible)
            {
                pictureBoxPrzeciwnik1.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.Transparent;
                pictureBoxJednostka3.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.LightGoldenrodYellow;
                SprawdzZasieguRuchu(o.wojownik);
                SprawdzanieZasieguAtaku(o.wojownik);
            }
            else if (rundaTwoja == 1 && pictureBoxJednostka1.Visible == false)
            {
                rundaTwoja++;
            }
            else if (rundaTwoja == 2 && pictureBoxJednostka2.Visible)
            {
                pictureBoxPrzeciwnik1.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.Transparent;
                pictureBoxJednostka3.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.LightGoldenrodYellow;
                SprawdzZasieguRuchu(o.lucznik2);
                SprawdzanieZasieguAtaku(o.lucznik2);
            }
            else if (rundaTwoja == 2 && pictureBoxJednostka2.Visible == false)
            {
                rundaTwoja++;
            }
            else if (rundaTwoja == 3 && pictureBoxJednostka3.Visible)
            {
                pictureBoxPrzeciwnik1.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.Transparent;
                pictureBoxJednostka3.BackColor = Color.LightGoldenrodYellow;
                SprawdzZasieguRuchu(o.wlocznik);
                SprawdzanieZasieguAtaku(o.wlocznik);
            }
            else if (rundaTwoja == 3 && pictureBoxJednostka3.Visible == false)
            {
                rundaTwoja++;
            }
            else if (rundaTwoja == 4)
            {
                SprawdzZasieguRuchu(o.juzek);
                rundaPrzeciwnika = 1;
                rundaTwoja = 0;
            }

            if (rundaPrzeciwnika == 1 && pictureBoxPrzeciwnik1.Visible)
            {
                pictureBoxJednostka3.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik1.BackColor = Color.BlanchedAlmond;
                //
                if (ktoraMapa == 1.1)
                {
                    MechanikaPrzeciwnik(o.nietoperzDuzy);
                }
                else if (ktoraMapa == 1.2)
                {
                    MechanikaPrzeciwnik(o.goblin);
                }
                else if (ktoraMapa == 1.3)
                {
                    MechanikaPrzeciwnik(o.goblin);
                }
                else if (ktoraMapa == 2.1)
                {
                    MechanikaPrzeciwnik(o.nietoperzDuzy);
                }
                else if (ktoraMapa == 2.2)
                {
                    MechanikaPrzeciwnikówNieruchomychDystansowych(o.wazOgnisty);
                }

            }
            else if (rundaPrzeciwnika == 1 && pictureBoxPrzeciwnik1.Visible == false)
            {
                rundaPrzeciwnika++;
            }
            else if (rundaPrzeciwnika == 2 && pictureBoxPrzeciwnik2.Visible)
            {
                pictureBoxJednostka3.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.BlanchedAlmond;
                //
                if (ktoraMapa == 1.1)
                {
                    MechanikaPrzeciwnik(o.nietoperzMaly);
                }
                else if (ktoraMapa == 1.2)
                {
                    MechanikaPrzeciwnik(o.nietoperzDuzy);
                }
                else if (ktoraMapa == 1.3)
                {
                    MechanikaPrzeciwnik(o.goblin2);
                }
                else if (ktoraMapa == 2.1)
                {
                    MechanikaPrzeciwnik(o.nietoperzMaly);
                }
                else if (ktoraMapa == 2.2)
                {
                    MechanikaPrzeciwnikówNieruchomychDystansowych(o.wazJadowity);
                }
            }
            else if (rundaPrzeciwnika == 2 & pictureBoxPrzeciwnik2.Visible == false)
            {
                rundaPrzeciwnika++;
            }
            else if (rundaPrzeciwnika == 3 && pictureBoxPrzeciwnik3.Visible)
            {
                pictureBoxJednostka3.BackColor = Color.Transparent;
                pictureBoxJednostka2.BackColor = Color.Transparent;
                pictureBoxJednostka1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik1.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik2.BackColor = Color.Transparent;
                pictureBoxPrzeciwnik3.BackColor = Color.BlanchedAlmond;
                //
                if (ktoraMapa == 1.1)
                {

                }
                else if (ktoraMapa == 1.2)
                {

                }
                else if (ktoraMapa == 1.3)
                {
                    MechanikaPrzeciwnik(o.ork);
                }
                else if (ktoraMapa == 2.1)
                {
                    MechanikaPrzeciwnik(o.robak);
                }
                else if (ktoraMapa == 2.2)
                {

                }
            }
            else if (rundaPrzeciwnika == 3 & pictureBoxPrzeciwnik3.Visible == false)
            {
                rundaPrzeciwnika++;
            }
            else if (rundaPrzeciwnika == 4)
            {
                rundaTwoja = 1;
                rundaPrzeciwnika = 0;

            }
        }
        #endregion timery

        #region RuchMalyZasieg
        public void RuchMalyZasieg(Button button, Point point, JednostkiGracza jednostka)
        {
            if (jednostka.pictureBox.Location.X >= button.Location.X - jednostka.odlegloscRuch && jednostka.pictureBox.Location.X <= button.Location.X && jednostka.pictureBox.Location.Y == button.Location.Y)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekPrawo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.X <= button.Location.X + jednostka.odlegloscRuch && jednostka.pictureBox.Location.X >= button.Location.X && jednostka.pictureBox.Location.Y == button.Location.Y)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekLewo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= button.Location.Y - jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y <= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekDol);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= button.Location.Y + jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y >= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekGora);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= button.Location.Y - jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y <= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X - jednostka.odlegloscRuch)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekPrawo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= button.Location.Y - jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y <= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X + jednostka.odlegloscRuch)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekLewo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= button.Location.Y + jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y >= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X - jednostka.odlegloscRuch)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekPrawo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= button.Location.Y + jednostka.odlegloscRuch && jednostka.pictureBox.Location.Y >= button.Location.Y && jednostka.pictureBox.Location.X == button.Location.X + jednostka.odlegloscRuch)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekLewo);
                jednostka.pictureBox.Image = (Image)o;
                jednostka.pictureBox.Location = point;
                rundaTwoja++;
            }
            else
            {
                Cursor.Current = Cursors.No;
            }
        }
        #endregion

        #region AtakDalekiZasieg
        public void AtakDalekiZasieg(JednostkiGracza jednostka, Wrogowie wrog)
        {
            if ((jednostka.pictureBox.Location.X <= wrog.pictureBox.Location.X && jednostka.pictureBox.Location.X >= wrog.pictureBox.Location.X - jednostka.odlegloscAtak)
                && ((jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y - jednostka.odlegloscAtak) && (jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y + jednostka.odlegloscAtak)))
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekPrawo);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.X >= wrog.pictureBox.Location.X && wrog.pictureBox.Location.X + jednostka.odlegloscAtak >= jednostka.pictureBox.Location.X
                && ((jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y - jednostka.odlegloscAtak) && (jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y + jednostka.odlegloscAtak)))
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekLewo);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
        }
        #endregion

        #region AtakKrotkiZasieg
        public void ZaatakujNaKrotkiZasieg(JednostkiGracza jednostka, Wrogowie wrog)
        {
            if (jednostka.pictureBox.Location.X >= wrog.pictureBox.Location.X - jednostka.odlegloscAtak && jednostka.pictureBox.Location.X <= wrog.pictureBox.Location.X
                && jednostka.pictureBox.Location.Y == wrog.pictureBox.Location.Y)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekPrawo);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.X <= wrog.pictureBox.Location.X + jednostka.odlegloscAtak && jednostka.pictureBox.Location.X >= wrog.pictureBox.Location.X
                && jednostka.pictureBox.Location.Y == wrog.pictureBox.Location.Y)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekLewo);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y + jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y
                 && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekGora);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y - jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y
                 && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekDol);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y - jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y
                 && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X - jednostka.odlegloscAtak)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekDol);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y - jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y
                && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X + jednostka.odlegloscAtak)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekDol);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y + jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y
                && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X - jednostka.odlegloscAtak)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekGora);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
            else if (jednostka.pictureBox.Location.Y <= wrog.pictureBox.Location.Y + jednostka.odlegloscAtak && jednostka.pictureBox.Location.Y >= wrog.pictureBox.Location.Y
               && jednostka.pictureBox.Location.X == wrog.pictureBox.Location.X + jednostka.odlegloscAtak)
            {
                var o = Properties.Resources.ResourceManager.GetObject(jednostka.obrazekGora);
                jednostka.pictureBox.Image = (Image)o;
                wrog.pictureBox.BackColor = Color.DarkRed;
                ZadajObrazeniaPrzeciwnikowi(jednostka, wrog);
                rundaTwoja++;
            }
        }
        #endregion  

        #region SprawdzanieZasiegu
        public void SprawdzZasieguRuchu(JednostkiGracza jednostka)
        {
            foreach (var item in buttons)
            {
                if ((jednostka.pictureBox.Location.X >= (item.Location.X - (jednostka.odlegloscRuch)) && jednostka.pictureBox.Location.Y == item.Location.Y)
                    && (jednostka.pictureBox.Location.X <= (item.Location.X + (jednostka.odlegloscRuch)) && jednostka.pictureBox.Location.Y == item.Location.Y)
                    || (jednostka.pictureBox.Location.Y >= (item.Location.Y - (jednostka.odlegloscRuch)) && (jednostka.pictureBox.Location.X >= item.Location.X - jednostka.odlegloscRuch && jednostka.pictureBox.Location.X <= item.Location.X + jednostka.odlegloscRuch))   // || jednostka.pictureBox.Location.X == item.Location.X))
                    && (jednostka.pictureBox.Location.Y <= (item.Location.Y + (jednostka.odlegloscRuch)) && (jednostka.pictureBox.Location.X >= item.Location.X - jednostka.odlegloscRuch && jednostka.pictureBox.Location.X <= item.Location.X + jednostka.odlegloscRuch)))
                {
                    item.Image = Properties.Resources.iks;
                }
                else
                {
                    item.Image = null;
                }
            }
        }

        public void SprawdzanieZasieguAtaku(JednostkiGracza jednostka)
        {
            foreach (var item in buttons)
            {
                if ((jednostka.pictureBox.Location.X >= (item.Location.X - (jednostka.odlegloscAtak)) && jednostka.pictureBox.Location.Y == item.Location.Y)
                    && (jednostka.pictureBox.Location.X <= (item.Location.X + (jednostka.odlegloscAtak)) && jednostka.pictureBox.Location.Y == item.Location.Y)
                    || (jednostka.pictureBox.Location.Y >= (item.Location.Y - (jednostka.odlegloscAtak)) && (jednostka.pictureBox.Location.X >= item.Location.X - jednostka.odlegloscAtak && jednostka.pictureBox.Location.X <= item.Location.X + jednostka.odlegloscAtak))   // || jednostka.pictureBox.Location.X == item.Location.X))
                    && (jednostka.pictureBox.Location.Y <= (item.Location.Y + (jednostka.odlegloscAtak)) && (jednostka.pictureBox.Location.X >= item.Location.X - jednostka.odlegloscAtak && jednostka.pictureBox.Location.X <= item.Location.X + jednostka.odlegloscAtak)))    // || jednostka.pictureBox.Location.X == item.Location.X)))
                {
                    //item.BackColor = Color.LightPink;
                }
                else
                {
                    //item.BackColor = Color.Transparent;
                }
            }
        }

        #endregion

        #region Mechanika przeciwników
        public void MechanikaPrzeciwnik(Wrogowie wrog)
        {
            wojska.Clear();

            if (pictureBoxJednostka1.Visible)
            {
                wojska.Add(o.wojownik);
            }
            if (pictureBoxJednostka2.Visible)
            {
                wojska.Add(o.lucznik2);
            }
            if (pictureBoxJednostka3.Visible)
            {
                wojska.Add(o.wlocznik);
            }

            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.X == item.pictureBox.Location.X + wrog.odlegloscAtak && wrog.pictureBox.Location.Y == item.pictureBox.Location.Y)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekLewo);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.X == item.pictureBox.Location.X - wrog.odlegloscAtak && wrog.pictureBox.Location.Y == item.pictureBox.Location.Y)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekPrawo);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y + wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekGora);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y - wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekDol);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y + wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X + wrog.odlegloscAtak)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekGora);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y + wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X - wrog.odlegloscAtak)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekGora);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y - wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X + wrog.odlegloscAtak)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekDol);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y - wrog.odlegloscAtak && wrog.pictureBox.Location.X == item.pictureBox.Location.X - wrog.odlegloscAtak)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekDol);
                    wrog.pictureBox.Image = (Image)o;
                    item.pictureBox.BackColor = Color.DarkRed;
                    ZadajObrazeniaJednostce(wrog, item);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y && wrog.pictureBox.Location.X >= item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekLewo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X - wrog.odlegloscRuch, wrog.pictureBox.Location.Y);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y == item.pictureBox.Location.Y && wrog.pictureBox.Location.X <= item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekPrawo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X + wrog.odlegloscRuch, wrog.pictureBox.Location.Y);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y < item.pictureBox.Location.Y && wrog.pictureBox.Location.X == item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekDol);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X, wrog.pictureBox.Location.Y + wrog.odlegloscRuch);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y > item.pictureBox.Location.Y && wrog.pictureBox.Location.X == item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekGora);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X, wrog.pictureBox.Location.Y - wrog.odlegloscRuch);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y < item.pictureBox.Location.Y && wrog.pictureBox.Location.X > item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekLewo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X - wrog.odlegloscRuch, wrog.pictureBox.Location.Y + wrog.odlegloscRuch);
                    goto Koniec;
                }
            }
            foreach (var item in wojska)
            {

                if (wrog.pictureBox.Location.Y > item.pictureBox.Location.Y && wrog.pictureBox.Location.X > item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekLewo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X - wrog.odlegloscRuch, wrog.pictureBox.Location.Y - wrog.odlegloscRuch);
                    goto Koniec;
                }
            }

            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y < item.pictureBox.Location.Y && wrog.pictureBox.Location.X < item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekPrawo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X + wrog.odlegloscRuch, wrog.pictureBox.Location.Y + wrog.odlegloscRuch);
                    goto Koniec;
                }
            }

            foreach (var item in wojska)
            {
                if (wrog.pictureBox.Location.Y > item.pictureBox.Location.Y && wrog.pictureBox.Location.X < item.pictureBox.Location.X)
                {
                    var o = Properties.Resources.ResourceManager.GetObject(wrog.obrazekPrawo);
                    wrog.pictureBox.Image = (Image)o;
                    wrog.pictureBox.Location = new Point(wrog.pictureBox.Location.X + wrog.odlegloscRuch, wrog.pictureBox.Location.Y - wrog.odlegloscRuch);
                    goto Koniec;
                }
            }

        Koniec:
            rundaPrzeciwnika++;
        }

        #endregion

        public void ZadajObrazeniaPrzeciwnikowi(JednostkiMilitarne jednostka, Wrogowie wrog)
        {
            if (jednostka.ObliczCalkowityAtak() >= wrog.calkowitePZ)
            {
                wrog.pictureBox.Visible = false;
                wrog.ilosc = 0;
                wrog.PZ = 0;
                wrog.calkowitePZ = 0;
                wrog.progressBarPZ.ForeColor = Color.Black;
                wrog.progressBarPZ.Value = wrog.progressBarPZ.Maximum;
            }
            else
            {
                if (jednostka.ObliczCalkowityAtak() == wrog.PZ)
                {
                    if (wrog.ilosc == 1)
                    {
                        wrog.ilosc--;
                        wrog.pictureBox.Visible = false;
                        wrog.PZ = 0;
                        wrog.calkowitePZ = 0;
                        wrog.progressBarPZ.ForeColor = Color.Black;
                        wrog.progressBarPZ.Value = wrog.progressBarPZ.Maximum;
                    }
                    else
                    {
                        wrog.ilosc--;
                        wrog.PZ = wrog.stalePZ;
                        wrog.calkowitePZ -= jednostka.ObliczCalkowityAtak();
                    }
                }
                else if (jednostka.ObliczCalkowityAtak() > wrog.PZ)
                {
                    if (wrog.ilosc == 1)
                    {
                        wrog.ilosc--;
                        wrog.pictureBox.Visible = false;
                        wrog.PZ = 0;
                        wrog.calkowitePZ = 0;
                        wrog.progressBarPZ.ForeColor = Color.Black;
                        wrog.progressBarPZ.Value = wrog.progressBarPZ.Maximum;
                    }
                    else
                    {
                        int resztaPZ;
                        wrog.calkowitePZ -= jednostka.ObliczCalkowityAtak();
                        wrog.PZ -= jednostka.ObliczCalkowityAtak();

                        for (int i = 0; i < jednostka.ObliczCalkowityAtak(); i++)
                        {
                            if (wrog.PZ <= 0)
                            {
                                resztaPZ = wrog.PZ;
                                wrog.PZ = wrog.stalePZ + resztaPZ;
                            }
                            else if (wrog.PZ > 0)
                            {
                                wrog.ilosc -= i;
                                break;
                            }
                        }
                    }
                }
                else if (jednostka.ObliczCalkowityAtak() < wrog.PZ)
                {
                    wrog.PZ -= jednostka.ObliczCalkowityAtak();
                    wrog.calkowitePZ -= jednostka.ObliczCalkowityAtak();
                }
            }
        }

        public void ZadajObrazeniaJednostce(Wrogowie wrog, JednostkiMilitarne jednostka)
        {
            if (wrog.ObliczCalkowityAtak() >= jednostka.calkowitePZ)
            {
                jednostka.pictureBox.Visible = false;
                jednostka.ilosc = 0;
                jednostka.PZ = 0;
                jednostka.calkowitePZ = 0;
                jednostka.progressBarPZ.ForeColor = Color.Black;
                jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
            }
            else
            {
                if (wrog.ObliczCalkowityAtak() == jednostka.PZ)
                {
                    if (jednostka.ilosc == 1)
                    {
                        jednostka.ilosc--;
                        jednostka.pictureBox.Visible = false;
                        jednostka.PZ = 0;
                        jednostka.calkowitePZ = 0;
                        jednostka.progressBarPZ.ForeColor = Color.Black;
                        jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
                    }
                    else
                    {
                        jednostka.ilosc--;
                        jednostka.PZ = jednostka.stalePZ;
                        jednostka.calkowitePZ -= wrog.ObliczCalkowityAtak();
                    }
                }
                else if (wrog.ObliczCalkowityAtak() > jednostka.PZ)
                {
                    if (jednostka.ilosc == 1)
                    {
                        jednostka.ilosc--;
                        jednostka.pictureBox.Visible = false;
                        jednostka.PZ = 0;
                        jednostka.calkowitePZ = 0;
                        jednostka.progressBarPZ.ForeColor = Color.Black;
                        jednostka.progressBarPZ.Value = jednostka.progressBarPZ.Maximum;
                    }
                    else
                    {
                        int resztaPZ;

                        jednostka.calkowitePZ -= wrog.ObliczCalkowityAtak();
                        jednostka.PZ -= wrog.ObliczCalkowityAtak();
                        for (int i = 0; i < wrog.ObliczCalkowityAtak(); i++)
                        {
                            if (jednostka.PZ <= 0)
                            {
                                resztaPZ = jednostka.PZ;
                                jednostka.PZ = jednostka.stalePZ + resztaPZ;
                            }
                            else if (jednostka.PZ > 0)
                            {
                                jednostka.ilosc -= i;
                                break;
                            }
                        }
                    }
                }
                else if (wrog.ObliczCalkowityAtak() < jednostka.PZ)
                {
                    jednostka.PZ -= wrog.ObliczCalkowityAtak();
                    jednostka.calkowitePZ -= wrog.ObliczCalkowityAtak();
                }
            }
        }

        public void SprawdzCzyMoznaZaatakowac(Wrogowie wrog)
        {
            if (rundaTwoja == 1 && pictureBoxJednostka1.Visible)
            {
                ZaatakujNaKrotkiZasieg(o.wojownik, wrog);
            }
            else if (rundaTwoja == 2 && pictureBoxJednostka2.Visible)
            {
                ZaatakujNaKrotkiZasieg(o.lucznik2, wrog);
            }
            else if (rundaTwoja == 3 && pictureBoxJednostka3.Visible)
            {
                ZaatakujNaKrotkiZasieg(o.wlocznik, wrog);
            }
        }




        private void buttonObrona_Click(object sender, EventArgs e)
        {
            if (rundaTwoja == 1)
            {
                pictureBoxJednostka1.BackColor = Color.Blue;
                rundaTwoja++;
            }
            else if (rundaTwoja == 2)
            {
                pictureBoxJednostka2.BackColor = Color.Blue;
                rundaTwoja++;
            }
            else if (rundaTwoja == 3)
            {
                pictureBoxJednostka3.BackColor = Color.Blue;
                rundaTwoja++;
            }
        }

        public void MechanikaPrzeciwnikówNieruchomychDystansowych(Wrogowie wrog)
        {
            wojska.Clear();

            if (pictureBoxJednostka1.Visible)
            {
                wojska.Add(o.wojownik);
            }
            if (pictureBoxJednostka2.Visible)
            {
                wojska.Add(o.lucznik2);
            }
            if (pictureBoxJednostka3.Visible)
            {
                wojska.Add(o.wlocznik);
            }

            //atak obszarowy
            /*
            for (int i = 1; i < 9; i++)
            {
                foreach (var item in wojska)
                {
                    if (przeciwnik.pictureBox.Location.X == item.pictureBox.Location.X + przeciwnik.odlegloscAtak * i)
                    {
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadaneObrazeniaJednostce(przeciwnik, item);
                        break;
                    }
                }
            }
            */

            for (int i = 1; i < 9; i++)
            {
                foreach (var item in wojska)
                {
                    if (wrog.pictureBox.Location.X == item.pictureBox.Location.X + wrog.odlegloscAtak * i)
                    {
                        item.pictureBox.BackColor = Color.DarkRed;
                        ZadajObrazeniaJednostce(wrog, item);
                        goto Koniec;
                    }
                }
            }

        Koniec:
            rundaPrzeciwnika++;
        }



        private void buttonOpusc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz opuścić pole bitwy?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timerRunda.Stop();
                if (ktoraMapa == 1.1 || ktoraMapa == 1.2 || ktoraMapa == 1.3)
                {
                    o.osadaGoblinow.akcjaWrog = true;
                }
                else if (ktoraMapa == 2.1 || ktoraMapa == 2.2)
                {
                    o.jaskiniaWezy.akcjaWrog = true;
                }

                o.timerWojna.Start();
                this.Close();
                MessageBox.Show("Opuściłeś pole bitwy");
            }
          
        }
    }          
}

