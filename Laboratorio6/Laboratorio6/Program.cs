//Laboratório 6 – Interfaces
//Este laboratório introduz o conceito de definição e implementação de novas interfaces.
using System;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplos

            //IEstadoBinario[] lista = new IEstadoBinario[2];
            //lista[0] = new Lampada(110, 60);
            //lista[0].Ligar();

            //lista[1] = new TermometroEletrico();

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(lista[i].Estado);
            //}


            //Exercicio 1

            IEstadoBinario[] lista = new IEstadoBinario[2];
            lista[0] = new Carro();
            lista[0].Ligar();

            lista[1] = new Carro();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Carro {i}: " + lista[i].Estado);

            }


        }
    }
}
