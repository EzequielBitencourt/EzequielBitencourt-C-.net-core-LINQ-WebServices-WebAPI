using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();
            var data = DateTime.Now;

            Console.WriteLine($"Olá {nome}, {data}");
            Console.Write("\nPressione qualquer  tecla para sair");
            Console.ReadKey(true);
        }
    }
}
