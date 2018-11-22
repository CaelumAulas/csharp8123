using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario joao = new Funcionario();
            joao.Nome = "Joao";
            joao.Salario = 4000;

            Gerente jose = new Gerente();
            jose.Nome = "Jose";
            jose.Salario = 5000;
            jose.Senha = "123A";

            Secretario thiago = new Secretario();
            thiago.Nome = "Thiago";
            thiago.Salario = 4500;
            thiago.Ramal = "79869-7686";

            CalculadoraDeBonificacao calculadora = new CalculadoraDeBonificacao();
            calculadora.registra(joao);
            calculadora.registra(jose);
            calculadora.registra(thiago);

            MessageBox.Show("Total de bonificação: " + calculadora.Total);

            /*MessageBox.Show("Bonificaçao do Joao: " + joao.CalculaBonificacao());
            MessageBox.Show("Bonificação do José: " + jose.CalculaBonificacao());
            MessageBox.Show("Bonificação do José: " + thiago.CalculaBonificacao());*/
        }
    }
}
