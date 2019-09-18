using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario  // Existe apenas para ganhar polimorfismo, não é permitido instanciá-la.
    {
        public static int TotalDeFuncionarios { get; private set; }

        // Private < Protected < Public
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public Funcionario(string cPF)
        {
            CPF = cPF;
        }

        // Método virtual: Funcionário cria ele, mas outra classe que sobrepõe esse método pode alterar suas propriedades.
        public abstract void AumentarSalario();  // o método abstrato obriga a classe que herdou este a criar seu próprio método para sobrescrevê-lo

        public abstract double GetBonificacao();

    }
}
// métodos abstratos, apenas em classes abstratas