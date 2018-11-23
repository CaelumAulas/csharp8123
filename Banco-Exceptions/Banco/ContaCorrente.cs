using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
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
