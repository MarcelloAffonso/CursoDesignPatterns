using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public abstract class Filtro
    {
        Filtro ProximoFiltro { get; set; }

        protected Filtro(Filtro proximoFiltro)
        {
            ProximoFiltro = proximoFiltro;
        }

        protected Filtro()
        {
            ProximoFiltro = null;
        }

        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);

        protected IList<ContaBancaria> FiltraProximo(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> contasBancarias = new List<ContaBancaria>();

            if (ProximoFiltro != null)
            {
                contasBancarias = ProximoFiltro.Filtra(contas);
            }

            return contasBancarias;
        }
    }
}
