using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public  static class ProcesadorDescuentos
    {
        public static float ObtenerPorcentaje(float monto)
        {
            if (monto >= 2500) return 0.15f; // 15%
            if (monto >= 1000) return 0.10f; // 10%
            if (monto >= 500)  return 0.05f; // 5%
            return 0.00f; // Sin descuento
        }

        public static float CalcularDescuento(float monto, float porcentaje)
        {
            return monto * porcentaje;
        }

        public static float CalcularTotalFinal(float monto, float descuento)
        {
            return monto - descuento;
        }
    }
}