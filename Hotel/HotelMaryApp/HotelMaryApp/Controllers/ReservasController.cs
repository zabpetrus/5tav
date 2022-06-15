﻿using HotelMaryApp.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelMaryApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        // GET: api/<ReservasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReservasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/<ReservasController>
        [HttpGet("{consultaPeriodoViewModel}")]
        public List<QuartoViewModel> GetQuartosDisponiveis([FromBody] ConsultaPeriodoViewModel consultaPeriodoViewModel)
        {
            return new List<QuartoViewModel>();
            
        }

        // POST api/<ReservasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
