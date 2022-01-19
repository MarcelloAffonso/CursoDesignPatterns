﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// Essa classe foi criada porque o algoritmo de dois impostos era muito parecido, só mudavam os valores
    /// </summary>
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        /// <summary>
        /// Algoritmo já é implementado na superclasse, de forma que cada imposto só terá que implementar as regras de negócio 
        /// </summary>
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        /// <summary>
        /// Regra de negócio para determinar a regra de utilizar ou não a máxima taxação
        /// </summary>
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        
        /// <summary>
        /// Regra de negócio da máxima taxação
        /// </summary>
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        /// <summary>
        /// Regra de negócio da mínima taxação
        /// </summary>
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
