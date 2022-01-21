using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00)
            {
                // Menor que 1000.00 o imposto é 5%
                return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
            {
                // Entre 1000.00 e 3000.00 (com os limites inclusos) o imposto é 7%
                return orcamento.Valor * 0.07 + CalculaOutroImposto(orcamento);
            }
            else
            {
                // Maior que 3000.00 o imposto é 8% + 30.00 reais de taxa fixa
                return (orcamento.Valor * 0.08) + 30.00 + CalculaOutroImposto(orcamento);
            }
        }
    }
}
