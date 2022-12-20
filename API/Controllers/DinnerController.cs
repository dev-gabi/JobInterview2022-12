using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinnerController : ControllerBase
    {
        DinnerLogic logic = new DinnerLogic();

        [HttpGet]
        public List<DinnerEvent> Get()
        {
            return logic.GetAllDinnerEvents();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            DinnerEvent d = logic.GetDinnerEventById(id);
            if(d == null)
            {
                return Problem(statusCode: 404);
            }
            return Ok(d);
        }

        [HttpGet("employee/{id}")]
        public IActionResult GetDinnerEventsByEmployee(string id)
        {
            List<DinnerEvent> d = logic.GetDinnerEventsByEmployee(id);
            if (d.Count == 0)
            {
                return Problem(statusCode: 404);
            }
            return Ok(d);
        }

        [HttpPost]
        public void Post([FromBody] DinnerEvent dinnerEvent)
        {
            logic.AddNewDinnerEvent(dinnerEvent);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DinnerEvent dinnerEvent)
        {
            if (logic.EditDinnerEvent(dinnerEvent))
            {
                return Ok();
            }
            return Problem(detail: "Id not found", statusCode:404);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (logic.DeleteDinnerEvent(id))
            {
                return Ok();
            }
            return Problem(detail: "An error had occured");
        }
    }
}
