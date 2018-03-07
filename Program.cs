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
                Console.WriteLine("Saldo Anterior: {0}", this.saldo);

                this.saldo += valor;

                Console.WriteLine("\nDepositado R$ {0}", valor);

                Console.Write("\nSaldo atual: {0}\n", this.saldo);

            }

            //SACAR
            public bool Saque(double valor)
            {
                double total;
                total = this.saldo + this.limite;

                if (total > valor)
                {
                    this.saldo -= valor;
                    Console.Write("\nSaque realizado no valor de: {0}\n", valor);
                    Console.Write("\nSaldo após o saque: {0}\n", this.saldo);
                    return true;
                }
                else
                {
                    Console.WriteLine("\nQuantia a ser sacada: R$ {0}", valor);
                    Console.Write("\nSaldo insuficiente para saque! \n");
                    return false;
                }

            }

        }

    }
}

