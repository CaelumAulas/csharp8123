using Caelum.Banco.Tributos;

namespace Banco
{
    internal class SeguroDeVida : ITributavel
    {
        public double Valor { get; set; }

        public double CalculaTributo()
        {
            return 42;
        }
    }
}