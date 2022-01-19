using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override void MontaCabecalho(Banco banco)
        {
            Console.WriteLine("Banco: " + banco.Nome);
            Console.WriteLine("Endereco: " + banco.Endereco);
            Console.WriteLine("Telefone: " + banco.Telefone);
        }

        protected override void MontaCorpo(IList<ContaBancaria> contas)
        {
            foreach (ContaBancaria conta in contas)
            {
                Console.WriteLine("Titular: " + conta.Titular);
                Console.WriteLine("Agencia: " + conta.Agencia);
                Console.WriteLine("Número da conta: " + conta.NumeroConta);
                Console.WriteLine("Saldo: " + conta.Saldo);
            }
        }

        protected override void MontaRodape(Banco banco)
        {
            Console.WriteLine("Email: " + banco.Email);
            Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
