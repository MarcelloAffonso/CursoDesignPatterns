using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Relatorios
{
    public interface Relatorio
    {
        void MontaRelatorio(Banco banco);
    }
}
