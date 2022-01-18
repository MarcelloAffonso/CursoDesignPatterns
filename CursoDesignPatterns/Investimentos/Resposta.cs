using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    /// <summary>
    /// A propriedade foi implementada diretamente nas classes para cobrir a possibilidade de ser nula, ou seja, não haver uma ProximaResposta
    /// </summary>
    public interface Resposta
    {
        void Responde(Requisicao requisicao, ContaBancaria conta);
    }
}
