using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public static class Calendario
    {
            public static bool EsBisiesto(int anio)
        {
            // Regla: Divisible entre 4 y (no divisible entre 100 o divisible entre 400)
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public static int ObtenerDiasDelMes(int mes, int anio)
        {
            if (mes == 2)
            {
                if (EsBisiesto(anio))
                {
                    return 29;
                }
                return 28;
            }

            // Meses con 30 días: Abril (4), Junio (6), Septiembre (9), Noviembre (11)
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                return 30;
            }

            // Todos los demás tienen 31 (Enero, Marzo, Mayo, Julio, Agosto, Octubre, Diciembre)
            return 31;
        }

        public static string NombreMes(int mes)
        {
            if (mes == 1) return "Enero";
            if (mes == 2) return "Febrero";
            if (mes == 3) return "Marzo";
            if (mes == 4) return "Abril";
            if (mes == 5) return "Mayo";
            if (mes == 6) return "Junio";
            if (mes == 7) return "Julio";
            if (mes == 8) return "Agosto";
            if (mes == 9) return "Septiembre";
            if (mes == 10) return "Octubre";
            if (mes == 11) return "Noviembre";
            if (mes == 12) return "Diciembre";
            return "Desconocido";
        }
    }
}