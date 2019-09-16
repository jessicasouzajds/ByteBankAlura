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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();  // É um funcionario
            carlos.Nome = "Carlos";
            carlos.CPF = "567.890.012-34";
            carlos.Salario = 2000.0;
            gerenciador.Registrar(carlos);
            
            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "567.098.210-34";
            roberta.Salario = 5000.0;
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine();

            Console.WriteLine("Total bonificação: ");
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
