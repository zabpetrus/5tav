using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Defaults;
using ViacaoCalango.Domain.Entities;
using ViacaoCalango.Domain.Interfaces;
using ViacaoCalango.Domain.Services;
using Xunit;

namespace ViacaoCalango.Tests.Infra
{
    public class ReservaServiceTests
    {

        [Fact]
        public void listaReservasDiaTests()
        {
            //Arrange

            List<Viagem> viagensLista = new List<Viagem>();
            DateTime dateTime = DateTime.Now;

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.listaReservasDia(dateTime)).Returns(viagensLista);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.listaReservasDia(dateTime); 

            //Assert
            Assert.Equal(result, viagensLista);
        }


        [Fact]
        public void CriarReservaTests()
        {
            //Arrange
            int id = 1;
            Viagem viagem = new Viagem();
            Lugar lugar = new Lugar();
            Reserva reserva = new Reserva();

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.CriarReserva(id, viagem, lugar)).Returns(reserva);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.CriarReserva(id, viagem, lugar);

            //Assert
            Assert.Equal(result, reserva);
        }

       
        [Fact]
        public void VerQuantidadeLugarTests()
        {
            //Arrange
            int ilugares = 5;
            Onibus onibus = new Onibus();   

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.VerQuantidadeLugar(onibus)).Returns(ilugares);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.VerQuantidadeLugar(onibus);

            //Assert
            Assert.Equal(result, ilugares);
        }


        [Fact]
        public void VerificarLugaresDisponiveisTests()
        {
            //Arrange
            List<Lugar> lugars = new List<Lugar>(); 
            Onibus onibus = new Onibus();
            Trecho trecho = new Trecho();   

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.VerificarListaLugaresDisponiveis(onibus, trecho)).Returns(lugars);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.VerificarListaLugaresDisponiveis(onibus, trecho);

            //Assert
            Assert.Equal(result, lugars);
        }

        [Fact]
        public void listadeOnibusDiaRotaTests()
        {
            //Arrange
            List<Onibus> busao = new List<Onibus>();
            Rota rota = new Rota();
            DateTime dateTime = DateTime.Now;   

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.listadeOnibusDiaRota(rota, dateTime)).Returns(busao);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.listadeOnibusDiaRota(rota, dateTime);

            //Assert
            Assert.Equal(result, busao);
        }

        [Fact]
        public void VerificarPassageiroOnibusTests()
        {
            //Arrange
            bool verifica = true;
            Passageiro passageiro = new Passageiro();
            passageiro.Id = 1;

            Onibus onibus = new Onibus();

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.VerificarPassageiroOnibus(passageiro.Id, onibus)).Returns(verifica);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.VerificarPassageiroOnibus(passageiro.Id, onibus);

            //Assert
            Assert.Equal(result, verifica);
        }

        [Fact]
        public void VerificarListaLugaresDisponiveisTests()
        {
            //Arrange

            List<Lugar> lista = new List<Lugar>();
            Trecho trecho = new Trecho();
            Onibus onibus = new Onibus();

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.VerificarListaLugaresDisponiveis(onibus, trecho)).Returns(lista);

            //Act
            ReservaService reservaService = new ReservaService(mock.Object);
            var result = reservaService.VerificarListaLugaresDisponiveis(onibus, trecho);

            //Assert
            Assert.Equal(result, lista);
        }
    }
}
