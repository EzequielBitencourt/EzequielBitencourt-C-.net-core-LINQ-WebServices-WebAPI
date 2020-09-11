using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    public class ContaCorrente
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
        }

        public ContaCorrente(decimal val)
        {
            saldo = val;
        }

        public void Depositar(decimal val)
        {
            saldo = saldo + val;
        }

        public void Sacar(decimal val)
        {
            saldo = saldo - val;
        }
    }
}
