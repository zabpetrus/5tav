using AppElevator.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppElevator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevadorController : ControllerBase
    {
        // GET: api/<ElevadorController>

        [HttpGet]        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //	Obtendo o andar menos utilizado pelos usuários;
        [HttpGet("AndarMenosUtilizado")]
        public char GetAndarMenosUtilizado()
        {
            ElevatorViewModelResult elevator = new ElevatorViewModelResult();
            return elevator.GetAndarMenosUtilizado();
        }

        //Obtendo o elevador mais frequentado e o período que se encontra maior fluxo;
        [HttpGet("ElevadorMaisUsadoMaiorFluxo")]
        public IEnumerable<string> GetElevadorMaisUsadoMaiorFluxo()
        {
            ElevatorViewModelResult elevator = new ElevatorViewModelResult();
            return elevator.GetElevadorMaisUtilizadoMaiorFluxo();
        }

        //Obtendo o elevador menos frequentado e o período que se encontra menor fluxo;
        [HttpGet("ElevadorMenosUsadoMenorFluxo")]
        public IEnumerable<string> GetElevadorMenosUsadoMenorFluxo()
        {
            ElevatorViewModelResult elevator = new ElevatorViewModelResult();
            return elevator.GetElevadorMenosUsadoMenorFluxo();
        }

        //Obtendo o o período de maior utilização do conjunto de elevadores;
        [HttpGet("PeriodoMaiorUtilizacao")]
        public char GetPeriodoMaiorUtilizacaoConjunto()
        {
            ElevatorViewModelResult elevador = new ElevatorViewModelResult();
            return elevador.GetPeriodoMaiorUsoConjunto();

        }

        //Obtendo o o percentual de uso de cada elevador com relação a todos os serviços prestados;
        [HttpGet("PercentualUsoRelacao")]
        public double GetPercentualUso()
        {
            ElevatorViewModelResult elevator = new ElevatorViewModelResult();
            return elevator.GetPercentualUsoRelacaoServicos();
        }



        // GET api/<ElevadorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ElevadorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ElevadorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ElevadorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
