using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Anteriora
{
    public partial class Start : Form
    {
        int ktoraPostac;

        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        public Start()
        {
            InitializeComponent();
           
            timerLadowanie.Start();
        }

        private void TimerLadowanie_Tick(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width + 10, pictureBox1.Height);

            if (pictureBox1.Width == 700)
            {
                pictureBox1.Visible = false;
                pictureBoxNazwa.Visible = true;
                buttonLogowanie.Visible = true;
                buttonRejestracja.Visible = true;
                buttonWyjscie.Visible = true;
                button1.Visible = true;
                this.BackgroundImage = Properties.Resources.t2;
                wplayer.URL = "muzyka1.mp3";
                wplayer.controls.play();
                timerLadowanie.Stop();
            }
        }

        private void ButtonWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogowanie_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //panel2.Visible = true;
            //panel3.Visible = true;
            //panel8.Visible = true;            
            //panel9.Visible = true;
            //pictureBoxLucznik.Visible = true;
            //pictureBoxWojownik.Visible = true;
            //pictureBoxMag.Visible = true;
            //buttonWojownik.Visible = true;
            //buttonLucznik.Visible = true;
            //buttonMag.Visible = true;

            //buttonPowrot.Visible = true;
            //buttonDalej.Visible = true;
            //buttonLogowanie.Visible = false;
            //buttonRejestracja.Visible = false;
            //buttonWyjscie.Visible = false;
            //pictureBoxNazwa.Visible = false;
            //buttonDalej.Focus();

            buttonLogowanie.Visible = false;
            buttonRejestracja.Visible = false;
            buttonWyjscie.Visible = false;
            panel5.Visible = true;
            panel4.Visible = true;
            buttonPowrotZLogowania.Visible = true;
            buttonZalogujSie.Visible = true;

            textBoxLogin.Text = "";
            textBoxHaslo.Text = "";


            textBoxLogin.Focus();
            textBoxHaslo.Focus();
            buttonZalogujSie.Focus();


            //textBoxNazwaPostaci.Text = "Nazwa postaci";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }

        private void ButtonPowrot_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            pictureBoxLucznik.Visible = false;
            pictureBoxWojownik.Visible = false;
            pictureBoxMag.Visible = false;
            buttonWojownik.Visible = false;
            buttonLucznik.Visible = false;
            buttonMag.Visible = false;
            buttonPowrot.Visible = false;
            buttonDalej.Visible = false;            

            buttonNowaGra.Visible = true;
            buttonWczytaj.Visible = true;
            buttonWyjscieZGry.Visible = true;
            pictureBoxNazwa.Visible = true;
        }

        private void ButtonRejestracja_Click(object sender, EventArgs e)
        {
            new Wiadomosc("Przekierowanie na stronę").Show();
        }

        private void ButtonPowrotZLogowania_Click(object sender, EventArgs e)
        {
            buttonLogowanie.Visible = true;
            buttonRejestracja.Visible = true;
            buttonWyjscie.Visible = true; ;
            panel5.Visible = false;
            panel4.Visible = false;
            buttonPowrotZLogowania.Visible = false;
            buttonZalogujSie.Visible = false;
        }

        private void ButtonZalogujSie_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "a" && textBoxHaslo.Text == "b")
            {
                //panel1.Visible = true;
                //panel2.Visible = true;
                //panel3.Visible = true;
                //panel8.Visible = true;
                //panel9.Visible = true;
                //pictureBoxLucznik.Visible = true;
                //pictureBoxWojownik.Visible = true;
                //pictureBoxMag.Visible = true;
                //buttonWojownik.Visible = true;
                //buttonLucznik.Visible = true;
                //buttonMag.Visible = true;

                //buttonPowrot.Visible = true;
                //buttonDalej.Visible = true;

                buttonNowaGra.Visible = true;
                buttonWczytaj.Visible = true;
                buttonWyjscieZGry.Visible = true;
                panel5.Visible = false;
                panel4.Visible = false;
                buttonPowrotZLogowania.Visible = false;
                buttonZalogujSie.Visible = false;
            


            }
            else
            {
                new Wiadomosc("Podałeś zły login lub hasło").Show();
            }
        }

        private void ButtonWyjscieZGry_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonNowaGra_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            pictureBoxLucznik.Visible = true;
            pictureBoxWojownik.Visible = true;
            pictureBoxMag.Visible = true;
            buttonWojownik.Visible = true;
            buttonLucznik.Visible = true;
            buttonMag.Visible = true;
            buttonPowrot.Visible = true;
            buttonDalej.Visible = true;

            buttonNowaGra.Visible = false;
            buttonWczytaj.Visible = false;
            buttonWyjscieZGry.Visible = false;
            pictureBoxNazwa.Visible = false;
            textBoxNazwaPostaci.Focus();
            buttonDalej.Focus();
        }

        private void ButtonDalej_Click(object sender, EventArgs e)
        {

            if(ktoraPostac == 0 || string.IsNullOrEmpty(textBoxNazwaPostaci.Text) || string.IsNullOrWhiteSpace(textBoxNazwaPostaci.Text))
            {
                new Wiadomosc("ELO").Show();
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                pictureBoxLucznik.Visible = false;
                pictureBoxWojownik.Visible = false;
                pictureBoxMag.Visible = false;
                buttonWojownik.Visible = false;
                buttonLucznik.Visible = false;
                buttonMag.Visible = false;
                buttonPowrot.Visible = false;
                buttonDalej.Visible = false;
                pictureBoxNazwa.Visible = false;
                label1.Visible = false;

                this.BackgroundImage = null;

                PostacGracza postacGracza = new PostacGracza(ktoraPostac, textBoxNazwaPostaci.Text);
                new EkranLadowania(5).Show();
            }
          
        }

        private void ButtonWojownik_Click(object sender, EventArgs e)
        {
            ktoraPostac = 1;
            buttonWojownik.FlatAppearance.BorderColor = Color.Red;
            buttonMag.FlatAppearance.BorderColor = Color.Black;
            buttonLucznik.FlatAppearance.BorderColor = Color.Black;

        }

        private void ButtonLucznik_Click(object sender, EventArgs e)
        {
            ktoraPostac = 2;
            buttonLucznik.FlatAppearance.BorderColor = Color.Red;
            buttonMag.FlatAppearance.BorderColor = Color.Black;
            buttonWojownik.FlatAppearance.BorderColor = Color.Black;

        }

        private void ButtonMag_Click(object sender, EventArgs e)
        {
            ktoraPostac = 3;
            buttonMag.FlatAppearance.BorderColor = Color.Red;
            buttonLucznik.FlatAppearance.BorderColor = Color.Black;
            buttonWojownik.FlatAppearance.BorderColor = Color.Black;
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();

            rClient.endPoint = "http://172.104.156.223/user/" + textBoxLogin.Text;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            textBoxGo.Text = strResponse;

        }
    }
}
