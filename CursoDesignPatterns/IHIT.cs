using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        /// <summary>
        /// Regra para máxima taxação: orçamento possui dois itens com o mesmo nome
        /// </summary>
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return TemDoisItensComMesmoNome(orcamento);
        }

        /// <summary>
        /// Taxação máxima é de 13% + 100.00 reais
        /// </summary>
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100.00;
        }

        /// <summary>
        /// Taxação mínima é de 1% para cada item do orçamento
        /// </summary>
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count / 100.00);
        }

        /// <summary>
        /// Para verificar se contém itens duplicados, cria um hashset e tenta adicionar todos os nomes de item. Caso algum de errado, é pq ja tem esse item no Hashset
        /// </summary>
        private bool TemDoisItensComMesmoNome(Orcamento orcamento)
        {
            HashSet<string> knownKeys = new HashSet<string>();
            return orcamento.Itens.Any(item => !knownKeys.Add(item.Nome));
        }
    }
}
