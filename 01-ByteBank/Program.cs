using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf;
            string nome;
            string profissao;

            Console.WriteLine("Total de contas correntes até o momento: " + ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Digite o CPF do Titular da nova conta: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o nome do Titular da nova conta: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a profissão do Titular da nova conta: ");
            profissao = Console.ReadLine();

            Cliente titular = new Cliente(cpf, nome, profissao);
            ContaCorrente conta = new ContaCorrente(titular, 3214, 547861);

            Console.WriteLine("A conta número " + conta.Numero + " foi criada com sucesso!");
            Console.WriteLine("O total de contas correntes foi atualizado para " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
