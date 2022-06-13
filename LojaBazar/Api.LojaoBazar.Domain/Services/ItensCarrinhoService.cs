using Api.LojaoBazar.Domain.Entities;
using Api.LojaoBazar.Domain.Interfaces;
using System.Collections.Generic;

namespace Api.LojaoBazar.Domain.Services
{
    public class ItensCarrinhoService
    {
        private ICarrinhoService _carrinhoService;

        public ItensCarrinhoService(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }

        public List<ItensCarrinho> GetItensCarrinho(int idCarrinho)
        {
            return _carrinhoService.GetItensCarrinho(idCarrinho);
        }
    }
}
