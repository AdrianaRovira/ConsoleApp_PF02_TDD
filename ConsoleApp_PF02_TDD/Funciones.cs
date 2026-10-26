using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_PF02_TDD
{
    public class Funciones
    {
        
        public static long CalcularFactorial(int numero)
        {

            if (numero < 0) return -1;
            long resultado = 1;
            for (int i = 2; i <= numero; i++) resultado *= i;
            return resultado;

        }

        //adrdeprov2627
    }
}
