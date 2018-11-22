using System;

namespace Banco
{
    internal class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public virtual void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public virtual bool Saca(double valor)
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