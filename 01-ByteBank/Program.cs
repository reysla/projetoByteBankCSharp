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
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 456478);

                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Metodo();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
