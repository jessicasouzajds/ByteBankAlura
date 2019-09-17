using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario    // Herança
    {

        public Diretor(string CPF) : base(5000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // Override sobrepõe o comportamento original do método.
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
