using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Relatorios
{
    public abstract class TemplateRelatorio : Relatorio
    {
        public void MontaRelatorio(Banco banco)
        {
            this.MontaCabecalho(banco);
            this.MontaCorpo(banco.Contas);
            this.MontaRodape(banco);
        }

        protected abstract void MontaCabecalho(Banco banco);
        protected abstract void MontaCorpo(IList<ContaBancaria> contas);
        protected abstract void MontaRodape(Banco banco);
    }
}
