using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque4
{
    public static class AnalizadorFrecuencia
    {
        // Cuenta cuántas veces aparece cada número del 1 al 10
        public static int[] CalcularFrecuencias(int[] datos)
        {
            int[] frecuencias = new int[11]; // Índice 0 no se usa, del 1 al 10 sí
            foreach (int num in datos)
            {
                frecuencias[num] = frecuencias[num] + 1;
            }
            return frecuencias;
        }

        public static int ObtenerMasFrecuente(int[] frecuencias)
        {
            int mayorFrec = -1;
            int numero = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (frecuencias[i] > mayorFrec)
                {
                    mayorFrec = frecuencias[i];
                    numero = i;
                }
            }
            return numero;
        }

        public static int ObtenerMenosFrecuente(int[] frecuencias)
        {
            int menorFrec = 100; // Valor inicial alto
            int numero = 0;
            for (int i = 1; i <= 10; i++)
            {
                // Solo consideramos números que aparecieron al menos una vez
                if (frecuencias[i] > 0 && frecuencias[i] < menorFrec)
                {
                    menorFrec = frecuencias[i];
                    numero = i;
                }
            }
            return numero;
        }
    }
}