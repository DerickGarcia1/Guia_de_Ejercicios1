using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public static class ValidadorTriangulo
    {
        public static bool EsValido(float a, float b, float c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static string ClasificarPorLados(float a, float b, float c)
    {
        if (a == b && b == c) return "Equilatero";
        if (a == b || b == c || a == c) return "Isosceles";
        return "Escaleno";
    }

    public static string ClasificarPorAngulos(float a, float b, float c)
    {
        // Usamos el Teorema de Pitágoras: a² + b² = c²
        // Primero identificamos el lado más largo (hipotenusa potencial)
        float[] lados = { a, b, c };
        Array.Sort(lados); // El más grande queda en la posición 2
        
        float mayor = lados[2];
        float l1 = lados[0];
        float l2 = lados[1];

        // Calculamos los cuadrados para comparar
        double sumaCuadrados = (l1 * l1) + (l2 * l2);
        double cuadradoMayor = mayor * mayor;

        // Tolerancia pequeña para errores de precisión decimal (Epsilon)
        if (Math.Abs(sumaCuadrados - cuadradoMayor) < 0.001) return "Rectangulo";
        if (sumaCuadrados > cuadradoMayor) return "Acutangulo";
        return "Obtusangulo";
    }
    }
}