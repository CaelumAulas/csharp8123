using System;
using Banco;
using Caelum.Banco.Clientes;

namespace Caelum.Banco.Conta
{
    internal class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        
        public virtual void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public virtual void Saca(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor Negativo");
            }
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Conta))
            {
                return false;
            }

            Conta outraConta = (Conta) obj;

            if(this.Numero == outraConta.Numero)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return Titular.Nome + " - " + Numero;
        }
    }
}