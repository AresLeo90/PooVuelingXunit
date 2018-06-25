using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PooVuelingXunit.Integration.Test
{

    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]

        public void DivisionTest(int num1, int num2, int resultado)
        {
            //Assert.True(iCalculadora.Division(num1, num2) == resultado);
             Assert.Equal(resultado, iCalculadora.Division(num1, num2));

        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(6, 3, 18)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            //Assert.True(iCalculadora.Multiplicacion(num1, num2) == resultado);
            Assert.Equal(resultado, iCalculadora.Multiplicacion(num1, num2));

        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 3)]

        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Resta(num1, num2) == resultado);
            //Assert.Equal(resultado, iCalculadora.Resta(num1, num2));

        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(6, 3, 9)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.True(iCalculadora.Suma(num1, num2) == resultado);
            //Assert.Equal(resultado, iCalculadora.Suma(num1, num2));

        }
    }
}
