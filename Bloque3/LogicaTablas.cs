using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class LogicaTablas
    {
        public static string ObtenerLineaTabla(int numero, int multiplicador)
        {
            int resultado = numero * multiplicador;
            
            // Usamos una lógica de espacios manual para que quede "alineado" 
            // ya que no podemos usar interpolación avanzada.
            string espacio = (multiplicador < 10) ? "  " : " ";
            
            return numero + " x " + multiplicador + espacio + "= " + resultado;
        }
    }
}