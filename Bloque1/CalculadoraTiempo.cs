using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public class CalculadoraTiempo
    {
        public static void CalculadoraDiferencia(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            //Converti ambos tiempos en segundos ya que es mas facil calcular en segundos
            int totalSegundos1 = (h1 * 3600) + (m1 * 60) + s1;
            int totalSegundos2 = (h2 * 3600) + (m2 * 60) + s2;

            //Obtenemos la diferencia(para que no importe cual hora es mayor)
            int diferenciaSegundos = Math.Abs(totalSegundos1 - totalSegundos2);

            //volvemos a convertir de segundos a hora, minuto, segundo.
            int horas = diferenciaSegundos / 3600;
            int minutos = (diferenciaSegundos % 3600) / 60;
            int segundos = diferenciaSegundos % 60;

            Console.WriteLine("\nLa diferencia es de: " + horas + " horas, " + minutos + " minutos y " + segundos + " segundos.");
        }
    }
}