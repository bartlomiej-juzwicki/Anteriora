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
    public partial class Namiot : Form
    {
        Osada o1;
        Poczatek o2;
        public Namiot(Osada c1, Poczatek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();
        }

        private void buttonWyjscieNamiot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  po klikneciu w button Budowa przechodzimy do okna Budowa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBudowaNamiot_Click(object sender, EventArgs e)
        {
            new Budowa(o1,o2).ShowDialog();
        }

        private void buttonUlepszanieNamiot_Click(object sender, EventArgs e)
        {
            new Ulepszanie(o1, o2).ShowDialog();
        }

        private void buttonZarządzanieNamiot_Click(object sender, EventArgs e)
        {
            new Zarzadzanie(o1,o2).ShowDialog();
        }
    }
}
