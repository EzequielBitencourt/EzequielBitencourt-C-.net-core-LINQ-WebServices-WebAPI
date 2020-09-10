using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            var nome = Console.ReadLine();

            var data = DateTime.Now;
            Console.WriteLine($"\nAlô,{nome}, em {data:d} as {data:t}");
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);

        }
    }
}
