using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Entities
{
    internal class Operacoes
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public Operacoes(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }


        public decimal Adicao()
        {
            return Valor1 + Valor2;
        }

        public decimal Subtracao()
        {
            return Valor1 - Valor2;
        }

        public decimal Multiplicacao()
        {
            return (Valor1 * Valor2);
        }

        public decimal Divisao()
        {
            return (Valor1 / Valor2);
        }
    }


}
