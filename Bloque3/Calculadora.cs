using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class Calculadora
    {
        private static double resultadoActual = 0;

        public static double ObtenerResultado() => resultadoActual;

        public static void Limpiar() => resultadoActual = 0;

        public static void EstablecerResultado(double valor) => resultadoActual = valor;

        public static void Sumar(double n) => resultadoActual = resultadoActual + n;
        
        public static void Restar(double n) => resultadoActual = resultadoActual - n;

        public static void Multiplicar(double n) => resultadoActual = resultadoActual * n;

        public static void Dividir(double n)
        {
            if (n != 0) resultadoActual = resultadoActual / n;
            else Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        public static void Potencia(double exponente)
        {
            resultadoActual = Math.Pow(resultadoActual, exponente);
        }

        public static void RaizCuadrada()
        {
            if (resultadoActual >= 0) resultadoActual = Math.Sqrt(resultadoActual);
            else Console.WriteLine("Error: Raiz negativa.");
        }

        public static void AplicarPorcentaje(double p)
        {
            resultadoActual = (resultadoActual * p) / 100;
        }
    }
}