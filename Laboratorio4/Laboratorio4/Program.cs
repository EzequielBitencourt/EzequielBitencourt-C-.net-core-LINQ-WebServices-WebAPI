//Laboratório 4 – Classes e Herança
//Este laboratório introduz a herança e sobrescrita de métodos em C#.
using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplos
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
        }
    }
}
