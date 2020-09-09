using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class Ex4
    {
        DateTime dt = new DateTime(2020,09,09,10,3,0);
        double temp = 20.0;
        public void StringDia()
        {
            String dia = "Hoje é " + DateTime.Now.ToString();
            Console.WriteLine(dia);

            String diaEtempo = String.Format("As {0:t} de {0:D} a temperatura foi de {1:F1}° celcius",dt,temp);
            Console.WriteLine(diaEtempo);

        }


        public void Conversor()
        {
            int i = 10;
            float f = 0;

            f = i; //conversão implícita, sem perda de dados.
            System.Console.WriteLine(f);
            f = 0.5F;
            i = (int)f; //conversão explícita, com perda de dados.
            System.Console.WriteLine(i);
        }


       

    }
}
