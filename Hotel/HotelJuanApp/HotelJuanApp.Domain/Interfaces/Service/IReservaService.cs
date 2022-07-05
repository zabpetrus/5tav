using HotelJuanApp.Domain.Entity;
using System;
using System.Collections.Generic;

namespace HotelJuanApp.Domain.Interfaces.Service
{
    public interface IReservaService
    {
        public List<Quarto> GetQuartosDisponiveis(DateTime dtinicio, DateTime dtfinal, int quantidade);
    }
}
