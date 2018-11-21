using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBeta
{
    class Conta
    {
        private Titular titular;
        
        public string Agencia { set; get; }
        public int Numero { set; get; }

        public double Saldo { private set; get; }

        public bool Saque(double valor)
        {
            if(valor > Saldo)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - valor;
                return true;
            }
        }

        public void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public bool Transfere(Conta destino, double valor)
        {
            if(Saque(valor) == true)
            {
                destino.Deposita(valor);
                return true;
            }

            return false;
        }
    }
}
