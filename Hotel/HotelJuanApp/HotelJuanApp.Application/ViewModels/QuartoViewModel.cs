using System;

namespace HotelJuanApp.Application.ViewModels
{
    public class QuartoViewModel
    {
        public int Numero { get; set; }

        public int QtePessoas { get; set; }

        public String Classificacao { get; set; }

        public Double ValorDiaria { get; set; }

        public QuartoViewModel(int numero, int qtePessoas, string classificacao, double valorDiaria)
        {
            Numero = numero;
            QtePessoas = qtePessoas;
            Classificacao = classificacao;
            ValorDiaria = valorDiaria;
        }

        public QuartoViewModel() { }
    }
}
