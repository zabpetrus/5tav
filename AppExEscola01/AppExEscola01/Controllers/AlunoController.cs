using AppExEscola01.Application.AppService;
using AppExEscola01.Application.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppExEscola01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // GET: api/<AlunoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            AlunoAppService alunoAppService = new AlunoAppService();
            return alunoAppService.GetById(id).ToString();
        }

        // POST api/<AlunoController>
        [EnableCors]
        [HttpPost]
        public void Post([FromBody] AlunoCreateViewModel alunoCreateViewModel)
        {
            //Criação da entidade AlunoMatriculado receberá um aluno pré-matriculado
            AlunoResultViewModel novoaluno = new AlunoResultViewModel(alunoCreateViewModel);

        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
