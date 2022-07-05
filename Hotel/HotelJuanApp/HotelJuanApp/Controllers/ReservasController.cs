using HotelJuanApp.Application;
using HotelJuanApp.Application.AppService;
using HotelJuanApp.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelJuanApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        // GET: api/<ReservasController>
        [HttpGet]
        public List<QuartoViewModel> Get()
        {
            ReservaAppService reserva = new ReservaAppService();
            return reserva.GetAll(); // new string[] { "value1", "value2" };
        }

        // GET api/<ReservasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            ReservaAppService reserva = new ReservaAppService();
            return reserva.GetById(id).ToString();
        }


        // GET api/<ReservasController>/5
        [HttpGet("{consulta}")]
        public List<QuartoViewModel> GetQuartosDisponiveis([FromBody] ConsultaPeriodoViewModel consulta)
        {
            ReservaAppService reserva = new ReservaAppService();
            return reserva.GetQuartosDisponiveis(consulta);
        }


        // POST api/<ReservasController>
        [HttpPost]
        public void Post([FromBody] QuartoViewModel quarto)
        {
            ReservaAppService reserva = new ReservaAppService();
            bool success = reserva.CreateReserva(quarto);
            if (!success)
            {
                throw new Exception("Deu ruim");
            }
        }

        // PUT api/<ReservasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] QuartoViewModel quarto)
        {
            ReservaAppService reserva = new ReservaAppService();
            bool success = reserva.AtualizarReserva(id, quarto);
            if (!success)
            {
                throw new Exception("Deu ruim 2");
            }

        }

        // DELETE api/<ReservasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ReservaAppService reserva = new ReservaAppService();
            bool success = reserva.ExcluirReserva(id);
            if (!success)
            {
                throw new Exception("Falha em excluir");
            }
        }
    }
}
