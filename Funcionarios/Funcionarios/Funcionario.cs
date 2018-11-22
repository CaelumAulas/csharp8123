using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public virtual double CalculaBonificacao()
        {
            double bonificacao = Salario * 0.10;
            return bonificacao;
        }
    }
}
