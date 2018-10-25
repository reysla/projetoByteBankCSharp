using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
