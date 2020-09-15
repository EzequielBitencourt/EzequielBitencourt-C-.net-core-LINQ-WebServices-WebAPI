using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio7
{
    public class Pessoa : IComparable<Pessoa>
    {
        private string meuNome;
        private int minhaIdade;
        int x = 0;

        public Pessoa(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }

        public Pessoa()
        {

        }
        public string Nome
        {
            get { return meuNome; }
        }
        public int Idade
        {
            get { return minhaIdade; }
            set { minhaIdade = value; }
        }

        //1.Altere o método CompareTo() da classe Pessoa para que a comparação seja realizada pela idade da
        //pessoa em ordem crescente.
        //public int CompareTo(Pessoa outro)
        //{
        //    return minhaIdade.CompareTo(outro.minhaIdade);
        //}

        //Você conseguiria criar uma classe Pessoa que permitisse ordenar ora por nome, ora pela idade, utilizando
        //a interface IComparable?
        public void metodoOrdenacao(int res)
        {
            x = res;
        }
        public int CompareTo(Pessoa outro)
        {

            if (x == 1)
            {
                return minhaIdade.CompareTo(outro.minhaIdade);
            }
            else if (x == 2)
            {
                return meuNome.CompareTo(outro.meuNome);
            }
            else
            {
                return 0;
            }



        }

    }
}
