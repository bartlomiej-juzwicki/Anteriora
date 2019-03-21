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
        Osada originalForm;
        Początek originalForm2;
        public Namiot(Osada copyForm, Początek copyForm2)
        {
            originalForm = copyForm;
            originalForm2 = copyForm2;
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
            new Budowa(originalForm,originalForm2).ShowDialog();
        }
    }
}
