using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entities;
using AutoMapper;
using ViacaoCalango.Domain.Interfaces;

namespace ViacaoCalango.Domain.Services
{
    public class ReservaService : IReservaService
    {
        private IReservaService _reservaService;

        public ReservaService(){}

        public ReservaService(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public Reserva CriarReserva(int PassageiroID, Viagem viagem, Lugar lugar)
        {
            return _reservaService.CriarReserva(PassageiroID, viagem, lugar);   
        }

        public List<Onibus> listadeOnibusDiaRota(Rota rota, DateTime diaorigem)
        {
            return _reservaService.listadeOnibusDiaRota(rota, diaorigem);   
        }

        public List<Viagem> listaReservasDia(DateTime diaorigem)
        {
            return _reservaService.listaReservasDia(diaorigem);
        }

        public List<Lugar> VerificarListaLugaresDisponiveis(Onibus onibus, Trecho atual)
        {
            return _reservaService.VerificarListaLugaresDisponiveis(onibus, atual);
        }

        public bool VerificarLugaresDisponiveis(Onibus onibus, int nassento, Trecho atual)
        {
            return _reservaService.VerificarLugaresDisponiveis(onibus, nassento, atual);
        }

        public bool VerificarPassageiroOnibus(int PassageiroID, Onibus onibus)
        {
            return _reservaService.VerificarPassageiroOnibus(PassageiroID, onibus);
        }

        public int VerQuantidadeLugar(Onibus onibus)
        {
            return _reservaService.VerQuantidadeLugar(onibus);
        }
    }
}
