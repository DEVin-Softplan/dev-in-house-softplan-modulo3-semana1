using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using filme.Entity;

namespace filme.Controllers
{
    [ApiController]
    [Route("hello")]
    public class HelloController : Controller
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult hello(){
            Filme filme = new Filme("Star Wars","George Lucas",DateTime.Now);
            return Ok(filme);
        }
    }
}