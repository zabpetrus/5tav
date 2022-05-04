using AppMVCAplication;
using AppMVCAplication.Models;
using Moq;
using System;
using Xunit;

namespace AppMVCTesteMock
{
    public class AppTestMockClass
    {
        [Fact]
        public void TestMockupSoma()
        {
            //Arrange
            Mock<ICalculadora> mock = new Mock<ICalculadora>(); //Tem que usar interface
            mock.Setup(m => m.soma(2,2)).Returns(4);

            //Act
            Calculadora calculadora = new Calculadora(mock.Object);
            int num = calculadora.soma(2, 2);

            //Assert
            Assert.Equal(4, num);
        }

        [Fact]
        public void TesteMockupSubtracao() //Caso de erro 
        {
            //Arrange
            Mock<ICalculadora> mock = new Mock<ICalculadora>();
            mock.Setup((mock) => mock.subtrair(5, 3.7)).Returns(1.3);

            //Act
            Calculadora calculadora = new Calculadora(mock.Object);
            double n = calculadora.subtrair(5, 3.7);

            //Assert
            Assert.Equal(1.3, n);
        }

    }
}
