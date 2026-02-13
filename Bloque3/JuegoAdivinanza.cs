using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class JuegoAdivinanza
    {
            private static int numeroSecreto;
        private static Random generador = new Random();

        // Método para iniciar el número aleatorio
        public static void IniciarJuego()
        {
            numeroSecreto = generador.Next(1, 101); // Genera entre 1 y 100
        }

        public static string VerificarIntento(int intento)
        {
            if (intento < numeroSecreto)
            {
                return "MAYOR";
            }
            else if (intento > numeroSecreto)
            {
                return "MENOR";
            }
            else
            {
                return "CORRECTO";
            }
        }

        public static int ObtenerNumeroSecreto()
        {
            return numeroSecreto;
        }
    }
}