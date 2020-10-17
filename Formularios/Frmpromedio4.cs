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
    
    public partial class Frmpromedio4 : Form
    {
        Clases.Aritmetica sum = new Clases.Aritmetica();
        double to = 0, pro;
        public Frmpromedio4()
        {
            InitializeComponent();
        }
        
     
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (nota.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la nota");
                nota.Focus();

                return;
            }
            listnota.Items.Add(nota.Text.Trim());
            nota.Focus();
           
           
            nota.Clear();
           

            if (listnota.Items.Count >= 4)
            {
                foreach (object cont in listnota.Items)
                {

                    to = to + Convert.ToDouble(cont);
                    pro = to / 4;


                }
                MessageBox.Show((pro).ToString());
            }
        }
    }
}
