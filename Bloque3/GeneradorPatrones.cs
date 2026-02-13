using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class GeneradorPatrones
    {
        public static string Triangulo(int n)
        {
            string resultado = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    resultado = resultado + "*";
                }
                resultado = resultado + "\n";
            }
            return resultado;
        }

        public static string TrianguloInvertido(int n)
        {
            string resultado = "";
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    resultado = resultado + "*";
                }
                resultado = resultado + "\n";
            }
            return resultado;
        }

        public static string CuadradoHueco(int n)
        {
            string resultado = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // Dibujar asterisco si es el borde, si no, espacio
                    if (i == 1 || i == n || j == 1 || j == n)
                        resultado = resultado + "*";
                    else
                        resultado = resultado + " ";
                }
                resultado = resultado + "\n";
            }
            return resultado;
        }

        public static string Rombo(int n)
        {
            string resultado = "";
            // Parte superior
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++) resultado = resultado + " ";
                for (int j = 1; j <= (2 * i - 1); j++) resultado = resultado + "*";
                resultado = resultado + "\n";
            }
            // Parte inferior
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++) resultado = resultado + " ";
                for (int j = 1; j <= (2 * i - 1); j++) resultado = resultado + "*";
                resultado = resultado + "\n";
            }
            return resultado;
        }
    }
}