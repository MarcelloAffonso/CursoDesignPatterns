using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void AdicionaSaldo(double valor)
        {
            this.Saldo += valor;
        }
    }
}
