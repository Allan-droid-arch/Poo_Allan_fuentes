using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Allan_Fuentes.Formularios
{
    public partial class FrmNotatotal : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public FrmNotatotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n = double.Parse(n1.Text.Trim());
            double es = double.Parse(n2.Text.Trim());
            r.notota(n,es);
            n1.Clear();
            n2.Clear();
            n1.Focus();

        }

    }
}
