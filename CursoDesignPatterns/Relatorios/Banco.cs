using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Relatorios
{
    public class Banco
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public IList<ContaBancaria> Contas { get; private set; }

        public Banco(string nome, string endereco, string telefone, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            this.Contas = new List<ContaBancaria>();
        }

        public void AdicionaConta(ContaBancaria conta)
        {
            this.Contas.Add(conta);
        }
    }
}
