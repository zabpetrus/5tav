using HotelMaryApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMaryApp.Application.Interfaces
{
    public interface IReservaAppService
    {
        List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consultaPeriodoViewModel);

    }
}
