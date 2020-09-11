//1.Altere a classe ContaCorrente de forma que ela possua atributos para armazenar a data de criação da conta
//e o nome do titular. O nome do titular deve ser informado como parâmetro do construtor. A data de criação
//deve ser gerada no momento da inicialização (DateTime.Now). Crie também propriedades de acesso a estes
//atributos.

using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    class ContaCorrenteEx4
    {
        private decimal saldo;
        private DateTime data;
        private String name;

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

        public ContaCorrenteEx4(decimal valSaldo,String valName)
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
        }

        public void Sacar(decimal val)
        {
            saldo = saldo - val;
        }
    }
}
