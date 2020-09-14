//Laboratório 4 – Classes e Herança
//Este laboratório introduz a herança e sobrescrita de métodos em C#.
using System;
using System.Drawing;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplos
            /*
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
            */


            //Exercicio 1
            //Altere o método Main para mostrar o uso das propriedades do círculo e círculo colorido.É possível
            //utilizar as propriedades CentroX e CentroY em um objeto da classe CirculoColorido ?

            //Console.WriteLine("Insira a coordenada X : ");
            //double cX = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Insira a coordenada Y: ");
            //double cY = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Insira o raio : ");
            //double r = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Insira a cor em ingles : ");
            //String cor = Console.ReadLine();

            //Circulo circ = new Circulo(cX, cY, r);
            //Console.WriteLine(circ);

            //CirculoColorido circ2 = new CirculoColorido(cX, cY, r, "vermelho");
            //Console.WriteLine(circ2);


            //Exercicio 2
            //CirculoColoridoPreenchido circ2 = new CirculoColoridoPreenchido(cX, cY, r, cor);
            //Console.WriteLine(circ2);

            //Exercicio 3
            //Crie uma array de objetos do tipo Circulo e a preencha com instâncias de Circulo, CirculoColorido e
            //CirculoColoridoPreenchido.A seguir, percorra o array e imprima no console os dados de cada um dos
            //objetos.

            Circulo circ1 = new Circulo(2,5,6);
            CirculoColorido circ2 = new CirculoColorido(5, 8, 3, "Red");
            CirculoColoridoPreenchido circ3 = new CirculoColoridoPreenchido(11, 6, 5, "Blue");

            String[] array = new String[3];
            array[0] = circ1.ToString();
            array[1] = circ2.ToString();
            array[2] = circ3.ToString();

            Array.ForEach(array, Console.WriteLine);

        }  
    }
}




