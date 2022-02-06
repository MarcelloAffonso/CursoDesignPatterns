using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Impressora : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Impressão realizada!");
        }
    }
}
