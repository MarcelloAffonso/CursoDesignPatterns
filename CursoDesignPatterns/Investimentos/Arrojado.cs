using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Calcula(ContaBancaria contaBancaria)
        {
            int chance = new Random().Next(101);

            if (chance <= 20)
            {
                return contaBancaria.Saldo * 0.05;
            }
            else if(chance > 20 && chance <=50)
            {
                return contaBancaria.Saldo * 0.03;
            }
            else
            {
                return contaBancaria.Saldo * 0.006;
            }
        }
    }
}