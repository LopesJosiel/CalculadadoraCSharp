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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero01_TextChanged(object sender, EventArgs e)
        {
            // primeiro declarar as variaveis;
            int n1;
            int n2;
            // agora fazendo a conversão das variáveis;
            n1 = Convert.To
            n2 = Convert.ToUInt32 (txtNumero02.Text);
            // declarando as quatro variáveis para as quatro operações básicas;
            double soma1 = n1 + n2;
            double subtrcao = n2 - n1;
            double multiplicaco1 = n1 * n2;
            double divisao = n2 / n1;
        }

        private void txtNumero02_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoma_Click(object sender, EventArgs e)
        {
            // primeiro declarar as variaveis;
            Int32  n1;
            Int32 n2;
            Int32 soma1;
            // agora fazendo a conversão das variáveis;
            n1 = (int)Convert.ToUInt32(txtNumero01.Text);
            n2 = (int)Convert.ToUInt32(txtNumero02.Text);
            // declarando as quatro variáveis para as quatro operações básicas;
            soma1 = n1 + n2;
            string textBox1 = Convert.ToString(soma1);

        }
    }
}
