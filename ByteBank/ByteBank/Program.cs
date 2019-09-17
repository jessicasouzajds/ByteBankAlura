using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            Funcionario carlos = new Funcionario(2000.0, "567.890.012-34");  // É um funcionario
            carlos.Nome = "Carlos";
            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            
            Diretor roberta = new Diretor("567.098.210-34");
            roberta.Nome = "Roberta";
            roberta.AumentarSalario();

            Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(carlos);
            //gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine();

           // Console.WriteLine("Total bonificação: ");
           // Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
