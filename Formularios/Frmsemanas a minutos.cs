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
    public partial class Frmsemanas_a_minutos : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmsemanas_a_minutos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double o = double.Parse(n.Text.Trim());
            r.sema(o);
            n.Clear();
            n.Focus();
        }
    }
}
