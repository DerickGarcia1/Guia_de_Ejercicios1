using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque2
{
    public class LogicaCajero
    {
        // Saldo inicializado en código
        private static float saldoActual = 5000.00f;

        public static float ConsultarSaldo() => saldoActual;

        public static bool EsMultiploDe20(float monto)
        {
            return monto % 20 == 0;
        }

        public static bool TieneSaldoSuficiente(float monto)
        {
            return monto <= saldoActual;
        }

        public static void ProcesarRetiro(float monto)
        {
            saldoActual = saldoActual - monto;
            int restante = (int)monto;

            Console.WriteLine("\nRetiro exitoso. Entregando:");

            // Desglose de billetes (solo 500, 100, 50 y 20)
            int b500 = restante / 500;
            restante = restante % 500;

            int b100 = restante / 100;
            restante = restante % 100;

            int b50 = restante / 50;
            restante = restante % 50;

            int b20 = restante / 20;

            if (b500 > 0) Console.WriteLine(b500 + " billete(s) de L. 500");
            if (b100 > 0) Console.WriteLine(b100 + " billete(s) de L. 100");
            if (b50 > 0)  Console.WriteLine(b50 + " billete(s) de L. 50");
            if (b20 > 0)  Console.WriteLine(b20 + " billete(s) de L. 20");
        }
    }
}