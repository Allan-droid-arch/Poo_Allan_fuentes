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
    public partial class FrmDias_a_minutos : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public FrmDias_a_minutos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double t = Convert.ToDouble(dias.Text.Trim());
            double g = 1440;
            r.minu(t,g);
            dias.Clear();
            dias.Focus();
        }
    }
}
