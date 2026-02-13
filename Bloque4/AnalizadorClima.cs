using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque4
{
    public static class AnalizadorClima
    {
        public static float CalcularPromedio(float[] temps)
        {
            float suma = 0;
            foreach (float t in temps) suma = suma + t;
            return suma / temps.Length;
        }

        public static float ObtenerMaxima(float[] temps)
        {
            float max = temps[0];
            foreach (float t in temps) if (t > max) max = t;
            return max;
        }

        public static float ObtenerMinima(float[] temps)
        {
            float min = temps[0];
            foreach (float t in temps) if (t < min) min = t;
            return min;
        }

        public static string DiasSobrePromedio(float[] temps, float promedio)
        {
            string resultado = "";
            string[] nombresDias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            
            for (int i = 0; i < temps.Length; i++)
            {
                if (temps[i] > promedio)
                {
                    resultado = resultado + nombresDias[i] + " (" + temps[i] + "°), ";
                }
            }
            return resultado;
        }

        public static string CalcularVariaciones(float[] temps)
        {
            string variaciones = "";
            for (int i = 0; i < temps.Length - 1; i++)
            {
                float dif = temps[i + 1] - temps[i];
                variaciones = variaciones + "Dia " + (i + 1) + " a " + (i + 2) + ": " + dif + "°\n";
            }
            return variaciones;
        }
    }
}