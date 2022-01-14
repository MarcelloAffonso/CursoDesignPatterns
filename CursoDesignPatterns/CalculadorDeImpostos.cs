using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// Classe responsável por calcular o imposto, independente de qual for.
    /// </summary>
    public class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            // "".Equals para garantir que não vai ter Nullreference mesmo se o imposto for vazio
            //if ("ICMS".Equals(imposto))

            double impostoValor = imposto.Calcula(orcamento);
            Console.WriteLine(impostoValor);
        }
    }
}
