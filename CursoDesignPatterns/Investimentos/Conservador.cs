using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Conservador : Investimento
    {
        public double Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
