//2.Crie uma subclasse de CirculoColorido chamada CirculoColoridoPreenchido que possui uma cor
//adicional para o preenchimento do círculo. Utilize um objeto mais adequado para armazenar a cor do que
//uma string (procure na API do .NET por essa classe!). Teste a classe criada.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laboratorio4
{
    class CirculoColoridoPreenchido : CirculoColorido
    {
        Color myColor;
        public CirculoColoridoPreenchido(double x, double y, double r, string c)
        : base(x, y, r,c)
        {
             myColor = Color.FromName(c);
        }

        public override string ToString()
        {
            return base.ToString() + myColor;
        }

    }
}
