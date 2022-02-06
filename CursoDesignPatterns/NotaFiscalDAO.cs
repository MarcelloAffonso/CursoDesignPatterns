using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class NotaFiscalDAO: AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Nota fiscal salva no banco!");
        }
    }
}
