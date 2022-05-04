namespace AppAPICalculadora.Application.Models
{
    public interface IOperacao //Service
    {
        public double soma();
        public double subracao();
        public double multiplicacao();
        public double divisao();
    }
}
