using AppElevator.Domain;
using AppElevator.Domain.Service;
using AppElevator.Infra.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppElevator.Application.AppService
{
    public class ElevatorAppService : IElevadorService
    {
        private IElevadorService _elevatorService; //Localizado no Domain > Service


        private JArray jsonArray;

        //Recebo o array já devidamente processado do arquivo
        public ElevatorAppService() {

            ReadJsonData readJsonData = new ReadJsonData();
            this.jsonArray = readJsonData.GetData();
        }
    
        public ElevatorAppService( IElevadorService elevatorService)
        {
            _elevatorService = elevatorService;        
        }

        //Métodos privados para calculo

        private Dictionary<char, int> ContadorFrequenciadosElevadores()
        {
            JArray jarray = this.jsonArray;
            Dictionary<char, int> contadorFrequenciaElevadores = new Dictionary<char, int>();
            foreach (var j in jarray)
            {
                Elevator elevador = j.ToObject<Elevator>();
                ///Contando as partes
                if (contadorFrequenciaElevadores.ContainsKey(elevador.elevador))
                {
                    contadorFrequenciaElevadores[elevador.elevador] += 1;
                }
                else
                {
                    contadorFrequenciaElevadores.Add(elevador.elevador, 1);
                }               
            }

            return contadorFrequenciaElevadores;
        }


        private Dictionary<int,int> ContadorAndares()
        {
            Dictionary<int,int> contadorAndares = new Dictionary<int,int>();
            foreach (var j in this.jsonArray)
            {
                Elevator elevador = j.ToObject<Elevator>();
                if (contadorAndares.ContainsKey(elevador.turno))
                {
                    contadorAndares[elevador.turno]++;
                }
                else
                {
                    contadorAndares.Add(elevador.turno, 1);
                }
            }
            return contadorAndares;
        }

        private Dictionary<char, int> ContadorTurnosdosElevadores()
        {
            JArray jarray = this.jsonArray;
            Dictionary<char, int> contadorTurnoElevadores = new Dictionary<char, int>();
            foreach (var j in jarray)
            {
                Elevator elevador = j.ToObject<Elevator>();
                ///Contando as partes
                if (contadorTurnoElevadores.ContainsKey(elevador.turno))
                {
                    contadorTurnoElevadores[elevador.turno] += 1;
                }
                else
                {
                    contadorTurnoElevadores.Add(elevador.turno, 1);
                }
            }

            return contadorTurnoElevadores;
        }



        //Aplicando os metodos da interface IElevadorService

        public List<int> andarMenosUtilizado()
        {
            var listaandares = this.ContadorAndares(); //Obtendo um contador com os andares
            List<int> lista = new List<int>();
            foreach (var item in listaandares)
            {
                if ((item.Value) == listaandares.Values.Min()) lista.Add(item.Key);   
                
            }

            return lista;
        }

        public List<char> elevadorMaisFrequentado()
        {
            var listaElevadores = this.ContadorFrequenciadosElevadores(); //Obtendo um contador com os andares
            List<char> lista = new List<char>();
            foreach (var item in listaElevadores)
            {
                if ((item.Value) == listaElevadores.Values.Max()) lista.Add(item.Key);
            }

            return lista;
        }

        public List<char> elevadorMenosFrequentado()
        {
            var listaElevadores = this.ContadorFrequenciadosElevadores(); //Obtendo um contador com os andares
            List<char> lista = new List<char>();
            foreach (var item in listaElevadores)
            {
                if ((item.Value) == listaElevadores.Values.Min()) lista.Add(item.Key);
            }

            return lista;
        }




        public float percentualDeUsoElevadorA()
        {
            return _elevatorService.percentualDeUsoElevadorA();
        }

        public float percentualDeUsoElevadorB()
        {
            return _elevatorService.percentualDeUsoElevadorB();
        }

        public float percentualDeUsoElevadorC()
        {
            return (_elevatorService.percentualDeUsoElevadorC());
        }

        public float percentualDeUsoElevadorD()
        {
            return (float)_elevatorService.percentualDeUsoElevadorD();  
        }

        public float percentualDeUsoElevadorE()
        {
            return ((float)_elevatorService.percentualDeUsoElevadorE());    
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            return _elevatorService.periodoMaiorFluxoElevadorMaisFrequentado();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            return _elevatorService.periodoMaiorUtilizacaoConjuntoElevadores();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            return _elevatorService.periodoMenorFluxoElevadorMenosFrequentado();
        }

        //Métodos criados para a questão determinada

        public object percentualDeUsoCadaElevador()
        {
            return _elevatorService.percentualDeUsoElevadorA();
        }
    }
}
