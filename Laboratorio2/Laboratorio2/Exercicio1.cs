//1.Faça um programa que crie dois arrays de tamanho iguais de números inteiros (digamos 100 elementos
//cada). Popule um dos arrays com diversos valores e deixe o outro array vazio. Agora, realize a cópia dos
//elementos do primeiro array para o segundo.

using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class Exercicio1
    {
        //int min = 0;  
        //int max = 100;

        int[] arr1 = new int[100];
        int[] arr2 = new int[100];

        Random randNum = new Random();
        public void TwoArrays()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                //arr1[i] = randNum.Next(min,max);
                arr1[i] = randNum.Next();
                Console.WriteLine($"Array 1 : {arr1[i].ToString()}");
            }

            Console.WriteLine("==========================================");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                Console.WriteLine($"Array 2 : {arr2[i].ToString()}");
            }

        }
    }
}
