using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class ContaCorrente
    {
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agência precisa ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento número precisa ser maior que 0.", nameof(numero));
            }

            this.Agencia = agencia;
            this.Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public static int TotalDeContasCriadas { get; private set; }
        public static int TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }
        private int Agencia { get; }
        private int Numero { get; }
        private double saldo = 100;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                this.saldo = value;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (this.Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this.Saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try {
                Sacar(valor);
            } 
            catch(OperacaoFinanceiraException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}
