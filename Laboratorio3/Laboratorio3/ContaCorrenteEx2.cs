//2.Altere a classe ContaCorrente de maneira que ela seja capaz de armazenar o saldo médio do correntista.
//Para tanto, cada vez que os métodos de depósito ou retirada forem acionados o saldo da conta, depois da
//operação, deve ser acumulado e um contador deve ser incrementado. O saldo médio é obtido dividindo-se este
//acumulador pelo número de operações realizadas.

using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    class ContaCorrenteEx2
    {
        private decimal saldo;
        private DateTime data;
        private String name;
        decimal saldoMedio = 0;
        decimal media;
        int cont=0;
        public decimal Saldo
        {
            get { return saldo; }
        }

        public DateTime Data
        {
            get { return data; }
        }

        public String Name
        {
            get { return name; }
        }

        public ContaCorrenteEx2(decimal valSaldo, String valName)
        {
            saldo = valSaldo;
            name = valName;
            data = DateTime.Now;
        }

        public void DadosCliente()
        {
            Console.WriteLine($"Nome: {name} \nSaldo na conta: {saldo}\nData da criação : {data}");
        }

        public void Depositar(decimal val)
        {
            saldo = saldo + val;
            media = media + saldo;
            cont++;
        }

        public void Sacar(decimal val)
        {
            saldo = saldo - val;
            media = media + saldo;
            cont++;
        }
        
        public void SaldoMedio()
        {
            saldoMedio = media / cont;
            Console.WriteLine("Saldo médio da conta : "+saldoMedio.ToString());
        }
    }
}

