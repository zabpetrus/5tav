using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMaryApp.Application.ViewModels
{
    public class ConsultaPeriodoViewModel
    {
        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public int QtePessoas { get; set; }


       //Construtor Padrão
       public ConsultaPeriodoViewModel() {}


        //Construtor para o Teste
        public ConsultaPeriodoViewModel(DateTime checkin, DateTime checkout, int qtePessoas)
        {
            Checkin = checkin;
            Checkout = checkout;
            QtePessoas = qtePessoas;
        }



     
    }
}
