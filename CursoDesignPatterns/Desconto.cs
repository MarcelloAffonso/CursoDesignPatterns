using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);

        Desconto ProximoDesconto { get; set; }
    }
}
