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
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()  // Métodos estáticos não podem chamar métodos não estáticos.
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario fabricio = new Designer("088.456.123-87");
            fabricio.Nome = "Fabricio";

            Funcionario roberta = new Diretor("048.456.125-66");
            roberta.Nome = "Roberta";

            Funcionario carlos = new Auxiliar("083.356.153-67");
            carlos.Nome = "Carlos";

            Funcionario richard = new GerenteDeConta("388.266.143-88");
            richard.Nome = "Richard";

            gerenciador.Registrar(fabricio);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(richard);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

        }
    }
}
