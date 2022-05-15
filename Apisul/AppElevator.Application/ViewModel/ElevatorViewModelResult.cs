using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppElevator.Application.ViewModel
{
    public class ElevatorViewModelResult
    {
        //Obtem o andar menos utilizado pelos usuários;
        public char GetAndarMenosUtilizado()
        {
            throw new NotImplementedException();
        }

        //Obtém qual é o elevador mais frequentado e o período que se encontra maior fluxo;
        public IEnumerable<string> GetElevadorMaisUtilizadoMaiorFluxo()
        {
            throw new NotImplementedException();
        }

        //Obtém qual é o elevador menos frequentado e o período que se encontra menor fluxo;
        public IEnumerable<string> GetElevadorMenosUsadoMenorFluxo()
        {
            throw new NotImplementedException();
        }

        //Obtém qual o período de maior utilização do conjunto de elevadores;
        public char GetPeriodoMaiorUsoConjunto()
        {
            throw new NotImplementedException();
        }

        //Obtém qual o percentual de uso de cada elevador com relação a todos os serviços prestados;
        public double GetPercentualUsoRelacaoServicos()
        {
            throw new NotImplementedException();
        }
    }
}
