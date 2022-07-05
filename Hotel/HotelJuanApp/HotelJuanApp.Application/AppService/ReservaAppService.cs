using AutoMapper;
using HotelJuanApp.Application.Interfaces;
using HotelJuanApp.Application.ViewModels;
using HotelJuanApp.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace HotelJuanApp.Application.AppService
{
    public class ReservaAppService : IReservaAppService
    {

        private IReservaService _reservaService;

        private IReservaAppService _reservaAppService;

        private readonly IMapper _mapper;

        public ReservaAppService() { }

        public ReservaAppService(IReservaAppService reservaAppService) { _reservaAppService = reservaAppService; }

        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            return _reservaAppService.GetQuartosDisponiveis(consulta);
        }

        public List<QuartoViewModel> GetAll()
        {
            return _reservaAppService.GetAll();
        }

        public QuartoViewModel GetById(int id)
        {
            return _reservaAppService.GetById(id);
        }

        public bool CreateReserva(QuartoViewModel quarto)
        {
            return _reservaAppService.CreateReserva(quarto);
        }

        public bool ExcluirReserva(int id)
        {
            return _reservaAppService.ExcluirReserva(id);
        }

        public bool AtualizarReserva(int id, QuartoViewModel quarto)
        {
            return _reservaAppService.AtualizarReserva(id, quarto);
        }
    }
}
