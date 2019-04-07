using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anteriora
{
    /// <summary>
    /// klasa Budowle dziedzicząc po Materiały(głownie to poziomUlepszenia) określa cechy budowli
    /// </summary>
    public class Budowle
    {
        public int poziomUlepszenia { get; set; }
        public string nazwa { get; set; }
        public int wytrzymałosc { get; set; }
        public int czasBudowy { get; set; }
        public int pojemnosc { get; set; }
        public int liczbaPracownikowPotrzebnychDoBudowy { get; set; }
        public int czasUlepszenia { get; set; }
        public PictureBox pictureBox { get; set; }
        public Point punkt { get; set; }

        public Budowle()
        {

        }

        public Budowle(string nazwa, int liczbaPracownikow)
        {
            this.nazwa = nazwa;
            this.liczbaPracownikowPotrzebnychDoBudowy = liczbaPracownikow;
        }
        // czas budowy
        public int ZwrocCzasTrwaniaBudowy(int poziomUlepszenia)
        {
            return czasBudowy = 10;
        }

        public int ZwrocCzasTrwaniaUlepszania(int poziomUlepszenia)
        {
            return czasUlepszenia = 20 * (1 + poziomUlepszenia);
        }

        // ustawienie progressBar
        public void PrzypiszPozycjeBudowli()
        {
            punkt = new Point(pictureBox.Location.X + pictureBox.Size.Width / 3, pictureBox.Location.Y + pictureBox.Size.Height / 2);
        }

        public int ObliczLiczbePracownikowPotrzebnychDoBudowy()
        {
            return liczbaPracownikowPotrzebnychDoBudowy = liczbaPracownikowPotrzebnychDoBudowy * (2 + poziomUlepszenia);
        }
    }
}
        
    

   


