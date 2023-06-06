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
        double num1 = 0;
        double num2 = 0;
        string operacao = "";

        public NumberStyles Cultureinfo { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse (textResultado.Text, CultureInfo.InvariantCulture); // Lidando com números com a vírgula nos números;
            textResultado.Text = "SOMA";
            lblOperacao.Text = "+";
        }
    }
}
