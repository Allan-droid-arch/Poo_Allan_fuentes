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
    public partial class Frmhoras : Form
    {
        Clases.Aritmetica hr = new Clases.Aritmetica();
        public Frmhoras()
        {
            InitializeComponent();
        }

        private void Frmhoras_Load(object sender, EventArgs e)
        {

            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (dias.Text.Length == 0)
            {
                MessageBox.Show("Agregar valores correspondientes a las casillas".Trim());
                dias.Focus();
                return;
            }
            double a = Convert.ToDouble(dias.Text.Trim());
            double es = Convert.ToDouble(horas.Text.Trim());
            double d = 250;
            double r = 32;
            hr.extra(a, d,es,r);
            dias.Clear();
            horas.Clear();
            dias.Focus();
        }
    }
}
