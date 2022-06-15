using HotelMaryApp.Application.Interfaces;
using HotelMaryApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMaryApp.Application.AppService
{
    public class ReservaAppService : IReservaAppService
    {
        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consultaPeriodoViewModel)
        {
            List<QuartoViewModel> result = new List<QuartoViewModel>();
            result.Add(new QuartoViewModel(304, 2, "Standard", 202.00d));
            return result;
        }
    }
}
