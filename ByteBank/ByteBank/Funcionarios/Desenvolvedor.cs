using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string CPF) : base(3000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        // Override sobrepõe o comportamento original do método.
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

    }
}
