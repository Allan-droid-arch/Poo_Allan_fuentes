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
    public partial class Frmlempiras : Form
    {
        Clases.Aritmetica sum = new Clases.Aritmetica();
        public Frmlempiras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Lemp.Text.Length == 0)
            {
                MessageBox.Show("ingrese las millas".Trim());
                Lemp.Focus();
                return;
            }
            double a = Convert.ToDouble(Lemp.Text.Trim());
            double es = 24.42;
            sum.lem(a, es);
            Lemp.Clear();
            Lemp.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lemp.Text.Length == 0)
            {
                MessageBox.Show("ingrese las millas".Trim());
                Lemp.Focus();
                return;
            }
            double a = Convert.ToDouble(Lemp.Text.Trim());
            double es = 28.69;
            sum.lem(a, es);
            Lemp.Clear();
            Lemp.Focus();
        }
    }
}
