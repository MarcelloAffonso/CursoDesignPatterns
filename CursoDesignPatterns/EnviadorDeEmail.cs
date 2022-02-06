using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class EnviadorDeEmail: AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Email enviado!");
        }
    }
}
