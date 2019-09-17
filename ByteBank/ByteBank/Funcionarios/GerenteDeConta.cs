using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario    // Herança.
    {

        public GerenteDeConta(string CPF) : base(4000, CPF)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;  // Aumento de 5%.
        }

        // Override sobrepõe o comportamento original do método.
        public override double GetBonificacao()
        {
            return Salario * 0.25;  // Bonificação de 25%.
        }
    }
}
