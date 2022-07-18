using System;
using System.Collections.Generic;
using System.Text;

namespace Projetobanco
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public int Teste;

        public ContaBancaria()
        {

        }

        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        public ContaBancaria(int conta, string nome, double deposito_inicial) : this(conta, nome)
        {
            Deposito(deposito_inicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return ($"Conta :{Conta} \nNome: {Nome} \nSaldo: R$ {Saldo.ToString("F2")} ");

        }


    }
}
