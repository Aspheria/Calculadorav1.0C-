namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BAdicao = new System.Windows.Forms.Button();
            this.BSubtracao = new System.Windows.Forms.Button();
            this.bMultiplicacao = new System.Windows.Forms.Button();
            this.bDivisao = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(253, 77);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(129, 22);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(253, 142);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(137, 22);
            this.txtValor2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor2";
            // 
            // BAdicao
            // 
            this.BAdicao.Location = new System.Drawing.Point(46, 64);
            this.BAdicao.Name = "BAdicao";
            this.BAdicao.Size = new System.Drawing.Size(155, 35);
            this.BAdicao.TabIndex = 8;
            this.BAdicao.Text = "Adição";
            this.BAdicao.UseVisualStyleBackColor = true;
            this.BAdicao.Click += new System.EventHandler(this.BAdicao_Click);
            // 
            // BSubtracao
            // 
            this.BSubtracao.Location = new System.Drawing.Point(46, 113);
            this.BSubtracao.Name = "BSubtracao";
            this.BSubtracao.Size = new System.Drawing.Size(155, 35);
            this.BSubtracao.TabIndex = 9;
            this.BSubtracao.Text = "Subtração";
            this.BSubtracao.UseVisualStyleBackColor = true;
            this.BSubtracao.Click += new System.EventHandler(this.BSubtracao_Click);
            // 
            // bMultiplicacao
            // 
            this.bMultiplicacao.Location = new System.Drawing.Point(46, 166);
            this.bMultiplicacao.Name = "bMultiplicacao";
            this.bMultiplicacao.Size = new System.Drawing.Size(155, 35);
            this.bMultiplicacao.TabIndex = 10;
            this.bMultiplicacao.Text = "Multiplicação";
            this.bMultiplicacao.UseVisualStyleBackColor = true;
            this.bMultiplicacao.Click += new System.EventHandler(this.bMultiplicacao_Click);
            // 
            // bDivisao
            // 
            this.bDivisao.Location = new System.Drawing.Point(46, 222);
            this.bDivisao.Name = "bDivisao";
            this.bDivisao.Size = new System.Drawing.Size(155, 35);
            this.bDivisao.TabIndex = 11;
            this.bDivisao.Text = "Divisão";
            this.bDivisao.UseVisualStyleBackColor = true;
            this.bDivisao.Click += new System.EventHandler(this.bdivisao_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(250, 209);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 17);
            this.Resultado.TabIndex = 12;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(257, 193);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(43, 17);
            this.result.TabIndex = 13;
            this.result.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.bDivisao);
            this.Controls.Add(this.bMultiplicacao);
            this.Controls.Add(this.BSubtracao);
            this.Controls.Add(this.BAdicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAdicao;
        private System.Windows.Forms.Button BSubtracao;
        private System.Windows.Forms.Button bMultiplicacao;
        private System.Windows.Forms.Button bDivisao;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label result;
    }
}

