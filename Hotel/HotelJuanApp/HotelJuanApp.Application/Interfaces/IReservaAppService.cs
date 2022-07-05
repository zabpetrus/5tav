using HotelJuanApp.Application.ViewModels;
using System.Collections.Generic;

namespace HotelJuanApp.Application.Interfaces
{
    public interface IReservaAppService
    {
        List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta);

        List<QuartoViewModel> GetAll();

        QuartoViewModel GetById(int id);

        bool CreateReserva(QuartoViewModel quarto);

        bool ExcluirReserva(int id);

        bool AtualizarReserva(int id, QuartoViewModel quarto);

    }
}
