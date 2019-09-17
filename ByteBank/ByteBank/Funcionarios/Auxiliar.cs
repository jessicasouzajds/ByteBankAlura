using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string CPF) : base(2000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        // Override sobrepõe o comportamento original do método.
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
