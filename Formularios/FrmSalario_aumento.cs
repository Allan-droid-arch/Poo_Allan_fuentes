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
    public partial class FrmSalario_aumento : Form
    {
        Clases.Aritmetica r = new Clases.Aritmetica();
        public FrmSalario_aumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(sal.Text.Trim());
            
            r.aumento(t);
            sal.Clear();
            sal.Focus();
        }
    }
}
