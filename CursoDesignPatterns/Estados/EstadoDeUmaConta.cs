using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface EstadoDeUmaConta
    {
        public void RealizaSaque(ContaBancaria conta, double valor);
        public void RealizaDeposito(ContaBancaria conta, double valor);
    }
}
