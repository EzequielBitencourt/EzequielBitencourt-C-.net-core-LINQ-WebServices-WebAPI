using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public class Termometro
    {

        private double temperatura;
        public Termometro()
        {
            temperatura = 0.0;
        }
        public virtual double Temperatura
        {
            get
            {
                return temperatura;
            }
        }
        public virtual void Aumentar(double t)
        {
            temperatura += t;
        }
        public virtual void Diminuir(double t)
        {
            temperatura -= t;
        }
    }
}
