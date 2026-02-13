using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque5
{
    public static class AnalizadorAcademia
    {
        // Calcula el promedio de una fila específica (estudiante)
        public static float CalcularPromedioEstudiante(float[,] matriz, int fila)
        {
            float suma = 0;
            for (int j = 0; j < 3; j++)
            {
                suma = suma + matriz[fila, j];
            }
            return suma / 3;
        }

        // Calcula el promedio de una columna específica (parcial)
        public static float CalcularPromedioParcial(float[,] matriz, int parcial, int totalEstudiantes)
        {
            float suma = 0;
            for (int i = 0; i < totalEstudiantes; i++)
            {
                suma = suma + matriz[i, parcial];
            }
            return suma / totalEstudiantes;
        }

        public static int ObtenerMejorEstudiante(float[,] matriz, int totalEstudiantes)
        {
            float mejorPromedio = -1;
            int indiceMejor = 0;

            for (int i = 0; i < totalEstudiantes; i++)
            {
                float promActual = CalcularPromedioEstudiante(matriz, i);
                if (promActual > mejorPromedio)
                {
                    mejorPromedio = promActual;
                    indiceMejor = i;
                }
            }
            return indiceMejor;
        }

        public static int ObtenerParcialMasDificil(float[,] matriz, int totalEstudiantes)
        {
            float menorPromedio = 101;
            int parcialDificil = 0;

            for (int j = 0; j < 3; j++)
            {
                float promP = CalcularPromedioParcial(matriz, j, totalEstudiantes);
                if (promP < menorPromedio)
                {
                    menorPromedio = promP;
                    parcialDificil = j;
                }
            }
            return parcialDificil;
        }
    }
}