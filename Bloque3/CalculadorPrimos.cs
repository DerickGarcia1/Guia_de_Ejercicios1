using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class CalculadorPrimos
    {
        // Metodo para saber si un numero individual es primo
        public static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            
            // Probamos si tiene algún divisor desde 2 hasta la raíz del número
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}