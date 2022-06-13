using Api.LojaoBazar.Domain.Entities;
using System.Collections.Generic;

namespace Api.LojaoBazar.Domain.Interfaces
{
    public interface ICarrinhoService
    {
        public List<ItensCarrinho> GetItensCarrinho(int idCarrinho);
    }
}
