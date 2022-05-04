using AppAPICalculadora.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPICalculadora.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APICalculadoraSimplesController : ControllerBase
    {
        // GET: api/<APIValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<APIValuesController>/5
        [HttpGet("{numbers}")]
        public string Get(List<double> numbers)
        {
            return "value";
        }

        // Aplicando o método de soma
        [HttpGet("/soma/{val1}/{val2}")]
        public double GetSoma(double val1, double val2)
        {
            CalculadoraSimples duocalc = new(val1, val2);
            return duocalc.soma();
        }

        // Aplicando o método de subtração
        [HttpGet("/subtracao/{val1}/{val2}")]
        public double GetSubtracao(double val1, double val2)
        {
            CalculadoraSimples duocalc = new(val1, val2);
            return duocalc.subtracao();
        }

        // Aplicando o método de multiplicação
        [HttpGet("/multiplicacao/{val1}/{val2}")]
        public double GetMultiplicacao(double val1, double val2)
        {
            CalculadoraSimples duocalc = new(val1, val2);
            return duocalc.multiplicacao();
        }


        // Aplicando o método de divisão
        [HttpGet("/divisao/{val1}/{val2}")]
        public double GetDivisao(double val1, double val2)
        {
            CalculadoraSimples duocalc = new(val1, val2);
            return duocalc.divisao();
        }             


    }
}
