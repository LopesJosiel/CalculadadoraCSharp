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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
    }
}

