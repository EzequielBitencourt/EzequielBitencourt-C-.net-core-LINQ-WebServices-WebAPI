using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exemplos
            ContaCorrente minhaConta = new ContaCorrente(340);

            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
            */

            //Exercicio 1
            /*
            ContaCorrenteEx1 minhaContaEx1 = new ContaCorrenteEx1(100,"Ezequiel");

            minhaContaEx4.DadosCliente();
            minhaContaEx4.Depositar(100);
            minhaContaEx4.DadosCliente();
            minhaContaEx4.Sacar(50);
            minhaContaEx4.DadosCliente();
            */

            //Exercicio 2
            /*
            ContaCorrenteEx2 minhaContaEx2 = new ContaCorrenteEx2(100, "Ezequiel");

            minhaContaEx2.DadosCliente();
            minhaContaEx2.Depositar(100);
            minhaContaEx2.DadosCliente();
            minhaContaEx2.Sacar(50);
            minhaContaEx2.DadosCliente();
            minhaContaEx2.SaldoMedio();
            */

            //Exercicio 3
            //3.Escreva um programa que instancia uma conta corrente, executa uma série de operações de depósito e
            //retirada e, por fim, imprime o saldo da conta.
            Console.WriteLine("Digite seu nome : ");
            String nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial : ");
            int saldoInicialCliente = Convert.ToInt32(Console.ReadLine());

            ContaCorrenteEx2 minhaContaEx3 = new ContaCorrenteEx2(saldoInicialCliente,nomeCliente);

            minhaContaEx3.DadosCliente();

            minhaContaEx3.Depositar(100);
            minhaContaEx3.Sacar(50);
            minhaContaEx3.Depositar(1000);
            minhaContaEx3.Sacar(845);
            minhaContaEx3.Depositar(1500);

            minhaContaEx3.DadosCliente();
            minhaContaEx3.SaldoMedio();


        }
    }
}
