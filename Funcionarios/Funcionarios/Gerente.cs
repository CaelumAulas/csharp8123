using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Gerente : Funcionario
    {
        public string Senha { get; set; }

        public override double CalculaBonificacao()
        {
            return Salario * 0.12 + 500;
        }
    }
}
