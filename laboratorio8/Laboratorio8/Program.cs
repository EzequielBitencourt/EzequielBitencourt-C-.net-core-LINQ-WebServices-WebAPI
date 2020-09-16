//Laboratório 8 – Coleções Genéricas
//Este laboratório introduz o uso de coleções genéricas como listas, filas e
//dicionários.
using System;
using System.Collections.Generic;

namespace laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>();
            Console.WriteLine(listaStrings.Capacity);
            Console.WriteLine(listaStrings.Count);
            listaStrings.Add("Um");
            listaStrings.Add("Hello");
            listaStrings.Add("World");
            Console.WriteLine(listaStrings.Capacity);
            Console.WriteLine(listaStrings.Count);
            Console.WriteLine(listaStrings[2]);
            listaStrings[0] = "Outra";
            Console.WriteLine(listaStrings);
            foreach (var item in listaStrings)
            {
                Console.WriteLine(item);
            }

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises.Add(55,"Brasil");
            paises[44] = "Reino Unido";
            Console.WriteLine(paises[55]);
            Console.WriteLine(paises[44]);
            Console.WriteLine(paises.ContainsValue("Brasil"));
            //Console.WriteLine(paises[1]);
            string umpais;
            if (paises.TryGetValue(55, out umpais)) {
                Console.WriteLine("Achei: " + umpais);
            } else {
                Console.Write("Não achei!");
            }

            Dictionary<int,List<string>> ddi = new Dictionary<int, List<string>>();
        }
    }
}
