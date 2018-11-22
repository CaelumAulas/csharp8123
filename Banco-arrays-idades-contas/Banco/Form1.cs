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
    public partial class Form1 : Form
    {

        private Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente titular = new Cliente("Bruce Wayne");

            conta = new Conta();
            conta.Numero = 123;
            conta.Titular = titular;

            textoTitular.Text = titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorEmTexto = textoValor.Text;
            double valor = Convert.ToDouble(valorEmTexto);
            conta.Deposita(valor);
            MessageBox.Show("Deposito realizado com sucesso");
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textoValor.Text);
            bool resultado = conta.Saca(valor);

            if(resultado == true)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] idades = new int[11];
            idades[0] = 35;
            idades[1] = 25;
            idades[2] = 20;
            idades[3] = 50;
            idades[4] = 18;
            idades[5] = 40;
            idades[6] = 28;
            idades[7] = 19;
            idades[8] = 39;
            idades[9] = 17;
            idades[10] = 55;

            // (idade1 + idade2 + idade3 ... idade10) / 10
            int soma = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                soma = soma + idades[i];
            }

            double media = soma / idades.Length;

            MessageBox.Show("Tamanho do array: " + idades.Length);
            MessageBox.Show("Media: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(100);

            ContaCorrente c2 = new ContaCorrente();
            c2.Deposita(200);

            ContaPoupanca c3 = new ContaPoupanca();
            c3.Deposita(300);

            Conta[] contas = new Conta[3];
            contas[0] = c1;
            contas[1] = c2;
            contas[2] = c3;

            double soma = 0;
            for(int i = 0; i < contas.Length; i++)
            {
                // Conta contaAtual = contas[i];
                soma = soma + contas[i].Saldo;
            }

            MessageBox.Show("Soma: " + soma);
        }
    }
}
