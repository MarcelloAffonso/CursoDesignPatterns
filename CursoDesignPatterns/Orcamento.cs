using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        /// <summary>
        /// Só a própria classe pode setar o Valor
        /// </summary>
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
