using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void AdicionaSaldo(double valor)
        {
            this.Saldo += valor;
        }
    }
}
