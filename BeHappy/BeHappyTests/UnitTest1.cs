using System;
using Xunit;
using BeHappy.Models;
using Moq;

namespace BeHappyTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {           

            Mock<IOperacao> mock = new Mock<IOperacao>();
            mock.Setup(m => m.soma()).Returns(8);

            Duocalc duocalc = new Duocalc(mock.Object)
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
            Duocalc duocalc = new Duocalc();
            duocalc.fator1 = 5;
            duocalc.fator2 = 4;
            double num = duocalc.soma();
            Assert.Equal(9, num);
            
        }
    }
}
