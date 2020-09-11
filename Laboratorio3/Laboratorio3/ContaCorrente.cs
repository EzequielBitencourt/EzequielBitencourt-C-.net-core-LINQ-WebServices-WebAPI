using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    public class ContaCorrente
    {
        private decimal saldo;

        public void Depositar(decimal val)
        {
            saldo = saldo + val;
        }
    }
}
