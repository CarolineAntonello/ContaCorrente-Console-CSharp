using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contacorrente = new ContaCorrente();

            contacorrente.saldo = 1000;
            contacorrente.limite = 100;
            contacorrente.numero_conta = 1556;
            contacorrente.status = "Especial";
            contacorrente.Deposita(500.0);
            contacorrente.Saque(1800.0);

            ContaCorrente conta_1 = new ContaCorrente();
            conta_1.saldo = 2000;

            ContaCorrente conta_2 = new ContaCorrente();
            conta_2.saldo = 1100;

            conta_1.Transferencia(500.0, conta_1, conta_2);

            Console.ReadKey();
        }

        public class ContaCorrente
        {
            public double saldo;
            public double limite;
            public int numero_conta;
            public String status;

            //DEPOSITAR 
            public void Deposita(double valor)
            {
                Console.WriteLine("\n-----DEPOSITO-----");
                Console.WriteLine("\nSaldo Anterior: {0}", this.saldo);

                this.saldo += valor;

                Console.WriteLine("\nDepositado R$ {0}", valor);

                Console.WriteLine("\nSaldo atual: {0}\n", this.saldo);

            }

            //SACAR
            public bool Saque(double valor)
            {
                double total;
                total = this.saldo + this.limite;

                if (total > valor)
                {
                    this.saldo -= valor;
                    Console.WriteLine("\n-----SAQUE-----");
                    Console.WriteLine("\nSaque realizado no valor de: {0}\n", valor);
                    Console.WriteLine("\nSaldo após o saque: {0}\n", this.saldo);
                    return true;
                }
                else
                {
                    Console.WriteLine("\n-----SAQUE-----");
                    Console.WriteLine("\nQuantia a ser sacada: R${0}", valor);
                    Console.WriteLine("\nSaldo insuficiente para saque! \n");
                    return false;
                }

            }

            //TRANSFERIR
            public void Transferencia(double valor, ContaCorrente origem, ContaCorrente destino)
            {

                if (this.saldo > valor)
                {
                    this.saldo -= valor;
                    destino.saldo += valor;

                    Console.WriteLine("\n-----TRANSFERÊNCIA-----");
                    Console.WriteLine("\nTranferência feita no valor de: R${0}", valor);
                    Console.WriteLine("\nSaldo atual da conta que tranferiu: R${0}", saldo);
                    Console.WriteLine("\nSaldo atual da conta que recebeu a tranferência: R${0}", destino.saldo);
                }


            }

        }

    }
}

