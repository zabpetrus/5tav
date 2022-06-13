using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.LojaoBazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET: api/<ProdutosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            var valor = clienteAppService.Get(id).ToString(); //String por inferência

            return valor;
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public void Post([FromBody] ClienteCreateViewModel clientesCreateViewModel)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            clienteAppService.Create(clientesCreateViewModel);
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClienteResultViewModel clienteResultViewModel)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            bool response = clienteAppService.Put(id, clienteResultViewModel);
            if (response) { Console.WriteLine("Success"); } else { Console.WriteLine("Error"); }


        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            bool response = clienteAppService.Delete(id);
            if (response) { Console.WriteLine("Success"); } else { Console.WriteLine("Error"); }

        }
    }
}
