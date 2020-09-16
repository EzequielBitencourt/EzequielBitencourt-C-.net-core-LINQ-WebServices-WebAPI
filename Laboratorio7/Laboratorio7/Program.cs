//Laboratório 7 – Interfaces do Framework
//Este laboratório introduz o conceito de implementação de interfaces presentes no .NET.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1

            //string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
            //Console.WriteLine("Array antes da ordenacao");
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    Console.Write(lista[i] + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(lista);
            //Console.WriteLine("Array depois da ordenacao");
            //for (int i = 0; i < lista.Length; i++)
            //{
            //    Console.Write(lista[i] + " ");
            //}

            //Exemplo 2
            //Console.WriteLine();
            //Pessoa pessoa = new Pessoa();

            //Console.WriteLine("Ordenar por nome (1) ou idade (2) ?");
            //int r = Convert.ToInt32(Console.ReadLine());

            //pessoa.metodoOrdenacao(r);

            Pessoa p1 = new Pessoa("Jose", 25);
            Pessoa p2 = new Pessoa("Ana", 28);
            Pessoa p3 = new Pessoa("Paulo", 20);
            Pessoa[] lista2 = {
                p1,
                p2,
                p3
            };

            Console.WriteLine("\nArray Atual");

            for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
            }

            Array.Sort(lista2);

            Console.WriteLine("\nArray depois da ordenacao por idade");

            for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
            }

            //Existe outra interface que poderia ser utilizada para resolver a questão da ordenação? Qual? Mostre como
            //ficaria a solução.
            Console.Write("\n================================================");
            
            //LINQ

            Console.Write("\nOrdenação em LINQ por nome");
            IEnumerable<Pessoa> query = lista2.OrderBy(lista2 => lista2.Nome);


            foreach (Pessoa pessoa2 in query)
            {
                Console.Write("\n{0} - {1}", pessoa2.Nome, pessoa2.Idade);
            }


        }
    }
}
