using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque5
{
    public static class LogicaGato
    {
        private static char[,] tableroGato = new char[3, 3];

        public static void InicializarTablero()
        {
            char marcador = '1';
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tableroGato[f, c] = marcador;
                    marcador++;
                }
            }
        }

        public static string ObtenerTableroTexto()
        {
            string t = "\n";
            for (int i = 0; i < 3; i++)
            {
                t = t + " " + tableroGato[i, 0] + " | " + tableroGato[i, 1] + " | " + tableroGato[i, 2] + " \n";
                if (i < 2) t = t + "----------- \n";
            }
            return t;
        }

        public static bool RealizarMovimiento(int posicion, char ficha)
        {
            // Convertir el número 1-9 a coordenadas de matriz
            int fila = (posicion - 1) / 3;
            int col = (posicion - 1) % 3;

            // Validar que la posición no esté ocupada por 'X' o 'O'
            if (tableroGato[fila, col] != 'X' && tableroGato[fila, col] != 'O')
            {
                tableroGato[fila, col] = ficha;
                return true;
            }
            return false;
        }

        public static bool VerificarGanador()
        {
            // Filas y Columnas
            for (int i = 0; i < 3; i++)
            {
                if (tableroGato[i, 0] == tableroGato[i, 1] && tableroGato[i, 1] == tableroGato[i, 2]) return true;
                if (tableroGato[0, i] == tableroGato[1, i] && tableroGato[1, i] == tableroGato[2, i]) return true;
            }
            // Diagonales
            if (tableroGato[0, 0] == tableroGato[1, 1] && tableroGato[1, 1] == tableroGato[2, 2]) return true;
            if (tableroGato[0, 2] == tableroGato[1, 1] && tableroGato[1, 1] == tableroGato[2, 0]) return true;

            return false;
        }
    }
}