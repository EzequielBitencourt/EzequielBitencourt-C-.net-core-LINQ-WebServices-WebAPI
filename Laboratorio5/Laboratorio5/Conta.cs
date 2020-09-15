using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio5
{
    public abstract class Conta
    {
        private decimal saldo;
        private String titular;

        public Conta(String t)
        {
            titular = t;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public String Titular
        {
            get { return titular; }
        }

        public abstract string Id
       {
            get;
        } 

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }

    }
}
