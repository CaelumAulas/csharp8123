namespace Banco
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.botaoRelatorio = new System.Windows.Forms.Button();
            this.botaoTributos = new System.Windows.Forms.Button();
            this.botaoTestaIgualdade = new System.Windows.Forms.Button();
            this.botaoLista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(110, 61);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(149, 22);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(110, 101);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(149, 22);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(110, 139);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(149, 22);
            this.textoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(82, 214);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(85, 36);
            this.botaoDeposito.TabIndex = 8;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(110, 177);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(149, 22);
            this.textoValor.TabIndex = 3;
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(173, 214);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(86, 36);
            this.botaoSaque.TabIndex = 9;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(13, 13);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(246, 24);
            this.comboContas.TabIndex = 13;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(82, 256);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(176, 33);
            this.botaoCadastro.TabIndex = 14;
            this.botaoCadastro.Text = "Cadastrar nova conta";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // botaoRelatorio
            // 
            this.botaoRelatorio.Location = new System.Drawing.Point(149, 311);
            this.botaoRelatorio.Name = "botaoRelatorio";
            this.botaoRelatorio.Size = new System.Drawing.Size(108, 39);
            this.botaoRelatorio.TabIndex = 15;
            this.botaoRelatorio.Text = "Relatorio total";
            this.botaoRelatorio.UseVisualStyleBackColor = true;
            this.botaoRelatorio.Click += new System.EventHandler(this.botaoRelatorio_Click);
            // 
            // botaoTributos
            // 
            this.botaoTributos.Location = new System.Drawing.Point(38, 311);
            this.botaoTributos.Name = "botaoTributos";
            this.botaoTributos.Size = new System.Drawing.Size(107, 39);
            this.botaoTributos.TabIndex = 16;
            this.botaoTributos.Text = "Tributos";
            this.botaoTributos.UseVisualStyleBackColor = true;
            this.botaoTributos.Click += new System.EventHandler(this.botaoTributos_Click);
            // 
            // botaoTestaIgualdade
            // 
            this.botaoTestaIgualdade.Location = new System.Drawing.Point(38, 356);
            this.botaoTestaIgualdade.Name = "botaoTestaIgualdade";
            this.botaoTestaIgualdade.Size = new System.Drawing.Size(218, 37);
            this.botaoTestaIgualdade.TabIndex = 17;
            this.botaoTestaIgualdade.Text = "Testa Igualdade";
            this.botaoTestaIgualdade.UseVisualStyleBackColor = true;
            this.botaoTestaIgualdade.Click += new System.EventHandler(this.botaoTestaIgualdade_Click);
            // 
            // botaoLista
            // 
            this.botaoLista.Location = new System.Drawing.Point(38, 399);
            this.botaoLista.Name = "botaoLista";
            this.botaoLista.Size = new System.Drawing.Size(218, 38);
            this.botaoLista.TabIndex = 18;
            this.botaoLista.Text = "Testa Lista";
            this.botaoLista.UseVisualStyleBackColor = true;
            this.botaoLista.Click += new System.EventHandler(this.botaoLista_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoLista);
            this.Controls.Add(this.botaoTestaIgualdade);
            this.Controls.Add(this.botaoTributos);
            this.Controls.Add(this.botaoRelatorio);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.botaoDeposito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.Button botaoRelatorio;
        private System.Windows.Forms.Button botaoTributos;
        private System.Windows.Forms.Button botaoTestaIgualdade;
        private System.Windows.Forms.Button botaoLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

