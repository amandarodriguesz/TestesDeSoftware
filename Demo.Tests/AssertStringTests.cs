using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
   public class AssertStringTests
    {
        [Fact]
        public void StringTools_UnirNomes_RetornarNomeCompleto()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.Equal("Eduardo Pires", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveIgnorarCase()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.Equal("EDUARDO PIRES", nomeCompleto, true);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveConterTrecho()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.Contains("ard", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_DeveComecarCom()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.StartsWith("Edu", nomeCompleto);

        }

        [Fact]
        public void StringTools_UnirNomes_DeveAcabarCom()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.EndsWith("res", nomeCompleto);
        }

        [Fact]
        public void StringTools_UnirNomes_ValidarExoressaiRegular()
        {
            //Arrange
            var sut = new StringTools();

            //Act
            var nomeCompleto = sut.Unir("Eduardo", "Pires");

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+[A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
