using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : Controller
    {
        public ProfessorController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{AlunoId}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult put(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult post()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult delete(int id)
        {
            return null;
        }
    }
}
