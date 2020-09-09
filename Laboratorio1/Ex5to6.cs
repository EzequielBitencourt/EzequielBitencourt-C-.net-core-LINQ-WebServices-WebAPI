using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class Ex5to6
    {
        public void ConversorSys()
        {
            string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);

            Console.WriteLine(valorStringInteiro);

            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);

            Console.WriteLine(valorInt);

            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande); ERRO!!

        }

        public void ConversorTryparse()
        {
            string stringInteiro = "123456789";
            int valorStringInteiro;
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);

            Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);

            Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " +
            valorStringInteiroGrande);

            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);

            Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);
        }
    }
}
