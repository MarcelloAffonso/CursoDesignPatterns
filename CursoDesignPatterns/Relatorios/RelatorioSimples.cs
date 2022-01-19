using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void MontaCabecalho(Banco banco)
        {
            Console.WriteLine("Banco: " + banco.Nome);
        }

        protected override void MontaCorpo(IList<ContaBancaria> contas)
        {
            foreach(ContaBancaria conta in contas)
            {
                Console.WriteLine("Titular: " + conta.Titular);
                Console.WriteLine("Saldo: " + conta.Saldo);
            }            
        }

        protected override void MontaRodape(Banco banco)
        {
            Console.WriteLine("Telefone: " + banco.Telefone);
        }
    }
}
