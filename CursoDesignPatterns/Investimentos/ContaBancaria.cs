using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public ContaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = "000-00000";
            this.NumeroConta = "0000000000";
        }

        public ContaBancaria(string titular, double saldo, string agencia, string numeroConta, DateTime dataAbertura)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            Agencia = agencia;
            NumeroConta = numeroConta;
            DataAbertura = dataAbertura;
        }

        public void AdicionaSaldo(double valor)
        {
            this.Saldo += valor;
        }
    }
}
