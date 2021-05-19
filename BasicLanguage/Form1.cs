using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLanguage
{
    //Declarando un enum para la clasificacion de las operaciones internas de la calculadora
    public enum Operator
    {
        Indefinida = 0, Suma = 1, Resta = 2, Multiplicacion = 3, Division = 4, Porcentaje = 5, Racional = 6, Cuadrado = 7, RaizCuadrada = 8
    }
    public partial class Form1 : Form
    {
        double value1 = 0;
        double value2 = 0;
        Operator operador = Operator.Indefinida;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        //Metodos
        private void addNumbers(string number = "0")
        {
            if (lblResultado.Text == "0" && lblResultado.Text != null)
            {
                lblResultado.Text = number;
            }
            else
            {
                lblResultado.Text += number;
            }
        }

        private double addOperators()
        {
            double result = 0;
            switch (operador)
            {
                case Operator.Suma:
                    result = value1 + value2;
                    break;
                case Operator.Resta:
                    result = value1 - value2;
                    break;
                case Operator.Multiplicacion:
                    result = value1 * value2;
                    break;
                case Operator.Division:
                    if(value2 == 0)
                    {
                        MessageBox.Show("Can not divided by zero");
                        result = 0;
                    }
                    else
                    {
                        result = value1 / value2;
                    }
                    break;
                case Operator.Porcentaje:
                    result = value1 % value2;
                    break;
                case Operator.Racional:
                    if(value1 == 0)
                    {
                        MessageBox.Show("Can not divided by zero");
                    }
                    else
                    {
                        result = 1 / value1;
                    }
                    break;
                case Operator.Cuadrado:
                    result = Math.Pow(value1, 2);
                    break;
                case Operator.RaizCuadrada:
                    result = Math.Sqrt(value1);
                    break;
            }
            return result;
        }

        private void getValue(string operador)
        {
            value1 = Convert.ToDouble(lblResultado.Text);
            lblEjecucion.Text = lblResultado.Text + operador;
            lblResultado.Text = "";
        }
        //Fin Metodos-------------------------------------------------------------------------------------------------

        private void btn0_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text == "0")
            {
                return;
            }
            else
            {
                lblResultado.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string number = "1";
            addNumbers(number);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string number = "2";
            addNumbers(number);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string number = "3";
            addNumbers(number);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string number = "4";
            addNumbers(number);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string number = "5";
            addNumbers(number);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string number = "6";
            addNumbers(number);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string number = "7";
            addNumbers(number);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string number = "8";
            addNumbers(number);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string number = "9";
            addNumbers(number);
        }

        //Operators Buttons-------------------------------------------------------------------------------------------
        private void btnSum_Click_1(object sender, EventArgs e)
        {
            operador = Operator.Suma;
            getValue("+");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(value2 == 0)
            {
                value2 = Convert.ToDouble(lblResultado.Text);
                lblEjecucion.Text += value2 + "=";
                double result = addOperators();
                

                value1 = 0; value2 = 0; // Reseteamos los valores para seguir agregando mas peticiones

                lblResultado.Text = Convert.ToString(result);
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            operador = Operator.Resta;
            getValue("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = Operator.Multiplicacion;
            getValue("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = Operator.Division;
            getValue("/");
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            operador = Operator.Porcentaje;
            getValue("%");
        }

        private void btnRacional_Click(object sender, EventArgs e)
        {
            operador = Operator.Racional;
            getValue("1/x");
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            operador = Operator.Cuadrado;
            getValue("x^2");
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            operador = Operator.RaizCuadrada;
            getValue("2√x");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            lblEjecucion.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lblResultado.Text.Length > 1)
            {
                string lengthValidator = lblResultado.Text;
                lengthValidator = lengthValidator.Substring(0, lengthValidator.Length -1);

                lblResultado.Text = lengthValidator;
            }
            else
            {
                lblResultado.Text = "0";
            }
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            value1 = 0; value2 = 0;
        }
    }
}
