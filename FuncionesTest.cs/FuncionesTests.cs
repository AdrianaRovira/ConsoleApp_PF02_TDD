using ConsoleApp_PF02_TDD;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FuncionesTest.cs
{
    [TestClass]
    
        //ROL TESTER
        
        public sealed class FuncionesTests
        {
            // ROL TESTER

            [TestMethod]
            public void CalcularFactorial_NumeroNegativo()
            {
                long resultado = Funciones.CalcularFactorial(-3);
                Assert.AreEqual(-1L, resultado);
            }

            [TestMethod]
            public void CalcularFactorial_Cero()
            {
                long resultado = Funciones.CalcularFactorial(0);
                Assert.AreEqual(1L, resultado);
            }

            [TestMethod]
            public void CalcularFactorial_NumeroTres()
            {
                long resultado = Funciones.CalcularFactorial(3);
                Assert.AreEqual(6L, resultado);
            }

            [TestMethod]
            public void CalcularFactorial_NumeroCinco()
            {
                long resultado = Funciones.CalcularFactorial(5);
                Assert.AreEqual(120L, resultado);
            }

            // adrdeprov2627
        }
    }

