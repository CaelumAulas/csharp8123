﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastro : Form
    {
        private readonly Form1 form1;

        public FormCadastro(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            Cliente titular = new Cliente(textoTitular.Text);
            Conta conta = new Conta();
            conta.Titular = titular;
            conta.Numero = Convert.ToInt32(textoNumero.Text);

            form1.AdicionaConta(conta);

            Dispose();
        }
    }
}
