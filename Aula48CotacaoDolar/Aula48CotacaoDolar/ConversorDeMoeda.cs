using System;
using System.Collections.Generic;
using System.Text;

namespace Aula48CotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double CalcularIOF(double pValor)
        {
            return pValor * 0.6;
        }

        public static double CalcularValorFinal(double pValor, double pIof, double pDolar)
        {
            return (pValor * pDolar) + pIof;
        }
    }
}
