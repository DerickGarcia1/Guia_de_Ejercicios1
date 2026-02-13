using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public class CalculadoraSalario
    {
        // Constante para el limite de horas normales en Honduras
        private const int LimiteHoras = 44;
        private const double FactorExtra = 1.5;

        public static double CalcularPagoNormal(float horas, float tarifa)
        {
            // Si trabajo mas de 44, solo se le pagan 44 como normales
            double horasNormales = (horas > LimiteHoras) ? LimiteHoras : horas;
            return horasNormales * tarifa;
        }

        public static double CalcularPagoExtra(float horas, float tarifa)
        {
            if (horas > LimiteHoras)
            {
                double horasExtras = horas - LimiteHoras;
                return horasExtras * (tarifa * FactorExtra);
            }
            return 0;
        }

        public static double ObtenerCantidadExtras(float horas)
        {
            return (horas > LimiteHoras) ? (horas - LimiteHoras) : 0;
        }
    }
}