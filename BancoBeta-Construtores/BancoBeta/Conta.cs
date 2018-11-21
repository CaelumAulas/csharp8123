namespace BancoBeta
{
    class Conta
    {
        public Titular Titular { get; set; }
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
