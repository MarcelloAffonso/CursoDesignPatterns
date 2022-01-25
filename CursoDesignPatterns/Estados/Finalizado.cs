using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado, desconto extra não pode ser aplicado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado, portanto, não pode ser aprovado agora!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já foi finalizado, portanto, não pode ser reprovado agora!");
        }
    }
}