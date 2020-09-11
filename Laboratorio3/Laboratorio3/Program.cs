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

            //Exercicio 4
            ContaCorrenteEx4 minhaContaEx4 = new ContaCorrenteEx4(100,"Ezequiel");

            minhaContaEx4.DadosCliente();

        }
    }
}
