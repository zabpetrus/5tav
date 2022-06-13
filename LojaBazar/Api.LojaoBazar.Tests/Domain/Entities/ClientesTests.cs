using Api.LojaoBazar.Domain.Entities;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class ClientesTests
    {
        [Fact]
        public void teste1()
        {
            Cliente cliente = new Cliente();
            cliente.setId(1);
            cliente.setNome("João da Cunha");
            cliente.setEmail("joaocunha@gmail.com");
            cliente.setCpf("569.633.987-96");
            cliente.setStatus(true);
            cliente.setSenha("123456");

            Assert.NotNull(cliente);
        }
    }
}
