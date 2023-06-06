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
        }
    }
}
