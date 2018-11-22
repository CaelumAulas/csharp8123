namespace Funcionarios
{
    internal class CalculadoraDeBonificacao
    {
        public double Total { get; private set; }

        public void registra(Funcionario f)
        {
            Total = Total + f.CalculaBonificacao();
        }
    }
}