using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public static class CalculadoraNotas
    {
        public static string ObtenerLetra(float nota)
        {
            if(nota >= 90) return "A";
            if(nota >= 80) return "B";
            if(nota >= 70) return "C";
            if(nota >= 60) return "D";
            return "F";
        }

        public static string ObtenerDescripcion(string letra)
        {
            if (letra == "A") return "Sobreasliente";
            if (letra == "B") return "Muy Bueno";
            if (letra == "C") return "Bueno";
            if (letra == "D") return "Suficiente";
            return "Insuficeinte";
        }

        public static string ObtenerEstado(float nota)
        {
            string resultado;

            if (nota >= 60)
            {
                resultado = "Aprobado";
            }
            else
            {
                resultado = "Reprobado";
            }

            return resultado;
        }
    }
}