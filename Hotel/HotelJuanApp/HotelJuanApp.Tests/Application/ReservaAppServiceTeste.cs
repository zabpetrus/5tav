using HotelJuanApp.Application;
using HotelJuanApp.Application.AppService;
using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Application.ViewModels;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace HotelJuanApp.Tests.Application
{
    public class ReservaAppServiceTeste
    {
       // private IReservaAppService _reservaAppService { get; set; }

       // public ReservaAppServiceTeste(IReservaAppService reservaAppService) { _reservaAppService = reservaAppService; }

        [Fact]
        public void TestGet()
        {
            List<QuartoViewModel> lista = new List<QuartoViewModel>();

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.GetAll()).Returns(lista);


            ReservaAppService reserva = new ReservaAppService(mock.Object);
            var result = reserva.GetAll();

            //var result = _reservaAppService.GetAll();

            Assert.Equal(lista, result);

        }

        [Fact]
        public void TestGetID()
        {

            int id = 1;
            //int numero, int qtePessoas, string classificacao, double valorDiaria
            QuartoViewModel quarto = new QuartoViewModel(365, 2, "Standard", 365.66);


            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.GetById(id)).Returns(quarto);

            ReservaAppService reserva = new ReservaAppService(mock.Object);
            var result = reserva.GetById(id);
            //var result = _reservaAppService.GetById(id);

            Assert.Equal(quarto, result);
        }

        [Fact]
        public void TestGetQuartosDisponiveis()
        {
            ConsultaPeriodoViewModel consulta = new ConsultaPeriodoViewModel();

            List<QuartoViewModel> lista = new();

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.GetQuartosDisponiveis(consulta)).Returns(lista);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var result = reservaAppService.GetQuartosDisponiveis(consulta);
            //var result = _reservaAppService.GetQuartosDisponiveis(consulta); 

            Assert.Equal(lista, result);

        }


        [Fact]
        public void TestCreateReserva()
        {
            var question = true;
            QuartoViewModel quartoViewModel = new QuartoViewModel();

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.CreateReserva(quartoViewModel)).Returns(question);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var result = reservaAppService.CreateReserva(quartoViewModel);

            //var result = _reservaAppService.CreateReserva(quartoViewModel);

            Assert.Equal(question, result);


        }


        [Fact]
        public void TestAtualizarReserva()
        {
            int id = 1;
            QuartoViewModel quartoViewModel = new QuartoViewModel();
            var status = true;

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.AtualizarReserva(id, quartoViewModel)).Returns(status);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var result = reservaAppService.AtualizarReserva(id, quartoViewModel);
            //var result = _reservaAppService.AtualizarReserva(id, quartoViewModel);

            Assert.Equal(status, result);

        }

        [Fact]
        public void TestExcluirReserva()
        {
            var question = true;
            int id = 1;

            Mock<IReservaAppService> mock = new Mock<IReservaAppService>();
            mock.Setup(m => m.ExcluirReserva(id)).Returns(question);

            ReservaAppService reservaAppService = new ReservaAppService(mock.Object);
            var result = reservaAppService.ExcluirReserva(id);

            //var result = _reservaAppService.ExcluirReserva(id);

            Assert.Equal(question, result);
        }

    }
}
