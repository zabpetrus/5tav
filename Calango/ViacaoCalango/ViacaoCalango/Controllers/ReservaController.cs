using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.Interfaces;
using ViacaoCalango.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViacaoCalango.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaAppService _reservaAppService;

        public ReservaController(IReservaAppService reservaAppService)
        {
            _reservaAppService = reservaAppService;
        }

        public ReservaController() { }


        // GET: api/<ReservaController>
        [HttpGet]
        public List<string> Get()
        {
            List<ReservaViewModel> listaReservas = null;

            if (_reservaAppService == null)
            {
                ReservaAppService reservaAppService = new ReservaAppService();
                listaReservas = reservaAppService.GetAll();
            }
            else
            {
                listaReservas = _reservaAppService.GetAll();
            }

            return listaReservas.Select(s => s.toString()).ToList();
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if(_reservaAppService == null)
            {
                 ReservaAppService reservaAppService = new ReservaAppService();
                 return reservaAppService.GetById(id).toString();
            }

            return "Erro";
           
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] ReservaViewModel reservaViewModel)
        {
            if (_reservaAppService == null)
            {
                ReservaAppService reservaAppService = new ReservaAppService();
                if(reservaAppService.Create(reservaViewModel))
                {
                    StatusCode(201);
                }
            }
            StatusCode(203);
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReservaViewModel reservaViewModel)
        {
            if (_reservaAppService == null)
            {
                ReservaAppService reservaAppService = new ReservaAppService();
                if(reservaAppService.Update(id, reservaViewModel))
                {
                    StatusCode(202);
                }
            }

            StatusCode(404);
            
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if(_reservaAppService == null)
            {
                ReservaAppService reservaAppService = new ReservaAppService();
                if(reservaAppService.Delete(id))
                {
                    StatusCode(203);
                }
            }
            StatusCode(404);
        }
    }
}
