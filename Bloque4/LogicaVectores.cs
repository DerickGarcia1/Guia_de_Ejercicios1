using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque4
{
    public static class LogicaVectores
    {
        // Búsqueda lineal: devuelve el índice o -1 si no existe
        public static int BusquedaLineal(int[] datos, int buscar)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == buscar) return i;
            }
            return -1;
        }

        // Algoritmo de Burbuja para ordenar de forma ascendente
        public static void OrdenarBurbuja(int[] datos)
        {
            int temp;
            for (int i = 0; i < datos.Length - 1; i++)
            {
                for (int j = 0; j < datos.Length - 1 - i; j++)
                {
                    if (datos[j] > datos[j + 1])
                    {
                        temp = datos[j];
                        datos[j] = datos[j + 1];
                        datos[j + 1] = temp;
                    }
                }
            }
        }

        // Encontrar el segundo mayor
        public static int ObtenerSegundoMayor(int[] datos)
        {
            // Primero ordenamos para que el mayor sea el último
            int[] copia = (int[])datos.Clone();
            OrdenarBurbuja(copia);
            
            // El mayor es copia[9], el segundo mayor es copia[8]
            // Esto asumiendo que no todos los números son iguales
            return copia[copia.Length - 2];
        }

        public static string ObtenerPosicionesPares(int[] datos)
        {
            string resultado = "";
            for (int i = 0; i < datos.Length; i = i + 2)
            {
                resultado = resultado + "Indice " + i + ": " + datos[i] + " | ";
            }
            return resultado;
        }
    }
}