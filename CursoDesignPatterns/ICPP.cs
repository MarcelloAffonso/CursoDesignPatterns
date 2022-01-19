using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        /// <summary>
        /// Regra para máxima taxação: orçamento é maior ou igual a 500 reais
        /// </summary>
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        /// <summary>
        /// Máxima taxação é 7%
        /// </summary>
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        /// <summary>
        /// Máxima taxação é 5%
        /// </summary>
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
