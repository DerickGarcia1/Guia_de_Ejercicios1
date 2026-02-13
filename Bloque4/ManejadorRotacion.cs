using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque4
{
    public static class ManejadorRotacion
    {
        // Rotar a la derecha: El último pasa a ser el primero
        public static int[] RotarDerecha(int[] original, int k)
        {
            int n = original.Length;
            int[] resultado = new int[n];
            // Asegurar que k no sea mayor que n
            k = k % n;

            for (int i = 0; i < n; i++)
            {
                int nuevaPos = (i + k) % n;
                resultado[nuevaPos] = original[i];
            }
            return resultado;
        }

        // Rotar a la izquierda: El primero pasa a ser el último
        public static int[] RotarIzquierda(int[] original, int k)
        {
            int n = original.Length;
            int[] resultado = new int[n];
            k = k % n;

            for (int i = 0; i < n; i++)
            {
                int nuevaPos = (i - k + n) % n;
                resultado[nuevaPos] = original[i];
            }
            return resultado;
        }

        // Invertir: El primero con el último, el segundo con el penúltimo...
        public static int[] InvertirArreglo(int[] original)
        {
            int n = original.Length;
            int[] resultado = new int[n];
            for (int i = 0; i < n; i++)
            {
                resultado[i] = original[n - 1 - i];
            }
            return resultado;
        }

        public static string MostrarArreglo(int[] arreglo)
        {
            string texto = "[ ";
            for (int i = 0; i < arreglo.Length; i++)
            {
                texto = texto + arreglo[i] + " ";
            }
            return texto + "]";
        }
    }
}