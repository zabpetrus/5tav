using System;
using Xunit;
using Moq;
using AppAPICalculadora.Application.Models;

namespace AppAPICalculadora.Tests
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Test1()
        {

            Mock<IOperacao> mock = new Mock<IOperacao>();
            mock.Setup(m => m.soma()).Returns(8);

            CalculadoraSimples duocalc = new CalculadoraSimples(mock.Object)
            {
                fator1 = 7,
                fator2 = 1
            };

            double num = duocalc.soma();
            Assert.Equal(8, num);

        }

        [Fact]
        public void Teste2()
        {
            CalculadoraSimples duocalc = new CalculadoraSimples();
            duocalc.fator1 = 5;
            duocalc.fator2 = 4;
            double num = duocalc.soma();
            Assert.Equal(9, num);

        }
    }
}
