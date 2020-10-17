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
    public partial class FrmMenu : Form
        
    {
       
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Formularios.Frmsuma suma = new Formularios.Frmsuma();
            suma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.Frmpromedio4 porme = new Formularios.Frmpromedio4();
            porme.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmMillas milla = new Formularios.FrmMillas();
            milla.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.Frmlempiras lempira = new Formularios.Frmlempiras();
            lempira.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmLlantas llanta = new Formularios.FrmLlantas();
            llanta.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.Frmsueldo sueldo = new Formularios.Frmsueldo();

            sueldo.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.Frmhoras horas = new Formularios.Frmhoras();
            horas.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.Frmgal gal = new Formularios.Frmgal();
            gal.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.Frmpulgada pu = new Formularios.Frmpulgada();
            pu.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalario_aumento aumen = new Formularios.FrmSalario_aumento();

            aumen.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.FrmDias_a_minutos minu = new Formularios.FrmDias_a_minutos();
            minu.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.Frmlibrasonzas libr = new Formularios.Frmlibrasonzas();
            libr.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Formularios.Frmelvar cuadra = new Formularios.Frmelvar();
            cuadra.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Formularios.Frmcubo cubo = new Formularios.Frmcubo();
            cubo.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Formularios.Frmdoble doble = new Formularios.Frmdoble();
            doble.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formularios.Frmmetrospies metr = new Formularios.Frmmetrospies();
            metr.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Formularios.Frmconstructor cont = new Formularios.Frmconstructor();
            cont.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Formularios.FrmNotatotal nota = new Formularios.FrmNotatotal();
            nota.ShowDialog();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Formularios.Frmsemanas_a_minutos min = new Formularios.Frmsemanas_a_minutos();
            min.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Formularios.Frmpromediodeedades edad = new Formularios.Frmpromediodeedades();
            edad.ShowDialog();
        }
    }
}
