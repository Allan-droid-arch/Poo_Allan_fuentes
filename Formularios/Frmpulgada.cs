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
    public partial class Frmpulgada : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmpulgada()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(pulg.Text.Trim());
            double x =2.54;
            r.pul(t, x);
            pulg.Clear();
            pulg.Focus();
        }
    }
}
