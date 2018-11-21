using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Titular pedro = new Titular("Pedro");
            MessageBox.Show("Nome: " + pedro.Nome);
            pedro.Cpf = "789.678.678-98";

            Conta contaPedro = new Conta();

            contaPedro.Saque(800);

            contaPedro.Titular = pedro;
            contaPedro.Deposita(500);
            contaPedro.Numero = 345;
            contaPedro.Agencia = "7897-9";

            /*MessageBox.Show("Saldo do Pedro: " + contaPedro.Saldo);
            MessageBox.Show("Numero: " + contaPedro.Numero);
            MessageBox.Show("Agencia: " + contaPedro.Agencia);*/

            Titular joao = new Titular() {
                Nome = "Joao",
                Cpf = "789.789.789-08"
            };

            Titular ana = new Titular("Ana", "789.6789.794-98");
        }
    }
}
