using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        public AlunoController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (var c = new DataContext())
                {
                    return Ok(c.Alunos.ToArray());
                }
                
                return Ok();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine();
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpGet("{AlunoId}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPut]
        public IActionResult put(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }


        [HttpPost]
        public IActionResult post()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpDelete]
        public IActionResult delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
    }
}
