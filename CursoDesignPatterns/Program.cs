using CursoDesignPatterns.Investimentos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Orçamento
            Orcamento orcamento1 = new Orcamento(500.0);

            Imposto icms = new ICMS();
            Imposto iss = new ISS();

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();

            calculadora.RealizaCalculo(orcamento1, icms);
            calculadora.RealizaCalculo(orcamento1, iss);

            #region ICCC - Atividade 6
            Imposto iccc = new ICCC();

            // Deve retornar 25.00
            calculadora.RealizaCalculo(orcamento1, iccc);

            Orcamento orcamento2 = new Orcamento(1000.0);
            // Deve retornar 70.00
            calculadora.RealizaCalculo(orcamento2, iccc);

            // Deve retornar 210.00
            Orcamento orcamento3 = new Orcamento(3000.0);
            calculadora.RealizaCalculo(orcamento3, iccc);

            // Deve retornar 350.00
            Orcamento orcamento4 = new Orcamento(4000.0);
            calculadora.RealizaCalculo(orcamento4, iccc);
            #endregion
            #endregion

            #region Investimento
            ContaBancaria contaConservador = new ContaBancaria(1000.00);
            Investimento conservador = new Conservador();

            ContaBancaria contaModerado = new ContaBancaria(1000.00);
            Investimento moderado = new Moderado();

            ContaBancaria contaArrojado = new ContaBancaria(1000.00);
            Investimento arrojado = new Arrojado();


            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();

            realizadorDeInvestimentos.RealizaInvestimento(contaConservador, conservador);
            realizadorDeInvestimentos.RealizaInvestimento(contaModerado, moderado);
            realizadorDeInvestimentos.RealizaInvestimento(contaArrojado, arrojado); 
            #endregion

        }
    }
}
