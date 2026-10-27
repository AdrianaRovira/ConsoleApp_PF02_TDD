using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_PF02_TDD
{
    public class Funciones
    {
        //Definir la función sin implementación, para quitar errores de compilación y se puedan hacer los tests
        public static long CalcularFactorial(int n)
        {

            if(n < 0) return -1;
            if(n == 0) return 1;

            long resul = 1;

            for(int i = 1; i <= n; i++)
            {
                resul *= i;
            }
            return resul;

        }

        //adrdeprov2627

        //Refactorización de la función EsContrasenyaValida
        public static bool EsContrasenyaValida(string contrasenya) =>
     !string.IsNullOrEmpty(contrasenya) && contrasenya.Length >= 8 && contrasenya.Contains('#');
    }
}
