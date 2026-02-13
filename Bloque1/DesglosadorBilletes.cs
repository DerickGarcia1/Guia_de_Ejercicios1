using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_de_Ejercicios1.Bloque1
{
    public  static class DesglosadorBilletes
    {
        public static void MostrarDesglose(int monto)
        {
            Console.WriteLine("\nDesglose de L. " + monto + (":"));

            monto = ProcesarBillete(monto, 500);
            monto = ProcesarBillete(monto, 100);
            monto = ProcesarBillete(monto, 50);
            monto = ProcesarBillete(monto, 20);
            monto = ProcesarBillete(monto, 10);
            monto = ProcesarBillete(monto, 5);
            monto = ProcesarBillete(monto, 2);
            monto = ProcesarBillete(monto, 1);
        }

        private static int ProcesarBillete(int monto, int denominacion)
        {
            int cantidad = monto / denominacion;
            if (cantidad > 0)
            {
                Console.WriteLine(cantidad + " billetes de L." + denominacion);
            }
            return monto % denominacion; //retorna lo que sobra
        }
    }
}