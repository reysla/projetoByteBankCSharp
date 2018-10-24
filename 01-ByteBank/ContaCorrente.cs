using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class ContaCorrente
    {
        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            this.Titular = Titular;
            this.agencia = agencia;
            this.Numero = numero;

            TotalDeContasCriadas++;
        }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }
        private int agencia;
        private int numero;
        private double saldo = 100;

        public int Agencia
        {
            get
            {
                return this.agencia;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }

                this.agencia = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                this.numero = value;
            }
        }

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

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
