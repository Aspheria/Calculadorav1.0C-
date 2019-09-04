using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   public class Calculadora
    {
        public double Adicao(string Valor1, string Valor2)
        {
            return Convert.ToDouble(Valor1) + Convert.ToDouble(Valor2);
        } 
        public double Multiplicacao(string Valor1, string Valor2)
        {
            return Convert.ToDouble(Valor1) * Convert.ToDouble(Valor2);
        }
        public double Divisao(string Valor1, string Valor2)
        {
            return Convert.ToDouble(Valor1)/Convert.ToDouble(Valor2);
        }

        public double Calcular(string valor1, string valor2, OperationType type)
        {
            double v1 = Convert.ToDouble(valor1);
            double v2 = Convert.ToDouble(valor2);

            switch (type)
            {
                case OperationType.Adicao:
                    return v1 + v2;
                case OperationType.Subtracao:
                    return v1 - v2;
                case OperationType.Multiplicao:
                    return v1 * v2;
                case OperationType.Divisao:
                    return v1 / v2;
                default:
                    return 0;
            }
        }

    }
}
