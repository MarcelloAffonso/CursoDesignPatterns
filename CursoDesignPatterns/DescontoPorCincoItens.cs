using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto ProximoDesconto { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            // Se não conseguiu aplicar desconto atual, tenta o próximo
            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
