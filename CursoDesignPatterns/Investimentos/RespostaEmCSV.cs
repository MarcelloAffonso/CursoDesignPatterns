using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class RespostaEmCSV : Resposta
    {
        #region Propriedades
        /// <summary>
        /// Propriedade utilizada por causa da Chain Responsability. Por conta dela, cada classe tem sua responsabilidade e, caso a validação na classe atual falhe, vai para a próxima (caso exista)
        /// </summary>
        public Resposta ProximaResposta { get; private set; } 
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor utilizado caso tenha uma próxima validação/resposta
        /// </summary>
        public RespostaEmCSV(Resposta proximaResposta)
        {
            this.ProximaResposta = proximaResposta;
        }

        /// <summary>
        /// Construtor utilizado caso seja a ultima resposta possível
        /// </summary>
        public RespostaEmCSV()
        {
            this.ProximaResposta = null;
        } 
        #endregion

        #region Métodos
        public void Responde(Requisicao requisicao, ContaBancaria conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                // Caso seja o tipo esperado, responde da forma solicitada
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else if (ProximaResposta != null)
            {
                // Caso não seja o tipo de resposta esperado e tem próxima, vai para a próxima
                ProximaResposta.Responde(requisicao, conta);
            }
            else
            {
                // Se não tem próxima e não atingiu nenhuma das expectativa é um formato inválido
                throw new Exception("Formato de resposta não identificado!");
            }
        } 
        #endregion
    }
}
