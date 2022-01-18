using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            // Se não conseguiu aplicar desconto atual, tenta o próximo
            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
