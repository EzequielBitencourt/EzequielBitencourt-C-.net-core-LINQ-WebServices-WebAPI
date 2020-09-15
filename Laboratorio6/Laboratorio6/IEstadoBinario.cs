using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public enum EstadoBinario { Ligado, Desligado };
    interface IEstadoBinario
    {
        void Ligar();
        void Desligar();
        EstadoBinario Estado { get; }
    }
}
