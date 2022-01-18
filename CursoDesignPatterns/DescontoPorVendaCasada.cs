using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (AconteceuVendaCasadaEm(orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            return ProximoDesconto.Desconta(orcamento);
        }

        /// <summary>
        /// Verifica se ocorreu a venda casada
        /// </summary>
        private bool AconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
        }

        /// <summary>
        /// Verifica se existe o item com o nome informado
        /// </summary>
        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }

            return false;
        }
    }
}
