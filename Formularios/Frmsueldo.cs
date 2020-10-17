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
    public partial class Frmsueldo : Form
    {
        Clases.Aritmetica hr = new Clases.Aritmetica();
        public Frmsueldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dias.Text.Length == 0)
            {
                MessageBox.Show("Agregar valores correspondientes a las casillas".Trim());
                dias.Focus();
                return;
            }
            double a = Convert.ToDouble(dias.Text.Trim());
            double es = 250;
           hr.hora(a, es);
            dias.Clear();
           dias.Focus();
        }
    }
}
