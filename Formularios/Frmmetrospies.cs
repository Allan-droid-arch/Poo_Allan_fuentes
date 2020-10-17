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
    public partial class Frmmetrospies : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmmetrospies()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(n.Text.Trim());

            r.pies(t);
            n.Clear();
            n.Focus();
        }
    }
}
