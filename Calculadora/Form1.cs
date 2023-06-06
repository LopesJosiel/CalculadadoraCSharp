using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
using System.Globalization;
using System.Linq;
=======
using System.Linq;
using System.Security.Cryptography;
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        double num1 = 0;
        double num2 = 0;
        string operacao = "";

        public NumberStyles Cultureinfo { get; private set; }

=======
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
=======
        public void button1_Click(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
        }

        public void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
        {
           
        }

<<<<<<< HEAD
        private void Button20_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textResultado.Text +=  "1";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse (textResultado.Text, CultureInfo.InvariantCulture); // Lidando com números com a vírgula nos números;
            textResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
=======
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void txtNumero01_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumero02_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoma_Click(object sender, EventArgs e)
        {
        }

        private void soma_Click(object sender, EventArgs e)
        {// primeiro declarar as variaveis;
            double n1;
            double n2;
            double soma1;
            // agora fazendo a conversão das variáveis;
            n1 = Convert.ToDouble(textBox5.Text);
            n2 = Convert.ToDouble(textBox6.Text);
            // declarando as quatro variáveis para cada operação básica;
            soma1 = n1 + n2;
            string label2 = Convert.ToString(soma1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double soma1;
            // agora fazendo a conversão das variáveis;
            n1 = Convert.ToDouble(textBox5.Text);
            n2 = Convert.ToDouble(textBox6.Text);
            // declarando as quatro variáveis para cada operação básica;
            soma1 = n1 + n2;
            string label2 = Convert.ToString(soma1);
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
        }
    }
}
