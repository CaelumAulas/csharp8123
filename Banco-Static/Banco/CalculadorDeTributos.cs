using System;

namespace Banco
{
    internal class CalculadorDeTributos
    {

        public double Total { get; set; }

        internal void Registra(ITributavel tributo)
        {
            Total = Total + tributo.CalculaTributo();
        }
    }
}
