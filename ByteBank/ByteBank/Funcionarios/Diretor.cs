using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario    // Herança
    {
        // Override sobrepõe o comportamento original do método.
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
