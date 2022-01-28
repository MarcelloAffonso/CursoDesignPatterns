using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// Classe utilizada para construir uma nota fiscal. Torna o código mais limpo e mais legível, pois não precisa passar 500 argumentos diretamente no construtor
    /// </summary>
    public class NotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private string observacoes;
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        
        /// <summary>
        ///  Eu tornei a propriedade nullable para poder setar a data que eu quisesse. Poré, o curso apresentou uma solução onde utilizamos pelo construtor. Acho que qualquer um dos dois tá bom
        /// </summary>
        private DateTime? data;

        public NotaFiscalBuilder()
        {
            // Pra ficar do mesmo jeito que o instrutor da Alura sugeriu
            this.data = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            this.data = data;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota itemNovo)
        {
            this.todosItens.Add(itemNovo);
            this.valorTotal += itemNovo.Valor;
            this.impostos += itemNovo.Valor * 0.05;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(this.razaoSocial, this.cnpj, this.data ?? DateTime.Now, this.valorTotal, this.impostos, this.todosItens, this.observacoes);
        }
    }
}
