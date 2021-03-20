using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class AssertNumbersTestes
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(1, 2);

            //Assert
            Assert.Equal(3, resultado);

        }
        [Fact]
        public void Calculadora_Somar_NaoDeveSerIgual()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(1.13123123123, 2.2312313123);

            //Assert
            Assert.NotEqual(3.3, result, 1);
        }
    }
}
