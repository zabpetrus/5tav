namespace AppMVCAplication.Models
{
    public interface ICalculadora
    {
        //Versão inteiro

        public int soma(int n1, int n2);

        public int subtrair(int n1, int n2);

        public int multiplicar(int n1, int n2);

        public int dividir(int v1, int v2);

        //Versão double

        public double soma(double n1, double n2);

        public double subtrair(double n1, double n2);

        public double multiplicar(double n1, double n2);

        public double dividir(double v1, double v2);


    }
}
