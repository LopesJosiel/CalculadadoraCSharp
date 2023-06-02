using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string Num01 = txtNumero01.Text;
            decimal Nu_1= Convert.ToDecimal(Num01);
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

        }

        private void txtNumero02_TextChanged(object sender, EventArgs e)
        {
            string Num02 = txtNumero02.Text;
            decimal Nu_2 = Convert.ToDecimal(Num02);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            decimal soma = (Nu_1  + Nu_2

        }
    }
}
