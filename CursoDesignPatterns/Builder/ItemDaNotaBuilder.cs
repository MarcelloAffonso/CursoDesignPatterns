using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ItemDaNotaBuilder
    {
        private string nomeItem;
        private double valorItem;

        public ItemDaNotaBuilder ParaItem(string item)
        {
            this.nomeItem = item;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.valorItem = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(this.nomeItem, valorItem);
        }

    }
}
