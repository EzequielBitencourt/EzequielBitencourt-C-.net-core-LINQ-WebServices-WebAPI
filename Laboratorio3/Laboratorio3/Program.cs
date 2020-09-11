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

            ContaCorrenteEx2 minhaContaEx2 = new ContaCorrenteEx2(100, "Ezequiel");

            minhaContaEx2.DadosCliente();
            minhaContaEx2.Depositar(100);
            minhaContaEx2.DadosCliente();
            minhaContaEx2.Sacar(50);
            minhaContaEx2.DadosCliente();
            minhaContaEx2.SaldoMedio();
        }
    }
}
