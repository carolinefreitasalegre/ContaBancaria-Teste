using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Dados
    {
        public int NumeroConta;
        public string NomeTitular;
        public double Saldo;

        public Dados(int numeroConta, string nomeTitular, double depositoInicial = 0)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;

        }


        public void ExibirDados()
        {
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Nome do titular: {NomeTitular}");
            Console.WriteLine($"Saldo: {Saldo:F2}");
        }

        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito no valor de R${valor} irealizado com sucesso.");
        }

        public void RealizarSaque(double valor)
        {
            const double taxa = 5.00;
            Saldo -= ( valor + taxa);
            Console.WriteLine($"Saque no valor de R${valor} realizado com sucesso. Taxa no valoe de R${taxa} foi cobrada!");
        }
    }
}
