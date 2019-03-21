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
    public partial class Dziennik : Form
    {
        Osada o1;
        public Dziennik(Osada c1)
        {
            o1 = c1;
            InitializeComponent();
            textBoxDziennik.Text = o1.zapisDoDziennika;
        }

        private void buttonZamknijDziennik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAktualizacja_Click(object sender, EventArgs e)
        {
            o1.zapisDoDziennika = textBoxDziennik.Text;
        }
    }
}
