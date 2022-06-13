using Api.LojaoBazar.Domain.Entities;
using Xunit;

namespace Api.LojaoBazar.Tests.Domain.Entities
{
    public class EntregaTests
    {
        [Fact]
        public void Teste1()
        {
            Entrega entrega = new Entrega();
            entrega.setId(1);
            entrega.setStatus(false);

            Assert.NotNull(entrega);
        }

    }
}
