using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public class CalculadoradeIMC
    {
        public float IMC(float peso, float altura)
        {
            return peso / (altura * altura);
        }

        public string Clasificación(float imc)
        {
            if (imc < 18.5)
                return "Bajo peso";

            if (imc >= 18.5 && imc <= 24.9)
                return "Peso normal";

            if (imc >= 25 && imc <= 29.9)
                return "Sobrepeso";

            return "Obesidad";
        }
    }
}