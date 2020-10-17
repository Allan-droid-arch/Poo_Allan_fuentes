using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Allan_Fuentes.Formularios
{
    public partial class Frmpromediodeedades : Form
    {
        double to=0,pro;
        public Frmpromediodeedades()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {

            listedad.Items.Add(edad.Text.Trim());
            edad.Clear();
            edad.Focus();
            if (listedad.Items.Count >= 10)
            {
                

                foreach (object cont in listedad.Items)
                {

                    to = to + Convert.ToDouble(cont);
                    pro = to / 10;


                }
                MessageBox.Show((pro).ToString());

                listedad.Items.Clear();


            }
           
        }
    }
}
