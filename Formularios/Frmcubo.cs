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
    public partial class Frmcubo : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmcubo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(n.Text.Trim());

            r.cubo(t);
            n.Clear();
            n.Focus();
        }
    }
}
