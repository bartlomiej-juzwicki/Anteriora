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
    public partial class Hodowla : Form
    {
        Osada o1;
        Początek o2;
        public Hodowla(Osada c1,Początek c2)
        {
            o1 = c1;
            o2 = c2;
            InitializeComponent();
        }
    }
}
