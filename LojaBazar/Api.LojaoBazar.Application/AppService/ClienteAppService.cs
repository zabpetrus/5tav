using Api.LojaoBazar.Application.Interfaces;
using Api.LojaoBazar.Application.ViewModel;

namespace Api.LojaoBazar.Application.AppService
{
    public class ClienteAppService
    {

        private IClienteAppService _clienteAppService;

        public ClienteAppService() { }

        public ClienteAppService(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        public ClienteResultViewModel Create(ClienteCreateViewModel clienteCreateViewModel)
        {
            return _clienteAppService.Create(clienteCreateViewModel);
        }

        public ClienteResultViewModel Get(int id)
        {
            return _clienteAppService.Get(id);
        }

        public bool Put(int id, ClienteResultViewModel clienteResultViewModel)
        {
            return _clienteAppService.Put(id, clienteResultViewModel);
        }

        public bool Delete(int id)
        {
            return (_clienteAppService.Delete(id));
        }
    }
}
