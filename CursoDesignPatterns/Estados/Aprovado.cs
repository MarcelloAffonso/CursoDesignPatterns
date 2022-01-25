using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        /// <summary>
        /// Garante que só gvai aplicar o desconto uma vez
        /// </summary>
        private bool DescontoJaAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!this.DescontoJaAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                this.DescontoJaAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já foi aplicado, não pode ser aplicado novamente!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi aprovado, não pode ser aprovado novamente!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orrçamento já aprovado não pode ser reprovado agora!");
        }
    }
}
