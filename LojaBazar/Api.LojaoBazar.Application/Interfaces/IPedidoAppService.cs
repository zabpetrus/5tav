using Api.LojaoBazar.Application.ViewModel;

namespace Api.LojaoBazar.Application.Interfaces
{
    public interface IPedidoAppService
    {
        public void Create(PedidoCreateViewModel pedidoCreateViewModel);

        public PedidoResultViewModel CreatePedido(PedidoCreateViewModel pedidoCreateViewModel);

        public PedidoResultViewModel GetById(int id);

    }
}
