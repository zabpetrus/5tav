using HotelMaryApp.Application.AppService;
using HotelMaryApp.Application.Interfaces;
using HotelMaryApp.Application.ViewModels;
using HotelMaryApp.Domain.Entities;
using HotelMaryApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HotelMaryApp.Tests.Application
{
    public class ReservasUnitest
    {
        [Fact]
        public void Test1()
        {
            ConsultaPeriodoViewModel consultaPeriodoViewModel = new ConsultaPeriodoViewModel(
                DateTime.Now.AddDays(2), //Daqui a dois dias
                DateTime.Now.AddDays(6), //Daqui a seis dias
                2 //Qte Pessoas
            );

            IReservaAppService reservaApp = new ReservaAppService();
            var x = reservaApp.GetQuartosDisponiveis(consultaPeriodoViewModel);
            Assert.True(x.Count > 0);   
        }

        [Fact]
        public void Test2()
        {
            Quarto quarto = new Quarto();
        }
    }
}
