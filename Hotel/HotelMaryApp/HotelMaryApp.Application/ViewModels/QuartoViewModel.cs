using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMaryApp.Application.ViewModels
{
    public class QuartoViewModel
    {
       

        public int Numero { get; set; }

        public int QtePessoas { get; set; }

        public String Classificacao { get; set; }

        public Double ValorDiaria { get; set; }


        //Construtor padrão
        public QuartoViewModel(){ }


        //Construtor para Teste
        public QuartoViewModel(int numero, int qtePessoas, string classificacao, double valorDiaria)
        {
            Numero = numero;
            QtePessoas = qtePessoas;
            Classificacao = classificacao;
            ValorDiaria = valorDiaria;
        }

        


    }
}
