using System;

namespace Aula46MembrosEstaticos
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Cinrcunferencia(double pRaio)
        {
            return 2.0 * Pi * pRaio;
        }

        public static double Volume(double pRaio)
        {
            return (4.0 / 3.0) * (Pi * Math.Pow(pRaio, 3.0));
        }
    }
}
