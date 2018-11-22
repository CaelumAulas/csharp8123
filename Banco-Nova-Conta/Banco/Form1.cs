using System;
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

        private Conta[] contas;
        private int qtdPreenchida;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            // vamos inicializar algumas instâncias de Conta.
            Conta conta1 = new Conta();
            conta1.Titular = new Cliente("victor");
            conta1.Numero = 1;
            AdicionaConta(conta1);

            ContaPoupanca conta2 = new ContaPoupanca();
            conta2.Titular = new Cliente("mauricio");
            conta2.Numero = 2;
            AdicionaConta(conta2);

            ContaCorrente c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            AdicionaConta(c3);
        }

        internal void AdicionaConta(Conta conta)
        {
            contas[qtdPreenchida] = conta;
            qtdPreenchida++;
            comboContas.Items.Add(conta.Titular.Nome);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            string valorEmTexto = textoValor.Text;
            double valor = Convert.ToDouble(valorEmTexto);

            Conta conta = contas[indice];
            conta.Deposita(valor);
            MessageBox.Show("Deposito realizado com sucesso");
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);

            Conta conta = contas[indice];
            bool resultado = conta.Saca(valor);

            if (resultado == true)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.ShowDialog();
        }
    }
}
