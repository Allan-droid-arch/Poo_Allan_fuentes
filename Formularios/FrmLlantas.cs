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
    
    public partial class FrmLlantas : Form
    {
        Clases.Aritmetica llan = new Clases.Aritmetica();
        public FrmLlantas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cantidad.Text.Length == 0 && precio.Text.Length == 0)
            {
                MessageBox.Show("Agregar valores correspondientes a las casillas".Trim());
                cantidad.Focus();
                return;
            }
            double a = Convert.ToDouble(cantidad.Text.Trim());
            double es = Convert.ToDouble(precio.Text.Trim());
            llan.llanta(a, es);
            cantidad.Clear();
            precio.Clear();
            cantidad.Focus();
        }
    }
    
}
