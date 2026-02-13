using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque3
{
    public static class ValidadorSeguridad
    {
        public static string VerificarRequisitos(string pass)
        {
            string faltante = "";

            // 1. Validar longitud
            if (pass.Length < 8)
            {
                faltante = faltante + "- Minimo 8 caracteres\n";
            }

            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            // Analizar cada caracter
            foreach (char c in pass)
            {
                if (char.IsUpper(c)) tieneMayuscula = true;
                else if (char.IsLower(c)) tieneMinuscula = true;
                else if (char.IsDigit(c)) tieneNumero = true;
                else if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
            }

            // Agregar a la lista de faltantes
            if (!tieneMayuscula) faltante = faltante + "- Una letra mayuscula\n";
            if (!tieneMinuscula) faltante = faltante + "- Una letra minuscula\n";
            if (!tieneNumero)    faltante = faltante + "- Al menos un numero\n";
            if (!tieneEspecial)  faltante = faltante + "- Un caracter especial (ej. @, #, $)\n";

            return faltante;
        }
    }
}