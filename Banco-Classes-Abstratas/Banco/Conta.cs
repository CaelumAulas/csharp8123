using System;

namespace Banco
{
    internal abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public virtual void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public abstract bool Saca(double valor);
    }
}