using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public static class ValidadorFecha
    {
        public static bool EsBisiesto(int anio)
    {
        return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
    }

    public static bool EsFechaValida(int dia, int mes, int anio)
    {
        // Validar rango básico de mes y año
        if (mes < 1 || mes > 12 || anio < 1) return false;

        // Determinar el máximo de días para ese mes
        int diasMaximos;

        if (mes == 2)
        {
            diasMaximos = EsBisiesto(anio) ? 29 : 28;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            diasMaximos = 30;
        }
        else
        {
            diasMaximos = 31;
        }

        // Validar que el día esté entre 1 y el máximo permitido
        return dia >= 1 && dia <= diasMaximos;
    }
    }
}