using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using POO_Allan_Fuentes.Formularios;

namespace POO_Allan_Fuentes.Clases
{
    
    class Aritmetica
    {

       
         
        public void suma(double n1, double n2, double n3)
        {
            double re = n1 + n1 + n3;
            MessageBox.Show("La suma es: " + re.ToString());
        }
        public void Kilo(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Los kilometros son:" + to);
           
        }
        public void lem(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("La Cantidad a recibir es:" + to);

        }
        public void llanta(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Total a pagar es:" + to);

        }
        public void hora(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Total a pagar es:" + to);

        }
        public void extra(double k, double l,double f ,double g)
        {
            double to = (k * l);
            double tot = f * g;
            double total = to + tot; 
            MessageBox.Show("Total a pagar es:" + total);

        }
        public void Gal(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Los litros son :" + to);

        }
        public void pul(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Los litros son :" + to);

        }
        public void aumento(double k)
        {
            double to = k *0.25;
            double tota = k + to;


            MessageBox.Show("Total a pagar es:" + tota);

        }
        public void minu(double k, double l)
        {
            double to = k * l;
            MessageBox.Show("Los minutos son :" + to);

        }
        public void libras(double k)
        {
            double to = k * 16;
            MessageBox.Show("Las libras son  :" + to);

        }
        public void cuadrado(double k)
        {

            double to = Math.Pow(k, 2);
            MessageBox.Show("Las libras son  :" + to);

        }
        public void cubo(double k)
        {

            double to = Math.Pow(k, 3);
            MessageBox.Show("Las libras son  :" + to);

        }
        public void doble(double k)
        {

            double to = k + k;
            MessageBox.Show("Las libras son  :" + to);

        }
        public void pies(double k)
        {

            double to = k *3.28084;
            MessageBox.Show("Las libras son  :" + to);
            
        }
        public void constr (double k, double l)

        { 
            

            double to = k*l ;
            MessageBox.Show(" Total a pagar  :" + to);

        }
        public void notota(double k, double l)

        {


            double to = k + l;
            MessageBox.Show(" La nota total es :" + to);

        }
        public void sema(double k)

        {


            double to = k *1080;
            MessageBox.Show(" Los minutos son :" + to);

        }
    }
}