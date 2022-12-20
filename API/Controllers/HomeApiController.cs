using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeApiController : ControllerBase
    {
        // GET: api/<HomeApiController>

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        [HttpGet("{eventName}/names/{id}")]
        public string GetEventNames(string eventName, int id)
        {
            return $"event: {eventName}, id {id}";
        }

        // GET api/<HomeApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/<HomeApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
