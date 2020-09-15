//Imagine uma classe que possua estado binário e a construa utilizando a interface IEstadoBinario.
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public class Carro : IEstadoBinario
    {
        private bool ligado;
        private double km =0;

        public Carro()
        {
            km = 0; 
        }
        public double Km
        {
            get
            {
                return km;
            }
        }
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public void Acelerar(double k)
        {
            km += k;
        }
        public void Desacelerar(double k)
        {
            km -= k;
        }
        public EstadoBinario Estado
        {
            get
            {
                if (ligado) return EstadoBinario.Ligado;
                else return EstadoBinario.Desligado;
            }
        }

        public void showKm()
        {
            Console.WriteLine(km);
        }
    }
}
