using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public interface Investimento
    {
        double Calcula(ContaBancaria contaBancaria);
    }
}
