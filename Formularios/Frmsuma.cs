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
    public partial class Frmsuma : Form
    {

        Clases.Aritmetica sum = new Clases.Aritmetica();
        public Frmsuma()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(n1.Text);
            b = Convert.ToDouble(n2.Text);
            c = Convert.ToDouble(n3.Text);
            sum.suma(a,b,c);
            n1.Clear();
            n2.Clear();
            n3.Clear();
        }

        private void Frmsuma_Load(object sender, EventArgs e)
        {

        }
    }
}
