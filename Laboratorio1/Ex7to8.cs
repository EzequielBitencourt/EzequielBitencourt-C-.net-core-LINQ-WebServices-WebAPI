using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class Ex7to8
    {
        public void Arredondamento()
        {
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);

            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
        }

        public void Exibicao()
        {
            int x = 10;
            double y = 3.4;
            Console.WriteLine("{0} {1}", x, y);
        }
    }
}
