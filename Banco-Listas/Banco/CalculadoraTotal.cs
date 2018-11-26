using Caelum.Banco.Conta;
using System;

namespace Banco
{
    internal class CalculadoraTotal
    {
        public double Total { get; private set; }

        internal void Registra(Conta conta)
        {
            Total = Total + conta.Saldo;
        }
    }
}