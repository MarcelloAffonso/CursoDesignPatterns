using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        /// <summary>
        /// Regra para máxima taxação: orçamento é maior que 500 reais e tem pelo menos um item com valor maior que 100 reais
        /// </summary>
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
        }

        /// <summary>
        /// Máxima taxação é 10%
        /// </summary>
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        /// <summary>
        /// Máxima taxação é 6%
        /// </summary>
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        /// <summary>
        /// Verifica se existe um item dentro do orçamento que tem valor maior que 100.00 reais
        /// </summary>
        private bool TemItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
