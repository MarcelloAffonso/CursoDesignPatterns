using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class FiltroSaldoMenor100Reais : Filtro
    {
        public FiltroSaldoMenor100Reais(Filtro proximo) : base(proximo) { }
        public FiltroSaldoMenor100Reais() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> contasBancarias = FiltraProximo(contas);

            foreach(ContaBancaria conta in contas)
            {
                if((conta.Saldo < 100) && !(contasBancarias.Contains(conta)))
                {
                    contasBancarias.Add(conta);
                }
            }

            return contasBancarias;
        }
    }
}
