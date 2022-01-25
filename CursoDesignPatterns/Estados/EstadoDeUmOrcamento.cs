using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface EstadoDeUmOrcamento
    {
        /// <summary>
        /// Cada estado pode aplicar ou não um desconto extra
        /// </summary>
        public void AplicaDescontoExtra(Orcamento orcamento);

        /// <summary>
        /// Método que, dependendo do estado atual, vai para o status de aprovado ou lança uma exception
        /// </summary>
        public void Aprova(Orcamento orcamento);

        /// <summary>
        /// Método que, dependendo do estado atual, vai para o status de aprovfinalziado ado ou lança uma exception
        /// </summary>
        public void Finaliza(Orcamento orcamento);

        /// <summary>
        /// Método que, dependendo do estado atual, vai para o status de aprovado ou lança uma exception
        /// </summary>
        public void Reprova(Orcamento orcamento);

    }
}
