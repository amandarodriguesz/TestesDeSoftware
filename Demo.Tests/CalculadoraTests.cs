using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4,resultado);

        }
    }
}
