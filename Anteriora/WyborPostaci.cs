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
    public partial class WyborPostaci : Form
    {
        int numer;

        public WyborPostaci()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void TextBoxNazwaPostaci_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDalej.Focus();
            }
        }

        private void WyborPostaci_Shown(object sender, EventArgs e)
        {
            buttonDalej.Focus();

            textBoxNazwaPostaci.Text = "Podaj nazwę postaci";

        }

        private void TextBoxNazwaPostaci_Enter(object sender, EventArgs e)
        {
            textBoxNazwaPostaci.Text = "";
        }

        //private void UstawPostac()
        //{
        //    if(numer == 0)
        //    {
        //        labelNazwaPostaci.Text = "Wojownik";
        //        labelAtrybuty.Text = "Atrybuty wojownika";
        //        labelOpisPostaci.Text = "Opis wojownika";
        //        pictureBoxPostacDol.Image = Properties.Resources.wojownikdol;
        //        pictureBoxPostacGora.Image = Properties.Resources.wojownikgora;
        //        pictureBoxPostacLewo.Image = Properties.Resources.wojowniklewo;
        //        pictureBoxPostacPrawo.Image = Properties.Resources.wojownikprawo;
        //    }
        //    else if(numer == 1)
        //    {
        //        labelNazwaPostaci.Text = "Łucznik";
        //        labelAtrybuty.Text = "Atrybuty lucznika";
        //        labelOpisPostaci.Text = "Opis łucznika";
        //        pictureBoxPostacDol.Image = Properties.Resources.lucznikdol;
        //        pictureBoxPostacGora.Image = Properties.Resources.lucznikgora;
        //        pictureBoxPostacLewo.Image = Properties.Resources.luczniklewo;
        //        pictureBoxPostacPrawo.Image = Properties.Resources.lucznikprawo;
        //    }
        //    else if(numer == 2)
        //    {
        //        labelNazwaPostaci.Text = "Mag";
        //        labelAtrybuty.Text = "Atrybuty maga";
        //        labelOpisPostaci.Text = "Opis maga";
        //        // zmienic na grafiki dla maga
        //        pictureBoxPostacDol.Image = Properties.Resources.goblindol;
        //        pictureBoxPostacGora.Image = Properties.Resources.goblingora;
        //        pictureBoxPostacLewo.Image = Properties.Resources.goblinlewo;
        //        pictureBoxPostacPrawo.Image = Properties.Resources.goblinprawo;
        //    }
        //}

        //private void ButtonKolejnaPostac_Click(object sender, EventArgs e)
        //{

        //    pictureBoxPostacDol.Visible = true;
        //    pictureBoxPostacGora.Visible = true;
        //    pictureBoxPostacLewo.Visible = true;
        //    pictureBoxPostacPrawo.Visible = true;

        //    if (numer+1 > 2)
        //    {
        //        numer = 0;
        //    }
        //    else
        //    {
        //        numer++;
        //    }

        //    UstawPostac();
        //}

        //private void ButtonPoprzedniaPostac_Click(object sender, EventArgs e)
        //{
        //    if (numer-1 < 0 )
        //    {
        //        numer = 2;
        //    }
        //    else
        //    {
        //        numer--;
        //    }

        //    UstawPostac();
        //}

        //private void ButtonDalej_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    new Poczatek().Show();
        //}

       
    }
}
