namespace Calculadora2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdSoma = new System.Windows.Forms.RadioButton();
            this.rdSubtracao = new System.Windows.Forms.RadioButton();
            this.rdMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdDivisao = new System.Windows.Forms.RadioButton();
            this.gbCalculadora = new System.Windows.Forms.GroupBox();
            this.rdCalculadora = new System.Windows.Forms.RadioButton();
            this.rdRegrade3 = new System.Windows.Forms.RadioButton();
            this.gbRegrade3 = new System.Windows.Forms.GroupBox();
            this.txtRegra1 = new System.Windows.Forms.TextBox();
            this.txtRegra2 = new System.Windows.Forms.TextBox();
            this.txtRegra3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbCalculadora.SuspendLayout();
            this.gbRegrade3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(6, 101);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(242, 45);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(6, 152);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(242, 45);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALCULATRIX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(138, 338);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(254, 60);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdSoma
            // 
            this.rdSoma.AutoSize = true;
            this.rdSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSoma.Location = new System.Drawing.Point(6, 22);
            this.rdSoma.Name = "rdSoma";
            this.rdSoma.Size = new System.Drawing.Size(61, 20);
            this.rdSoma.TabIndex = 4;
            this.rdSoma.TabStop = true;
            this.rdSoma.Text = "Soma";
            this.rdSoma.UseVisualStyleBackColor = true;
            // 
            // rdSubtracao
            // 
            this.rdSubtracao.AutoSize = true;
            this.rdSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSubtracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSubtracao.Location = new System.Drawing.Point(6, 45);
            this.rdSubtracao.Name = "rdSubtracao";
            this.rdSubtracao.Size = new System.Drawing.Size(87, 20);
            this.rdSubtracao.TabIndex = 5;
            this.rdSubtracao.TabStop = true;
            this.rdSubtracao.Text = "Subtração";
            this.rdSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdMultiplicacao
            // 
            this.rdMultiplicacao.AutoSize = true;
            this.rdMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultiplicacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdMultiplicacao.Location = new System.Drawing.Point(137, 22);
            this.rdMultiplicacao.Name = "rdMultiplicacao";
            this.rdMultiplicacao.Size = new System.Drawing.Size(104, 20);
            this.rdMultiplicacao.TabIndex = 6;
            this.rdMultiplicacao.TabStop = true;
            this.rdMultiplicacao.Text = "Multiplicação";
            this.rdMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdDivisao
            // 
            this.rdDivisao.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.rdDivisao.AutoSize = true;
            this.rdDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDivisao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdDivisao.Location = new System.Drawing.Point(137, 45);
            this.rdDivisao.Name = "rdDivisao";
            this.rdDivisao.Size = new System.Drawing.Size(71, 20);
            this.rdDivisao.TabIndex = 7;
            this.rdDivisao.TabStop = true;
            this.rdDivisao.Text = "Divisão";
            this.rdDivisao.UseVisualStyleBackColor = true;
            // 
            // gbCalculadora
            // 
            this.gbCalculadora.Controls.Add(this.txtNum2);
            this.gbCalculadora.Controls.Add(this.rdDivisao);
            this.gbCalculadora.Controls.Add(this.txtNum1);
            this.gbCalculadora.Controls.Add(this.rdMultiplicacao);
            this.gbCalculadora.Controls.Add(this.rdSoma);
            this.gbCalculadora.Controls.Add(this.rdSubtracao);
            this.gbCalculadora.ForeColor = System.Drawing.Color.Aqua;
            this.gbCalculadora.Location = new System.Drawing.Point(14, 106);
            this.gbCalculadora.Name = "gbCalculadora";
            this.gbCalculadora.Size = new System.Drawing.Size(254, 204);
            this.gbCalculadora.TabIndex = 8;
            this.gbCalculadora.TabStop = false;
            this.gbCalculadora.Text = "Calculadora";
            this.gbCalculadora.Visible = false;
            // 
            // rdCalculadora
            // 
            this.rdCalculadora.AutoSize = true;
            this.rdCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCalculadora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdCalculadora.Location = new System.Drawing.Point(14, 70);
            this.rdCalculadora.Name = "rdCalculadora";
            this.rdCalculadora.Size = new System.Drawing.Size(98, 20);
            this.rdCalculadora.TabIndex = 9;
            this.rdCalculadora.TabStop = true;
            this.rdCalculadora.Text = "Calculadora";
            this.rdCalculadora.UseVisualStyleBackColor = true;
            this.rdCalculadora.CheckedChanged += new System.EventHandler(this.rdCalculadora_CheckedChanged);
            // 
            // rdRegrade3
            // 
            this.rdRegrade3.AutoSize = true;
            this.rdRegrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRegrade3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdRegrade3.Location = new System.Drawing.Point(274, 70);
            this.rdRegrade3.Name = "rdRegrade3";
            this.rdRegrade3.Size = new System.Drawing.Size(92, 20);
            this.rdRegrade3.TabIndex = 10;
            this.rdRegrade3.TabStop = true;
            this.rdRegrade3.Text = "Regra de 3";
            this.rdRegrade3.UseVisualStyleBackColor = true;
            this.rdRegrade3.CheckedChanged += new System.EventHandler(this.rdRegrade3_CheckedChanged);
            // 
            // gbRegrade3
            // 
            this.gbRegrade3.Controls.Add(this.label4);
            this.gbRegrade3.Controls.Add(this.label3);
            this.gbRegrade3.Controls.Add(this.label2);
            this.gbRegrade3.Controls.Add(this.txtRegra3);
            this.gbRegrade3.Controls.Add(this.txtRegra2);
            this.gbRegrade3.Controls.Add(this.txtRegra1);
            this.gbRegrade3.ForeColor = System.Drawing.Color.Aqua;
            this.gbRegrade3.Location = new System.Drawing.Point(274, 106);
            this.gbRegrade3.Name = "gbRegrade3";
            this.gbRegrade3.Size = new System.Drawing.Size(254, 204);
            this.gbRegrade3.TabIndex = 11;
            this.gbRegrade3.TabStop = false;
            this.gbRegrade3.Text = "Regra de 3";
            this.gbRegrade3.Visible = false;
            // 
            // txtRegra1
            // 
            this.txtRegra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegra1.Location = new System.Drawing.Point(7, 49);
            this.txtRegra1.Multiline = true;
            this.txtRegra1.Name = "txtRegra1";
            this.txtRegra1.Size = new System.Drawing.Size(86, 32);
            this.txtRegra1.TabIndex = 0;
            this.txtRegra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegra2
            // 
            this.txtRegra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegra2.Location = new System.Drawing.Point(143, 48);
            this.txtRegra2.Multiline = true;
            this.txtRegra2.Name = "txtRegra2";
            this.txtRegra2.Size = new System.Drawing.Size(86, 32);
            this.txtRegra2.TabIndex = 1;
            this.txtRegra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegra3
            // 
            this.txtRegra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegra3.Location = new System.Drawing.Point(7, 114);
            this.txtRegra3.Multiline = true;
            this.txtRegra3.Name = "txtRegra3";
            this.txtRegra3.Size = new System.Drawing.Size(86, 32);
            this.txtRegra3.TabIndex = 2;
            this.txtRegra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "______";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(161, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Yellow;
            this.lblResultado.Location = new System.Drawing.Point(253, 413);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 39);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.gbRegrade3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rdRegrade3);
            this.Controls.Add(this.rdCalculadora);
            this.Controls.Add(this.gbCalculadora);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculatrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCalculadora.ResumeLayout(false);
            this.gbCalculadora.PerformLayout();
            this.gbRegrade3.ResumeLayout(false);
            this.gbRegrade3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtNum1;
        internal System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdSoma;
        private System.Windows.Forms.RadioButton rdSubtracao;
        private System.Windows.Forms.RadioButton rdMultiplicacao;
        private System.Windows.Forms.RadioButton rdDivisao;
        private System.Windows.Forms.GroupBox gbCalculadora;
        private System.Windows.Forms.RadioButton rdCalculadora;
        private System.Windows.Forms.RadioButton rdRegrade3;
        private System.Windows.Forms.GroupBox gbRegrade3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegra3;
        private System.Windows.Forms.TextBox txtRegra2;
        private System.Windows.Forms.TextBox txtRegra1;
        private System.Windows.Forms.Label lblResultado;
    }
}

