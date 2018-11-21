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
            Titular pedro = new Titular();
            pedro.nome = "Pedro";
            pedro.cpf = "789.678.678-98";

            Conta contaPedro = new Conta();
            // contaPedro.titular = pedro;
            contaPedro.Deposita(500);
            contaPedro.Numero = 345;

            // contaPedro.DefineAgencia("7897-9");
            contaPedro.Agencia = "7897-9";

            MessageBox.Show("Saldo do Pedro: " + contaPedro.Saldo);
            MessageBox.Show("Numero: " + contaPedro.Numero);
            MessageBox.Show("Agencia: " + contaPedro.Agencia);
            // MessageBox.Show("O cpf da conta: " + contaPedro.titular.cpf);
        }
    }
}
