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
    public partial class FrmMillas : Form
    {
        Clases.Aritmetica sum = new Clases.Aritmetica();
        public FrmMillas()
        {
            InitializeComponent();
        }

        private void btnKilometros_Click(object sender, EventArgs e)
        {
            if (milla.Text.Length == 0) {
                MessageBox.Show("ingrese las millas".Trim());
                    
             }
            double a = Convert.ToDouble(milla.Text.Trim());
            double es = 1.609;
            sum.Kilo(a,es);
            milla.Clear();
            milla.Focus();
        }

        private void btnmetros_Click(object sender, EventArgs e)
        {
            if (milla.Text.Length == 0)
            {
                MessageBox.Show("ingrese las millas".Trim());
                milla.Focus();
                return;

            }
            double a = Convert.ToDouble(milla.Text.Trim());
            double es = 1609;
            sum.Kilo(a, es);
            milla.Clear();
            milla.Focus();
        }
    }
}
