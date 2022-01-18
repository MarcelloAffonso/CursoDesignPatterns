using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto desconto1 = new DescontoPorCincoItens();
            Desconto desconto2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto desconto3 = new DescontoPorVendaCasada();
            Desconto desconto4 = new SemDesconto();

            desconto1.ProximoDesconto = desconto2;
            desconto2.ProximoDesconto = desconto3;
            desconto3.ProximoDesconto = desconto4;
            return desconto1.Desconta(orcamento);

        }

    }
}
