using Caelum.Banco.Tributos;

namespace Caelum.Banco.Conta
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            base.Deposita(valor + 0.1);
        }

        public double CalculaTributo()
        {
            return 10;
        }
    }
}
