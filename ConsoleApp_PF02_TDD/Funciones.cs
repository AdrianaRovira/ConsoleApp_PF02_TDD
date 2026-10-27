using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_PF02_TDD
{
    public class Funciones
    {
        //Refactorización con flecha
        public static long CalcularFactorial(int numero) =>
        numero < 0 ? -1 : Enumerable.Range(1, numero).Aggregate(1L, (acc, i) => acc * i);

        //adrdeprov2627

        //Refactorización de la función EsContrasenyaValida
        public static bool EsContrasenyaValida(string contrasenya) =>
     !string.IsNullOrEmpty(contrasenya) && contrasenya.Length >= 8 && contrasenya.Contains('#');
    }
}
