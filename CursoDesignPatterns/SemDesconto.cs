using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class SemDesconto : Desconto
    {
        public Desconto ProximoDesconto { get ; set; }

        public double Desconta(Orcamento orcamento)
        {
            // É a ultima opção, ou seja, não tem desconto.
            return 0;
        }

    }
}
