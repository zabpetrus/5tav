using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete(21857010, 5)).Returns(7.52);

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
