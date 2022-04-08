namespace CalculaFreteApplication.Models
{
    public class Frete
    {
        public int cep { get; set; }
        private ICorreioService correioService;
        public double peso { get; set; }



        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }
        public double CalculaFrete() { return correioService.CalculaFrete(); }
    }
}
