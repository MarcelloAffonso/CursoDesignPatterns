using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento foi reprovado, desconto extra não pode ser aplicado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode ser aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orrçamento já foi reprovado!");
        }
    }
}