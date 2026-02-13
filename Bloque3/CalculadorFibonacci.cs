using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class CalculadorFibonacci
    {
        // Metodo que calcula la suma para poder obtener el promedio después
        public static long CalcularSuma(int n)
        {
            if (n <= 0) return 0;
            
            long a = 0, b = 1, suma = 0;
            
            for (int i = 0; i < n; i++)
            {
                suma = suma + a;
                long temp = a;
                a = b;
                b = temp + b;
            }
            return suma;
        }

        // Metodo para obtener el valor de un termino específico
        public static long ObtenerTermino(int posicion)
        {
            long a = 0, b = 1;
            for (int i = 0; i < posicion; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}