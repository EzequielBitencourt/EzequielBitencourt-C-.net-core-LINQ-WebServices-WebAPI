﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    public class CirculoColorido : Circulo
    {
        private string minhaCor;
        public CirculoColorido()
        {
            minhaCor = "preto";
        }
        public CirculoColorido(double x, double y, double r, string c)
        : base(x, y, r)
        {
            minhaCor = c;
        }
        public string Cor
        {
            get
            {
                return minhaCor;
            }
            set
            {
                minhaCor = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " cor=" + Cor;
        }

    }
}
