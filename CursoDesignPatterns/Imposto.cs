using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// Interface que permite que um imposto seja calculado simplesmente com a implementação de uma classe referente ao imposto.
    /// Graças à essa interface, o código fica muito mais legivel, não são feitos varios ifs na "Calculadora de impostos" e é facil adicionar um novo imposto.
    /// Essa implementação de solução é chamada de Strategy, onde, temos vários problemas (impostos) e uma maneira única de resolver (criando uma implementação de classe para cada imposto).
    /// No capitulo 4, mudamos de interface para classe abstrata para trabalhar com o padrão de projetos Decorator
    /// </summary>
    public abstract class Imposto
    {

        /// <summary>
        /// Utilizando o padrão Decorator, essa propriedade é utilizada caso seja necessário calcular a junção de um ou mais impostos
        /// </summary>
        Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        public double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
            {
                return 0;
            }
            else
            {
                return OutroImposto.Calcula(orcamento);
            }
        }
    }
}
