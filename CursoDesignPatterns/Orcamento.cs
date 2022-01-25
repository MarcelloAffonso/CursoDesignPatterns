using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IList<Item> Itens { get; private set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            this.EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            this.EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            this.EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            this.EstadoAtual.Finaliza(this);
        }
    }
}
