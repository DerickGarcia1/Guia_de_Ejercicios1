using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque5
{
    public static class LogicaInventario
    {
        // Matriz: 5 filas (productos) x 3 columnas (0:Código, 1:Cantidad, 2:Precio)
        private static float[,] datosNumericos = new float[5, 3];
        private static string[] nombresProductos = new string[5];

        public static void RegistrarProducto(int indice, float cod, string nombre, float cant, float precio)
        {
            datosNumericos[indice, 0] = cod;
            nombresProductos[indice] = nombre;
            datosNumericos[indice, 1] = cant;
            datosNumericos[indice, 2] = precio;
        }

        public static string ObtenerInventarioCompleto()
        {
            string reporte = "\nCOD | NOMBRE | CANT | PRECIO | SUBTOTAL\n";
            reporte = reporte + "------------------------------------------\n";
            for (int i = 0; i < 5; i++)
            {
                float subtotal = datosNumericos[i, 1] * datosNumericos[i, 2];
                reporte = reporte + datosNumericos[i, 0] + " | " + nombresProductos[i] + " | " + 
                        datosNumericos[i, 1] + " | L. " + datosNumericos[i, 2] + " | L. " + subtotal + "\n";
            }
            return reporte;
        }

        public static int BuscarPorCodigo(float codigo)
        {
            for (int i = 0; i < 5; i++)
            {
                if (datosNumericos[i, 0] == codigo) return i;
            }
            return -1;
        }

        public static void ActualizarExistencia(int indice, float nuevaCant)
        {
            datosNumericos[indice, 1] = nuevaCant;
        }

        public static float CalcularValorTotal()
        {
            float total = 0;
            for (int i = 0; i < 5; i++)
            {
                total = total + (datosNumericos[i, 1] * datosNumericos[i, 2]);
            }
            return total;
        }

        public static string ObtenerNombre(int indice) => nombresProductos[indice];
    }
}