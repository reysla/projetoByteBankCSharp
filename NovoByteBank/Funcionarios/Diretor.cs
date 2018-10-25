using NovoByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Diretor.");
        }

        public string Senha { get; set; }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.50;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
