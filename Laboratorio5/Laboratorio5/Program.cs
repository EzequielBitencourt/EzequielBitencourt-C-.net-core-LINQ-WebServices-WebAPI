//Laboratório 5 – Classes Abstratas
//Este laboratório introduz o processo de derivação de classes em C# via herança e sobrescrita de
//métodos e propriedades de uma classe abstrata.

using System;
using System.Collections.Generic;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            //Escreva um programa que crie vários tipos de conta e teste cada um dos métodos e propriedades
            //desenvolvidos.
            List<Conta> contas = new List<Conta>();
           
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(0.12M,new DateTime(2020,9,15),"Ezequiel");
            ContaPoupanca contaPoupanca2 = new ContaPoupanca(0.12M, new DateTime(2020, 10, 15), "Julio");
            ContaPoupanca contaPoupanca3 = new ContaPoupanca(0.12M, new DateTime(2020, 11, 15), "Ana");

            contas.Add(contaPoupanca1);
            contas.Add(contaPoupanca2);
            contas.Add(contaPoupanca3);

            foreach (var item in contas)
            {
                Console.WriteLine($"{item.Id} : {item.Saldo}");
            }
            Console.WriteLine($"============================================");
            contaPoupanca1.Depositar(1000);
            contaPoupanca2.Depositar(10000);
            contaPoupanca3.Depositar(100);

            foreach (var item in contas)
            {
                Console.WriteLine($"{item.Id} : {item.Saldo}");
            }

            Console.WriteLine($"============================================");
            contaPoupanca1.Sacar(500);
            contaPoupanca2.Sacar(9999);
            contaPoupanca3.Sacar(50);

            foreach (var item in contas)
            {
                Console.WriteLine($"{item.Id} : {item.Saldo}");
            }

            Console.WriteLine($"============================================");
            contaPoupanca1.AdicionarRendimento();
            contaPoupanca2.AdicionarRendimento();
            contaPoupanca3.AdicionarRendimento();

            foreach (var item in contas)
            {
                Console.WriteLine($"{item.Id} : {item.Saldo}");
            }


        }
    }
}
