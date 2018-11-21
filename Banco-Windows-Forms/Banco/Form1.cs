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
    }
}
