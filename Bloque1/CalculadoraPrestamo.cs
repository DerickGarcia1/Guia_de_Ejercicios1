using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public class CalculadoraPrestamo
    {
        public static float CalculadoraInteresTotal(float monto, float tasaAnual, float meses)
        {
            float tasaMensual = (tasaAnual / 100) / 12;
            return monto * tasaMensual * meses;
        }

        public static float CalculadoraCuotaMensual(float monto, float interesTotal, float meses)
        {
            return (monto + interesTotal) / meses;
        }
    }
}