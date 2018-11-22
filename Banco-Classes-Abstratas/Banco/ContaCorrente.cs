using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta
    {
        public override bool Saca(double valor)
        {
            if (valor > Saldo)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - (valor + 0.8);
                return true;
            }
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor + 0.1);
        }
    }
}
