using NUnit.Framework;
using WebApplication2;

namespace TestProject1
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
        public void TesteCalculadora()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.soma(3, 4);
            Assert.AreEqual(num, 7);

        }

        [Test]
        public void TesteCalculadora2()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.subtrair(6, 9);
            Assert.AreEqual(num, -3);
        }

        [Test]
        public void TesteCalculadora3()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.multiplicar(3, 7);
            Assert.AreEqual(num, 21);
        }


        public void TesteCalculadora4()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.dividir(4, 2);
            Assert.AreEqual(2, num);
        }
    }
}