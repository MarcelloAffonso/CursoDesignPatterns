using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class FiltroContaAbertaMesCorrente : Filtro
    {
        public FiltroContaAbertaMesCorrente(Filtro proximo) : base(proximo) { }
        public FiltroContaAbertaMesCorrente() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> contasBancarias = FiltraProximo(contas);

            foreach (ContaBancaria conta in contas)
            {
                if ((conta.DataAbertura.Month == DateTime.Now.Month) && !contasBancarias.Contains(conta))
                {
                    contasBancarias.Add(conta);
                }
            }

            return contasBancarias;
        }
    }
}
