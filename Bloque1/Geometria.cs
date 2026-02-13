using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public static class Geometria
    {
        //circulo
        public static double AreaCirculo(double r) => Math.PI * r * r;
        public static double PerimetroCirculo(double r) => 2 * Math.PI * r;

        //Triangulo (asumiendo que es triangulo rectangulo
        public static double AreaTriangulo(double b, double h) => (b * h) / 2;
        public static double PerimetroTrianguloEquilatero(double lado) => lado * 3;

        // Rectángulo
        public static double AreaRectangulo(double b, double h) => b * h;
        public static double PerimetroRectangulo(double b, double h) => 2 * (b + h);

        // Trapecio
        public static double AreaTrapecio(double B, double b, double h) => ((B + b) * h) / 2;
        public static double PerimetroTrapecio(double B, double b, double l1, double l2) => B + b + l1 + l2;
    }
}