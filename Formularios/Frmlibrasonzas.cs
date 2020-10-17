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
    public partial class Frmlibrasonzas : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmlibrasonzas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(libra.Text.Trim());
          
            r.libras(t);
            libra.Clear();
            libra.Focus();
        }
    }
}
