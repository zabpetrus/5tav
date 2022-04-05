using Moq;
using NUnit.Framework;
using WebApplication1.Models;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void testeICorreioService()
        {
           
            //Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(7.52); 
            
            Frete frete = new Frete(mock.Object)
            {
                cep = 21857010,
                peso = 5
            };

            double resultado = frete.CalculaFrete();
            Assert.Equals(7.52, resultado);

        }
    }
}