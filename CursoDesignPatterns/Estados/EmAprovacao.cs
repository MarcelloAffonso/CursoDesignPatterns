using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        /// <summary>
        /// Garante que o desconto só será aplicado uma única vez
        /// </summary>
        private bool DescontoJaAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!this.DescontoJaAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                DescontoJaAplicado = true;
            }
            else
            {
                throw new Exception("Desconto não pode ser aplicado mais de uma vez!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado direto!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}