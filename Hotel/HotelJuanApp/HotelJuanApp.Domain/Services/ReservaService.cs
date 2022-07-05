using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace HotelJuanApp.Domain.Services
{
    public class ReservaService : IReservaService
    {

        // private IReservaService _reservaService;

        public ReservaService() { }



        // Ao por a injeção em Startup, precisamos remover a interface do construtor
        //public ReservaService( IReservaService reservaService) {  _reservaService = reservaService;  } 


        public List<Quarto> GetQuartosDisponiveis(DateTime dtinicio, DateTime dtfinal, int quantidade)
        {
            List<Quarto> temp = new();
            temp.Add(new Quarto(369, 2, "Standard", 698.99));
            //return _reservaService.GetQuartosDisponiveis(dtinicio, dtfinal, quantidade);

            return temp;
        }
    }
}
