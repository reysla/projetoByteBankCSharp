using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando Diretor.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.20;
        }
    }
}
