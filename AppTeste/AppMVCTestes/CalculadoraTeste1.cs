using AppMVCAplication;
using System;
using Xunit;

namespace AppMVCTestes
{
    public class CalculadoraTeste1
    {
        [Fact]
        public void Test1()
        {
            //
        }

        [Fact]
        public void TesteCalculadora()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.soma(3, 4);
            Assert.Equal(7, num);

        }

        [Fact]
        public void TesteCalculadora2()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.subtrair(6, 9);
            Assert.Equal(num, -3);
        }

        [Fact]
        public void TesteCalculadora3()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.multiplicar(3, 7);
            Assert.Equal(21, num);
        }

        [Fact]
        public void TesteCalculadora4()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.dividir(4, 2);
            Assert.Equal(2, num);
        }

        [Fact]
        public void testeCalculadora5()
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.subtrair(-9, -5);
            Assert.Equal(num, -4);

        }

        [Fact]
        public void testeCalculadora6()
        {
            Calculadora calculadora = new Calculadora();
            Assert.Equal(4.3, calculadora.subtrair(6.3, 2));
        }
    }
}
