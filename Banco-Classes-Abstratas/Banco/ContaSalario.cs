using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaSalario : Conta
    {
        public override bool Saca(double valor)
        {
            if (valor > Saldo)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - (valor + 1);
                return true;
            }
        }
    }
}
