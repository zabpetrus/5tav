namespace Api.LojaoBazar.Domain.Interfaces
{
    public interface IPagamentoService
    {
        public bool CartaoValido();

        public bool GetPagamento(int id);


    }
}
