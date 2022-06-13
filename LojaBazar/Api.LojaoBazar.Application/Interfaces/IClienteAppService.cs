using Api.LojaoBazar.Application.ViewModel;

namespace Api.LojaoBazar.Application.Interfaces
{
    public interface IClienteAppService
    {
        public ClienteResultViewModel Create(ClienteCreateViewModel clienteCreateViewModel);

        public ClienteResultViewModel Get(int id);

        public bool Put(int id, ClienteResultViewModel clienteResultViewModel);

        public bool Delete(int id);





    }
}
