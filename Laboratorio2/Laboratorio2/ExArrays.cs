using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    class ExArrays
    {
        //Imprimindo todos os valores de um array de inteiros com um for
        public void Ex1()
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }

        }

        //Imprimindo todos os valores de um array de strings com um for
        public void Ex2()
        {
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }
        }

        //Imprimindo todos os valores de um array de DateTipe com um for ou foreach
        public void Ex3()
        {
            DateTime[] dt = new DateTime[2];
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            /* for (iDate = 0; iDate < 2; iDate++)
             {
                 Console.WriteLine("Indice = " + iDate + " & Data = " +
                 dt[iDate].ToShortDateString());
             }*/

            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }

        }
    }
}
