using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritmetica;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        //double primero;
        //double segundo;
        string operador;
        double resultado = 1;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            Operaciones(button19.Text);
            /*operador = "-";
            primero = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text += "-";*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }
        public int op;
        private void button20_Click(object sender, EventArgs e)
        {
            Operaciones(button20.Text);
            /*operador = "+";
            primero = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text += "+";*/
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Operaciones(button18.Text);
            /*operador = "*";
            primero = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text += "*";*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Operaciones(button5.Text);
            /*operador = "/";
            primero = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text += "/";*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operaciones(button4.Text);
            /*operador = "%";
            primero = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text += "%";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Clear();
            label2.Text = "";
            resultado = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {

                label1.Text += ".";
            }
            else
            {
                label1.Text = ".";
            }
        }

        private void Operaciones(string opciones)
        {
            if (label2.Text.Contains("="))
            {
                label2.Text = "";
            }

            string signo = opciones;
            label2.Text += label1.Text + " " + signo;

            switch (operador)
            {
                case "+":
                    label1.Text = (calcular.Suma(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "*":
                    label1.Text = (calcular.Multiplicacion(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "-":
                    label1.Text = (calcular.Resta(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "/":
                    label1.Text = (calcular.Divicion(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "%":
                    label1.Text = (calcular.Porcentaje(Convert.ToDouble(resultado)).ToString());
                    break;
            }
            resultado = double.Parse(label1.Text);
            operador = signo;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                label1.Text = "";
            }

            label2.Text += label1.Text;

            switch (operador)
            {
                case "+":
                    label1.Text = (calcular.Suma(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "*":
                    label1.Text = (calcular.Multiplicacion(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "-":
                    label1.Text = (calcular.Resta(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "/":
                    label1.Text = (calcular.Divicion(Convert.ToDouble(resultado), Convert.ToDouble(label1.Text)).ToString());
                    break;
                case "%":
                    label1.Text = (calcular.Porcentaje(Convert.ToDouble(resultado)).ToString());
                    break;
            }
            resultado = double.Parse(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
