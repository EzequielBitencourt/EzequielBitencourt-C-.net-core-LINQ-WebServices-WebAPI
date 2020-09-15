//Laboratório 7 – Interfaces do Framework
//Este laboratório introduz o conceito de implementação de interfaces presentes no .NET.
using System;
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
            Console.WriteLine();
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Ordenar por nome (1) ou idade (2) ?");
            int r = Convert.ToInt32(Console.ReadLine());

            pessoa.metodoOrdenacao(r);

            Pessoa p1 = new Pessoa("Jose", 25);
            Pessoa p2 = new Pessoa("Ana", 28);
            Pessoa p3 = new Pessoa("Paulo", 20);
            Pessoa[] lista2 = {
                p1,
                p2,
                p3
            };
           
            Array.Sort(lista2);
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
            }

            //Existe outra interface que poderia ser utilizada para resolver a questão da ordenação? Qual? Mostre como
            //ficaria a solução.

            //LINQ
            Console.Write(lista2.OrderBy(pessoa => pessoa.Nome).ThenBy(pessoa => pessoa.Nome));
            
        }
    }
}
