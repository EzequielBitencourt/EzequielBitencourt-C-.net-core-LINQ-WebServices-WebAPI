/*
Laboratório 2 – Arrays
Este laboratório introduz o uso de arrays.
*/

using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplos
            ExArrays exArrays = new ExArrays();
           
            Console.WriteLine("Ex 1:");
            exArrays.Ex1();
            Console.WriteLine("\n");

            Console.WriteLine("Ex 2:");
            exArrays.Ex2();
            Console.WriteLine("\n");

            Console.WriteLine("Ex 3:");
            exArrays.Ex3();
            Console.WriteLine("\n");

            //Exercicio 1
            Exercicio1 exercicio1 = new Exercicio1();

            Console.WriteLine("Exercicio 1:");
            exercicio1.TwoArrays();
        }
    }
}
