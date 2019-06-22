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
        public bool czyBudowlaIstnieje { get; set; }
        public PictureBox pictureBox { get; set; }
        public Bitmap bitmap { get; set; }
        public ProgressBar progressBarBudowa { get; set; }
        public ProgressBar progressBarUlepszanie { get; set; }
        public Point punkt { get; set; }

        public Budowle()
        {

        }

        public Budowle(string nazwa, int liczbaPracownikowPotrzebnychDoBudowy)
        {
            this.nazwa = nazwa;
            this.liczbaPracownikowPotrzebnychDoBudowy = liczbaPracownikowPotrzebnychDoBudowy;
        }
        // czas budowy
        public int ZwrocCzasTrwaniaBudowy()
        {
            return czasBudowy = (poziomUlepszenia+1)*10;
        }

        public int ZwrocCzasTrwaniaUlepszania()
        {
            return czasUlepszenia = 20 * (1 + poziomUlepszenia);
        }

        // ustawienie progressBar
        public static void PrzypiszPozycjeBudowli(List<Budowle> list)
        {
            foreach (var item in list)
            {
                item.punkt = new Point(item.pictureBox.Location.X + item.pictureBox.Size.Width / 3, item.pictureBox.Location.Y + item.pictureBox.Size.Height / 2);
            }
           
        }

        public int ObliczLiczbePracownikowPotrzebnychDoBudowy()
        {
            return liczbaPracownikowPotrzebnychDoBudowy = liczbaPracownikowPotrzebnychDoBudowy * (2 + poziomUlepszenia);
        }

        public void ObliczWytrzymaloscBudowli()
        {
            wytrzymałosc = 1000 * poziomUlepszenia;
        }
    }
}
        
    

   


