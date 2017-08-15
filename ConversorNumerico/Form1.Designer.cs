namespace ConversorNumerico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.valorDigitado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultHex = new System.Windows.Forms.Label();
            this.resultOct = new System.Windows.Forms.Label();
            this.resultBi = new System.Windows.Forms.Label();
            this.resultDec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a base de entrada dos dados";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.valorDigitado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(35, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valorDigitado
            // 
            this.valorDigitado.Location = new System.Drawing.Point(266, 75);
            this.valorDigitado.Name = "valorDigitado";
            this.valorDigitado.Size = new System.Drawing.Size(181, 22);
            this.valorDigitado.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Digite o valor para conversão:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.resultDec);
            this.groupBox2.Controls.Add(this.resultHex);
            this.groupBox2.Controls.Add(this.resultOct);
            this.groupBox2.Controls.Add(this.resultBi);
            this.groupBox2.Location = new System.Drawing.Point(35, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // resultHex
            // 
            this.resultHex.AutoSize = true;
            this.resultHex.Location = new System.Drawing.Point(114, 69);
            this.resultHex.Name = "resultHex";
            this.resultHex.Size = new System.Drawing.Size(99, 17);
            this.resultHex.TabIndex = 2;
            this.resultHex.Text = "resultadoHexa";
            // 
            // resultOct
            // 
            this.resultOct.AutoSize = true;
            this.resultOct.Location = new System.Drawing.Point(114, 98);
            this.resultOct.Name = "resultOct";
            this.resultOct.Size = new System.Drawing.Size(100, 17);
            this.resultOct.TabIndex = 1;
            this.resultOct.Text = "resultadoOctal";
            // 
            // resultBi
            // 
            this.resultBi.AutoSize = true;
            this.resultBi.Location = new System.Drawing.Point(114, 37);
            this.resultBi.Name = "resultBi";
            this.resultBi.Size = new System.Drawing.Size(111, 17);
            this.resultBi.TabIndex = 0;
            this.resultBi.Text = "resultadoBinario";
            // 
            // resultDec
            // 
            this.resultDec.AutoSize = true;
            this.resultDec.Location = new System.Drawing.Point(114, 126);
            this.resultDec.Name = "resultDec";
            this.resultDec.Size = new System.Drawing.Size(117, 17);
            this.resultDec.TabIndex = 3;
            this.resultDec.Text = "resultadoDecimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Binário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hexadecimal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Octal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Decimal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label resultHex;
        private System.Windows.Forms.Label resultOct;
        private System.Windows.Forms.Label resultBi;
        private System.Windows.Forms.TextBox valorDigitado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label resultDec;
    }
}

