using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Cliente
    {
        public Cliente(string cpf, string nome, string profissao)
        {
            this.cpf = cpf;
            this.Nome = nome;
            this.Profissao = profissao;
        }

        private string cpf;
        public string Nome { get; set; }
        public string Profissao { get; set; }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                // aqui viria alguma validação para o cpf
                cpf = value;
            }
        }

    }
}
