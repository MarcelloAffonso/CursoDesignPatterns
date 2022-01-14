using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    /// <summary>
    /// Interface que permite que um imposto seja calculado simplesmente com a implementação de uma classe referente ao imposto.
    /// Graças à essa interface, o código fica muito mais legivel, não são feitos varios ifs na "Calculadora de impostos" e é facil adicionar um novo imposto.
    /// Essa implementação de solução é chamada de Strategy, onde, temos vários problemas (impostos) e uma maneira única de resolver (criando uma implementação de classe para cada imposto).
    /// </summary>
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
