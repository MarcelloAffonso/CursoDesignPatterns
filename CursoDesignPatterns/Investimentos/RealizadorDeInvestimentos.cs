using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta, Investimento investimento)
        {
            // Calcula o lucro bruto
            double lucroBrutoInvestimento = investimento.Calcula(conta);

            // O lucro líquido é 75% do valor, já que 25% é imposto
            double lucroLiquidoInvestimento = lucroBrutoInvestimento * 0.75;

            // Adiciona o valor líquido à conta
            conta.AdicionaSaldo(lucroLiquidoInvestimento);

            // Exibe para o usuário
            Console.WriteLine(conta.Saldo);
        }
    }
}
