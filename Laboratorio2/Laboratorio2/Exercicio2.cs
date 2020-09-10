//2.Escreva um programa que crie uma matriz de valores inteiros (5x5) e retorne o valor da soma de cada
//coluna. Apresente duas versões para o programa: array multidimensional e array jagged.

using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class Exercicio2
    {
        int min = 0;
        int max = 10;
        int cont = 0;

        int[,] arrayM = new int[5, 5]; // Multidimensional
        int[][] arrayJ = new int[5][];//Jagged
        
        

        Random randNum = new Random();

        public void CalculoMatriz()
        {

            Console.WriteLine("Array multidimensional");

            for (int i = 0; i < 5; i++)
             {
                for (int j = 0; j < 5; j++)
                {
                    arrayM[i,j] = randNum.Next(min,max);
                    Console.WriteLine($"Array [{i},{j}] : {arrayM[i, j].ToString()}");

                }
                
            }

            for (int i = 0; i < arrayM.GetLength(1); i++)// colunas
            {
                cont = 0;
                for (int j = 0; j < arrayM.GetLength(0); j++)//linhas
                {
                    cont = cont + arrayM[j, i];
                }
                Console.WriteLine(" Soma da coluna {0} : {1}", i, cont);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("\nArray Jagged");

            arrayJ[0] = new int[5] { 1, 2, 3, 4, 5 };
            arrayJ[1] = new int[5] { 1, 2, 3, 4, 5 };
            arrayJ[3] = new int[5] { 1, 2, 3, 4, 5 };
            arrayJ[4] = new int[5] { 1, 2, 3, 4, 5 };
            arrayJ[5] = new int[5] { 1, 2, 3, 4, 5 };

            

        }
    }
}
