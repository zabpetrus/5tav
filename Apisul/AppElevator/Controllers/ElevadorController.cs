﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("/moe")]
        public string GetMoe()
        {
            return "Ola Moe!";
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
