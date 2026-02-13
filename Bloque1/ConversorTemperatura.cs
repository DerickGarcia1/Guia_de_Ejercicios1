using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public static class ConversorTemperatura
    {
        //uso de metodos directos
        public static double CF(double C) => (C * 1.8) + 32;
        public static double CK(double C) => C + 273.15;
        public static double FC(double F) => (F - 32) / 1.8;
        public static double FK(double F) => ((F - 32) /1.8) + 273.15;
        public static double KC(double K) => K - 273.15;
        public static double KF(double K) => ((K - 273.15) * 1.8) + 32;

    }
}