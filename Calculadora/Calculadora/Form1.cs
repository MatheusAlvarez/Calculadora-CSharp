using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// Botão 0
        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        /// Botão 1
        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        /// Botão 2
        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        /// Botão 3
        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        /// Botão 4
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        /// Botão 5
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        /// Botão 6
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        /// Botão 7
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        /// Botão 8
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        /// Botão 9
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        /// Botão .
        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        /// Botão IGUAL
        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }

                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }

                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }

                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }

            else
            {
                MessageBox.Show("Informe o valor.");
            }
           
        }

        /// Botão SUBTRAÇÃO
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }
        }

        /// Botão MULTIPLICAÇÃO
        private void button11_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }
        }

        /// Botão DIVISÃO
        private void button16_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão.");
            }
        }

        /// Botão CE
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        /// Botão C
        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        /// Botão SOMA
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }
        }
    }
}
