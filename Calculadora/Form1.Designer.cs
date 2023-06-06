namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.Button15 = new System.Windows.Forms.Button();
            this.Button16 = new System.Windows.Forms.Button();
            this.Button17 = new System.Windows.Forms.Button();
            this.Button18 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(3, 12);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(319, 20);
            this.textResultado.TabIndex = 0;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(12, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 1;
            this.label.Text = "lblOperacao";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Teal;
            this.Button1.Location = new System.Drawing.Point(3, 64);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(59, 35);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "7";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Teal;
            this.Button2.Location = new System.Drawing.Point(68, 64);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(59, 35);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "8";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Teal;
            this.Button3.Location = new System.Drawing.Point(133, 64);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(59, 35);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "9";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Teal;
            this.Button4.Location = new System.Drawing.Point(198, 64);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(59, 35);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "+";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Teal;
            this.Button7.Location = new System.Drawing.Point(198, 105);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(59, 35);
            this.Button7.TabIndex = 10;
            this.Button7.Text = "-";
            this.Button7.UseVisualStyleBackColor = false;
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Teal;
            this.Button8.Location = new System.Drawing.Point(133, 105);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(59, 35);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "6";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Teal;
            this.Button9.Location = new System.Drawing.Point(68, 105);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(59, 35);
            this.Button9.TabIndex = 8;
            this.Button9.Text = "5";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.Teal;
            this.Button10.Location = new System.Drawing.Point(3, 105);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(59, 35);
            this.Button10.TabIndex = 7;
            this.Button10.Text = "4";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.Teal;
            this.Button12.Location = new System.Drawing.Point(198, 146);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(59, 35);
            this.Button12.TabIndex = 15;
            this.Button12.Text = "X";
            this.Button12.UseVisualStyleBackColor = false;
            // 
            // Button13
            // 
            this.Button13.BackColor = System.Drawing.Color.Teal;
            this.Button13.Location = new System.Drawing.Point(133, 146);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(59, 35);
            this.Button13.TabIndex = 14;
            this.Button13.Text = "3";
            this.Button13.UseVisualStyleBackColor = false;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Button14
            // 
            this.Button14.BackColor = System.Drawing.Color.Teal;
            this.Button14.Location = new System.Drawing.Point(68, 146);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(59, 35);
            this.Button14.TabIndex = 13;
            this.Button14.Text = "2";
            this.Button14.UseVisualStyleBackColor = false;
            this.Button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // Button15
            // 
            this.Button15.BackColor = System.Drawing.Color.Teal;
            this.Button15.Location = new System.Drawing.Point(3, 146);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(59, 35);
            this.Button15.TabIndex = 12;
            this.Button15.Text = "1";
            this.Button15.UseVisualStyleBackColor = false;
            this.Button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // Button16
            // 
            this.Button16.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button16.Location = new System.Drawing.Point(263, 105);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(59, 117);
            this.Button16.TabIndex = 21;
            this.Button16.Text = "=";
            this.Button16.UseVisualStyleBackColor = false;
            // 
            // Button17
            // 
            this.Button17.BackColor = System.Drawing.Color.Teal;
            this.Button17.Location = new System.Drawing.Point(198, 187);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(59, 35);
            this.Button17.TabIndex = 20;
            this.Button17.Text = "÷";
            this.Button17.UseVisualStyleBackColor = false;
            // 
            // Button18
            // 
            this.Button18.BackColor = System.Drawing.Color.Teal;
            this.Button18.Location = new System.Drawing.Point(133, 187);
            this.Button18.Name = "Button18";
            this.Button18.Size = new System.Drawing.Size(59, 35);
            this.Button18.TabIndex = 19;
            this.Button18.Text = ",";
            this.Button18.UseVisualStyleBackColor = false;
            this.Button18.Click += new System.EventHandler(this.Button18_Click);
            // 
            // Button20
            // 
            this.Button20.BackColor = System.Drawing.Color.Teal;
            this.Button20.Location = new System.Drawing.Point(3, 187);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(124, 35);
            this.Button20.TabIndex = 17;
            this.Button20.Text = "0";
            this.Button20.UseVisualStyleBackColor = false;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button5.Location = new System.Drawing.Point(263, 64);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(59, 35);
            this.Button5.TabIndex = 22;
            this.Button5.Text = "C";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(331, 267);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button16);
            this.Controls.Add(this.Button17);
            this.Controls.Add(this.Button18);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.Button15);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textResultado);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "CalculadoraJosiel";
=======
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Num01 = new System.Windows.Forms.Label();
            this.Num02 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num01
            // 
            this.Num01.AutoSize = true;
            this.Num01.Cursor = System.Windows.Forms.Cursors.Default;
            this.Num01.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num01.ForeColor = System.Drawing.Color.MediumBlue;
            this.Num01.Location = new System.Drawing.Point(28, 64);
            this.Num01.Name = "Num01";
            this.Num01.Size = new System.Drawing.Size(87, 20);
            this.Num01.TabIndex = 0;
            this.Num01.Text = "Numero01";
            // 
            // Num02
            // 
            this.Num02.AutoSize = true;
            this.Num02.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num02.ForeColor = System.Drawing.Color.MediumBlue;
            this.Num02.Location = new System.Drawing.Point(28, 100);
            this.Num02.Name = "Num02";
            this.Num02.Size = new System.Drawing.Size(87, 20);
            this.Num02.TabIndex = 1;
            this.Num02.Text = "Numero02";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculadora Básica";
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(32, 153);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(28, 23);
            this.soma.TabIndex = 13;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.SOMA_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(32, 184);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(28, 23);
            this.subtracao.TabIndex = 14;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(32, 214);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(28, 23);
            this.multiplicacao.TabIndex = 15;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = true;
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(32, 246);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(28, 23);
            this.divisao.TabIndex = 16;
            this.divisao.Text = "÷";
            this.divisao.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(159, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 25);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(159, 59);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 25);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num02);
            this.Controls.Add(this.Num01);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Calculadora";
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button12;
        private System.Windows.Forms.Button Button13;
        private System.Windows.Forms.Button Button14;
        private System.Windows.Forms.Button Button15;
        private System.Windows.Forms.Button Button16;
        private System.Windows.Forms.Button Button17;
        private System.Windows.Forms.Button Button18;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Button Button5;
=======
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label Num01;
        private System.Windows.Forms.Label Num02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
>>>>>>> d8e017d03e6270c06e4645907d11c9b268b60e34
    }
}

