using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public static class ConversorAlmacenamiento
    {
        // Constante para las conversiones
        private const double Factor = 1024;

        public static double Convertir(double valor, int desde, int hasta)
        {
            // 1: Bytes, 2: KB, 3: MB, 4: GB, 5: TB
            
            // Primero convertimos todo a la unidad mas pequeña (Bytes) para estandarizar
            double enBytes = valor * Math.Pow(Factor, desde - 1);
            
            // Luego convertimos de Bytes a la unidad destino
            return enBytes / Math.Pow(Factor, hasta - 1);
        }

        public static string ObtenerNombreUnidad(int opcion)
        {
            if (opcion == 1) return "Bytes";
            if (opcion == 2) return "KB";
            if (opcion == 3) return "MB";
            if (opcion == 4) return "GB";
            if (opcion == 5) return "TB";
            return "Unidad desconocida";
            }
    }
}