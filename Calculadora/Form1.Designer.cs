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
            this.Numero01 = new System.Windows.Forms.Label();
            this.Numero02 = new System.Windows.Forms.Label();
            this.txtNumero01 = new System.Windows.Forms.TextBox();
            this.txtNumero02 = new System.Windows.Forms.TextBox();
            this.txtSoma = new System.Windows.Forms.Label();
            this.txtSubtracao = new System.Windows.Forms.Label();
            this.txtMultiplicacao = new System.Windows.Forms.Label();
            this.txtDivisao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero01
            // 
            this.Numero01.AutoSize = true;
            this.Numero01.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero01.ForeColor = System.Drawing.Color.MediumBlue;
            this.Numero01.Location = new System.Drawing.Point(28, 64);
            this.Numero01.Name = "Numero01";
            this.Numero01.Size = new System.Drawing.Size(87, 20);
            this.Numero01.TabIndex = 0;
            this.Numero01.Text = "Numero01";
            // 
            // Numero02
            // 
            this.Numero02.AutoSize = true;
            this.Numero02.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero02.ForeColor = System.Drawing.Color.MediumBlue;
            this.Numero02.Location = new System.Drawing.Point(28, 100);
            this.Numero02.Name = "Numero02";
            this.Numero02.Size = new System.Drawing.Size(87, 20);
            this.Numero02.TabIndex = 1;
            this.Numero02.Text = "Numero02";
            // 
            // txtNumero01
            // 
            this.txtNumero01.ForeColor = System.Drawing.Color.Lime;
            this.txtNumero01.Location = new System.Drawing.Point(159, 64);
            this.txtNumero01.Name = "txtNumero01";
            this.txtNumero01.Size = new System.Drawing.Size(129, 25);
            this.txtNumero01.TabIndex = 2;
            this.txtNumero01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero02
            // 
            this.txtNumero02.ForeColor = System.Drawing.Color.Lime;
            this.txtNumero02.Location = new System.Drawing.Point(159, 95);
            this.txtNumero02.Name = "txtNumero02";
            this.txtNumero02.Size = new System.Drawing.Size(129, 25);
            this.txtNumero02.TabIndex = 3;
            this.txtNumero02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoma
            // 
            this.txtSoma.AutoSize = true;
            this.txtSoma.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoma.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSoma.Location = new System.Drawing.Point(28, 151);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(50, 20);
            this.txtSoma.TabIndex = 4;
            this.txtSoma.Text = "Soma";
            // 
            // txtSubtracao
            // 
            this.txtSubtracao.AutoSize = true;
            this.txtSubtracao.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtracao.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSubtracao.Location = new System.Drawing.Point(28, 182);
            this.txtSubtracao.Name = "txtSubtracao";
            this.txtSubtracao.Size = new System.Drawing.Size(83, 20);
            this.txtSubtracao.TabIndex = 5;
            this.txtSubtracao.Text = "Subtração";
            this.txtSubtracao.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMultiplicacao
            // 
            this.txtMultiplicacao.AutoSize = true;
            this.txtMultiplicacao.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplicacao.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtMultiplicacao.Location = new System.Drawing.Point(28, 213);
            this.txtMultiplicacao.Name = "txtMultiplicacao";
            this.txtMultiplicacao.Size = new System.Drawing.Size(107, 20);
            this.txtMultiplicacao.TabIndex = 6;
            this.txtMultiplicacao.Text = "Multiplicação";
            this.txtMultiplicacao.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDivisao
            // 
            this.txtDivisao.AutoSize = true;
            this.txtDivisao.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisao.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtDivisao.Location = new System.Drawing.Point(28, 245);
            this.txtDivisao.Name = "txtDivisao";
            this.txtDivisao.Size = new System.Drawing.Size(61, 20);
            this.txtDivisao.TabIndex = 7;
            this.txtDivisao.Text = "Divisão";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(159, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(159, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 25);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(159, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 25);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(159, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 25);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDivisao);
            this.Controls.Add(this.txtMultiplicacao);
            this.Controls.Add(this.txtSubtracao);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.txtNumero02);
            this.Controls.Add(this.txtNumero01);
            this.Controls.Add(this.Numero02);
            this.Controls.Add(this.Numero01);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label Numero01;
        private System.Windows.Forms.Label Numero02;
        private System.Windows.Forms.TextBox txtNumero01;
        private System.Windows.Forms.TextBox txtNumero02;
        private System.Windows.Forms.Label txtSoma;
        private System.Windows.Forms.Label txtSubtracao;
        private System.Windows.Forms.Label txtMultiplicacao;
        private System.Windows.Forms.Label txtDivisao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}

