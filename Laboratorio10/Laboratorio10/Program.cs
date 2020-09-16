﻿//Laboratório 10 – LINQ to Object
//Este laboratório introduz a manipulação de consultas LINQ sobre coleções de objetos.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
            new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
            new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
            new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false},
            new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
            };
            //Exemplos
            //var linq1 =
            //    from p in pessoas
            //    where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
            //    select p;



            //foreach (var pessoa in linq1)
            //{
            //    Console.WriteLine(pessoa);
            //}

            //var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
            //foreach (var pessoa in linq2)
            //{
            //    Console.WriteLine(pessoa);
            //}


            //Exercicio 1
            //Construa uma consulta que retorne as pessoas agrupadas em casadas e solteiras e também o número de
            //pessoas casadas e solteiras.
            Console.WriteLine("\n============================================");
            Console.WriteLine("\nExercicio 1");
            var linqEx1 = pessoas.Where(p => p.Casada == false || p.Casada == true);
            
            
            foreach (var pessoa in linqEx1)
            {
               Console.WriteLine(pessoa);
            }

            Console.WriteLine("Numero de pessoas casadas : "+linqEx1.Where(p => p.Casada == true).Count());
            Console.WriteLine("Numero de pessoas solteiras :"+linqEx1.Where(p => p.Casada == false).Count());

            //Exercicio 2
            //Construa uma consulta que retorne a pessoa mais velha.
            Console.WriteLine("\n============================================");
            Console.WriteLine("\nExercicio 2");

            var linqEx2 = pessoas.Where(p => p.DataNascimento == pessoas.Min(p => p.DataNascimento));

            Console.WriteLine(linqEx2.FirstOrDefault());

            //Exercicio 3
            //Construa uma consulta que retorne a pessoa solteira mais nova.
            Console.WriteLine("\n============================================");
            Console.WriteLine("\nExercicio 3");

            var linqEx3 = pessoas.Where(p => p.Casada == false && p.DataNascimento == pessoas.Max(p => p.DataNascimento));

            Console.WriteLine(linqEx3.FirstOrDefault());

        }
    }
}
