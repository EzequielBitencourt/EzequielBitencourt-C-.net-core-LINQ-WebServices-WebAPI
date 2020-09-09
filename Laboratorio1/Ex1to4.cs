using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class Ex1to4
    {
        public void Ex()
        {
            byte b;
            int i;
            long l;


            String primeira = "Alo ";
            String segunda = "mundo";
            String terceira = primeira + segunda;

            int cchTamanho = terceira.Length;
            String quarta = "Tamanho = " + cchTamanho.ToString();

            l = long.MaxValue;
            i = int.MaxValue;
            b = byte.MaxValue;

            DateTime dt = new DateTime(2020, 09, 09);//ANO,MES,DIA
            String quinta = dt.ToString();

            Console.WriteLine("Valor maximo de um byte " + b);
            Console.WriteLine($"Valor maximo de um byte {b}");
            Console.WriteLine("Valor maximo de um byte " + i);
            Console.WriteLine("Valor maximo de um byte " + l);
            Console.WriteLine(terceira);
            Console.WriteLine(quarta);
            Console.WriteLine(terceira.Substring(0, 5));
            Console.WriteLine(quinta);
        }
    }
}
