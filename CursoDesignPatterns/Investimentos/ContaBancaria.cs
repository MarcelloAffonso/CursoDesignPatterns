using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// As duas classes de estado foram colocadas internamente para não vazar o encapsulamento e manter o saldo da conta como private.
    /// </summary>
    public class ContaBancaria
    {
        #region Conta positivada
        public class ContaPositivada : EstadoDeUmaConta
        {
            public void RealizaSaque(ContaBancaria conta, double valor)
            {
                if (valor > 0)
                {
                    // Retira o valor da conta pois foi sacado
                    conta.Saldo -= valor;

                    // Se o saldo for menor que 0, a conta passa a ser negativada
                    if (conta.Saldo < 0)
                    {
                        conta.EstadoConta = new ContaNegativada();
                    }
                }
                else
                {
                    throw new Exception("Não se pode sacar um valor negativo!");
                }
            }

            public void RealizaDeposito(ContaBancaria conta, double valor)
            {
                if (valor > 0)
                {
                    conta.Saldo = conta.Saldo + (valor * 0.98);
                }
                else
                {
                    throw new Exception("Não se pode depositar um valor negativo!");
                }

            }
        }
        #endregion

        #region Conta negativada
        public class ContaNegativada : EstadoDeUmaConta
        {
            public void RealizaSaque(ContaBancaria conta, double valor)
            {
                // Conta negativada não pode sacar
                throw new Exception("Conta negativada, não foi possível realizar o saque!");
            }

            public void RealizaDeposito(ContaBancaria conta, double valor)
            {
                if (valor > 0)
                {
                    conta.Saldo = conta.Saldo + (valor * 0.95);

                    if (conta.Saldo > 0)
                    {
                        conta.EstadoConta = new ContaPositivada();
                    }
                }
                else
                {
                    throw new Exception("Não se pode depositar um valor negativo!");
                }

            }
        }
        #endregion

        #region Propriedades
        public EstadoDeUmaConta EstadoConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }
        public DateTime DataAbertura { get; private set; }
        #endregion

        #region Construtores
        public ContaBancaria(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Agencia = "000-00000";
            this.NumeroConta = "0000000000";

            if (saldo > 0)
            {
                this.EstadoConta = new ContaPositivada();
            }
            else
            {
                this.EstadoConta = new ContaNegativada();
            }
        }

        public ContaBancaria(string titular, double saldo, string agencia, string numeroConta, DateTime dataAbertura)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            Agencia = agencia;
            NumeroConta = numeroConta;
            DataAbertura = dataAbertura;

            if (this.Saldo > 0)
            {
                this.EstadoConta = new ContaPositivada();
            }
            else
            {
                this.EstadoConta = new ContaNegativada();
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Passa para o estado o valor a ser depositado e deposita na conta, seguinda as regras de cada estado
        /// </summary>
        public void Deposita(double valor)
        {
            this.EstadoConta.RealizaDeposito(this, valor);
        }

        /// <summary>
        /// Passa para o estado o valor a ser sacado e tenta sacar da conta, seguinda as regras de cada estado
        /// </summary>
        public void Saca(double valor)
        {
            this.EstadoConta.RealizaSaque(this, valor);
        } 
        #endregion
    }
}
