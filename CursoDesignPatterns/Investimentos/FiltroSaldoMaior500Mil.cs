using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class FiltroSaldoMaior500Mil : Filtro
    {
        public FiltroSaldoMaior500Mil(Filtro proximo) : base(proximo) { }
        public FiltroSaldoMaior500Mil() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> contasBancarias = FiltraProximo(contas);

            foreach (ContaBancaria conta in contas)
            {
                if ((conta.Saldo > 500000) && !(contasBancarias.Contains(conta)))
                {
                    contasBancarias.Add(conta);
                }
            }

            return contasBancarias;
        }
    }
}