using BeHappy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeHappy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIValuesController : ControllerBase
    {
        // GET: api/<APIValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<APIValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // Aplicando o método de soma
        [HttpGet("/soma/{val1}/{val2}")]
        public double GetSoma(double val1, double val2)
        {
            Duocalc duocalc = new(val1, val2);
            return duocalc.soma();
        }

        // Aplicando o método de subtração
        [HttpGet("/subtracao/{val1}/{val2}")]
        public double GetSubtracao(double val1, double val2)
        {
            Duocalc duocalc = new(val1, val2);
            return duocalc.subtracao();
        }

        // Aplicando o método de multiplicação
        [HttpGet("/multiplicacao/{val1}/{val2}")]
        public double GetMultiplicacao(double val1, double val2)
        {
            Duocalc duocalc = new(val1, val2);
            return duocalc.multiplicacao();
        }


        // Aplicando o método de divisão
        [HttpGet("/divisao/{val1}/{val2}")]
        public double GetDivisao(double val1, double val2)
        {
            Duocalc duocalc = new(val1, val2);
            return duocalc.divisao();
        }


        // POST api/<APIValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<APIValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<APIValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

       
    }
}
