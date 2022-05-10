using AppElevator.Application.AppService;
using AppElevator.Domain.Service;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace AppElevator.Tests
{
    public class ElevatorAppTestB
    {
        [Fact]
        public void TestAndarMenosUtilizado()
        {
            ///List<int> Deve retornar uma List contendo o(s) andar(es) menos utilizado(s).
            List<int> response = new List<int>() { 0,5,6,7,9,10,11,12,14 };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.andarMenosUtilizado()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<int> mylist = elevatorAppService.andarMenosUtilizado();

            Assert.Equal(response, mylist);

        }

        [Fact]
        public void TestElevadorMaisFrequentado()
        {

            //List<char> Deve retornar uma List contendo o(s) elevador(es) mais frequentado(s)
            List<Char> response = new List<Char>() { 'A', 'C', 'B', 'D', 'E' };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.elevadorMaisFrequentado()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<Char> mylist = elevatorAppService.elevadorMaisFrequentado();

            Assert.Equal(mylist,response);
        }

        [Fact]
        public void TestPeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            // List<char> - Deve retornar uma List contendo o período de maior fluxo de cada um dos elevadores mais frequentados (se houver mais de um).
            List<char> response = new List<char>() { 'M', 'V', 'N' };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.periodoMaiorFluxoElevadorMaisFrequentado()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<char> mylist = elevatorAppService.periodoMaiorFluxoElevadorMaisFrequentado();

            Assert.Equal(response, mylist);
        }

        [Fact]
        public void TestElevadorMenosFrequentado()
        {
            //List<char>  Deve retornar uma List contendo o(s) elevador(es) menos frequentado(s)
            List<char> response = new List<char>() { 'D', 'E' };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.elevadorMenosFrequentado()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<char> mylist = elevatorAppService.elevadorMenosFrequentado();

            Assert.Equal(response, mylist);

        }

        [Fact]
        public void TestPeriodoMenorFluxoElevadorMenosFrequentado()
        {
            //List<char> Deve retornar uma List contendo o período de menor fluxo de cada um dos elevadores menos frequentados (se houver mais de um).
            List<char> response = new List<char>() { 'N' };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.periodoMenorFluxoElevadorMenosFrequentado()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<char> mylist = elevatorAppService.periodoMenorFluxoElevadorMenosFrequentado();

            Assert.Equal(response, mylist);

        }   

        [Fact]
        public void TestPeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            //List<char> - Deve retornar uma List contendo o(s) periodo(s) de maior utilização do conjunto de elevadores.
            List<char> response = new List<char>() { 'M', 'V' };

            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.periodoMaiorUtilizacaoConjuntoElevadores()).Returns(response);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            List<char> mylist = elevatorAppService.periodoMaiorUtilizacaoConjuntoElevadores();

            Assert.Equal(response, mylist);
        }

        [Fact]
        public void TestPercentualDeUsoElevadorA()
        {            
            //float - Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador A em relação a todos os serviços prestados.
                                    
            float aux = 12.5f;
            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.percentualDeUsoElevadorA()).Returns(aux);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            float num = elevatorAppService.percentualDeUsoElevadorA();

            Assert.Equal(aux, num);
        }

        [Fact]
        public void TestPercentualDeUsoElevadorB()
        {
            //float - Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador B em relação a todos os serviços prestados.
            float aux = 12.5f;
            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.percentualDeUsoElevadorB()).Returns(aux);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            float num = elevatorAppService.percentualDeUsoElevadorB();

            Assert.Equal(aux, num);

        }

        [Fact]
        public void TestPercentualDeUsoElevadorC()
        {
            //float - Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador C em relação a todos os serviços prestados.
            float aux = 12.5f;
            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.percentualDeUsoElevadorC()).Returns(aux);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            float num = elevatorAppService.percentualDeUsoElevadorC();

            Assert.Equal(aux, num);

        }

        [Fact]
        public void TestPercentualDeUsoElevadorD()
        {
            //float - Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador D em relação a todos os serviços prestados.
            float aux = 12.5f;
            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.percentualDeUsoElevadorD()).Returns(aux);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            float num = elevatorAppService.percentualDeUsoElevadorD();

            Assert.Equal(aux, num);

        }

        [Fact]
        public void TestPercentualDeUsoElevadorE()
        {
            //float - Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador E em relação a todos os serviços prestados
            float aux = 12.5f;
            Mock<IElevadorService> mock = new Mock<IElevadorService>();
            mock.Setup(m => m.percentualDeUsoElevadorE()).Returns(aux);

            ElevatorAppService elevatorAppService = new ElevatorAppService(mock.Object);
            float num = elevatorAppService.percentualDeUsoElevadorE();

            Assert.Equal(aux, num);


        }






    }
}
