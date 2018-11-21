using System;

namespace Banco
{
    internal class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        internal bool Saca(double valor)
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
    }
}