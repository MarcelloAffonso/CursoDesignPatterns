using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Moderado : Investimento
    {
        public double Calcula(ContaBancaria contaBancaria)
        {
            bool escolhido = new Random().Next(2) == 0;

            if (escolhido)
            {
                return contaBancaria.Saldo * 0.025;  
            }
            else
            {
                return contaBancaria.Saldo * 0.007;
            }
        }
    }
}
