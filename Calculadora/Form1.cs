using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
        {
           
        }

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
        }
    }
}
