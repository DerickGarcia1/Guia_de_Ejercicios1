using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class CalculadoraFactorial
    {
        // Método para calcular el factorial (n!)
        public static double CalcularFactorial(int n)
        {
            if (n < 0) return 0;
            double resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        // Método para calcular combinaciones C(n, r)
        public static double CalcularCombinacion(int n, int r)
        {
            if (r > n || r < 0) return 0;

            double factN = CalcularFactorial(n);
            double factR = CalcularFactorial(r);
            double factNMR = CalcularFactorial(n - r);

            // Fórmula: n! / (r! * (n-r)!)
            return factN / (factR * factNMR);
        }
    }
}