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
    public partial class Frmconstructor : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public Frmconstructor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x = double.Parse(n1.Text.Trim());
            double y = double.Parse(n2.Text.Trim());

            r.constr(x,y);
            n1.Clear();
            n2.Clear();
            n1.Focus();
        }
    }
}
