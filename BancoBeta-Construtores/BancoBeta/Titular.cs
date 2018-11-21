using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBeta
{
    class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        //  Titular("Pedro");

        public Titular(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Titular(string nome)
        {
            Nome = nome;
        }

        public Titular()
        {

        }
    }
}
