using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque4
{
    public static class EstadisticoNotas
    {
            public static float CalcularPromedio(float[] datos)
        {
            float acumulado = 0;
            foreach (float nota in datos) acumulado = acumulado + nota;
            return acumulado / datos.Length;
        }

        public static float ObtenerMaxima(float[] datos)
        {
            float max = datos[0];
            foreach (float nota in datos) if (nota > max) max = nota;
            return max;
        }

        public static float ObtenerMinima(float[] datos)
        {
            float min = datos[0];
            foreach (float nota in datos) if (nota < min) min = nota;
            return min;
        }

        public static int ContarAprobados(float[] datos)
        {
            int conteo = 0;
            foreach (float nota in datos) if (nota >= 65) conteo = conteo + 1;
            return conteo;
        }

        public static double CalcularDesviacion(float[] datos, float promedio)
        {
            double sumaDiferencias = 0;
            foreach (float nota in datos)
            {
                sumaDiferencias = sumaDiferencias + Math.Pow(nota - promedio, 2);
            }
            return Math.Sqrt(sumaDiferencias / datos.Length);
        }
    }
}