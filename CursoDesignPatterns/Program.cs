using CursoDesignPatterns.Investimentos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Orçamento
            Console.WriteLine("Orcamento:");

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
            Console.WriteLine("\nInvestimento:");
            ContaBancaria contaConservador = new ContaBancaria("Jorge", 1000.00);
            Investimento conservador = new Conservador();

            ContaBancaria contaModerado = new ContaBancaria("Lucas", 1000.00);
            Investimento moderado = new Moderado();

            ContaBancaria contaArrojado = new ContaBancaria("Anitta", 1000.00);
            Investimento arrojado = new Arrojado();


            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();

            realizadorDeInvestimentos.RealizaInvestimento(contaConservador, conservador);
            realizadorDeInvestimentos.RealizaInvestimento(contaModerado, moderado);
            realizadorDeInvestimentos.RealizaInvestimento(contaArrojado, arrojado);
            #endregion

            #region Descontos
            Console.WriteLine("\nDescontos:");
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250.0));
            orcamento.AdicionaItem(new Item("FOGÃO", 250.0));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250.0));
            orcamento.AdicionaItem(new Item("XBOX", 250.0));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            #endregion

            #region Requisicao
            Console.WriteLine("\nRequisição:");
            ContaBancaria conta1 = new ContaBancaria("Jorge", 50.00);
            ContaBancaria conta2 = new ContaBancaria("Maisa", 85000.00);
            ContaBancaria conta3 = new ContaBancaria("Jake Peralta", 5.69);

            Requisicao req1 = new Requisicao(Formato.CSV);
            Requisicao req2 = new Requisicao(Formato.XML);
            Requisicao req3 = new Requisicao(Formato.PORCENTO);

            Resposta resp3 = new RespostaEmPorcento();
            Resposta resp2 = new RespostaEmXML(resp3);
            Resposta resp1 = new RespostaEmCSV(resp2);

            resp1.Responde(req1, conta1);
            resp2.Responde(req2, conta2);
            resp3.Responde(req3, conta3);
            #endregion

        }
    }
}
