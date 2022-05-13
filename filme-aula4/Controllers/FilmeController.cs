using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using filme.Entity;
using filme.Service;
using AutoMapper;
using filme.Dto;

namespace filme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private readonly ILogger<FilmeController> _logger;
        private IFilmeService _service;
        private IMapper _mapper;

        public FilmeController(ILogger<FilmeController> logger, IFilmeService service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult retornaFilmes(){

            List<Filme> filmes = _service.listarFilmes();
            var mapeado=_mapper.Map<List<FilmeGetDto>>(filmes);
            return Ok(mapeado);
        }

    // /filme/{id} => /filme/1
        [HttpGet("{id}")]
        public IActionResult procuraFilme([FromRoute] int id){
            Filme filmes = _service.encontrarFilme(id);
            if (filmes == null){
                NotFound();
            }
            return Ok(filmes);
        }

        [HttpPost]
        public IActionResult adicionaFilme([FromBody]Filme filme){
            _service.salvarFilme(filme);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult atualizaFilme(
            [FromBody]Filme filme, 
            int id
        ){
            var response = _service.atualizarFilme(filme, id);
            if (response==null){
                return NotFound();
            }
            return Ok(response);
        }

//Task<ActionResult<IEnumerable<ProductGetDTO>>> GetProduct()
        [HttpDelete("{id}")]
        public IActionResult deletaFilme(int id){
            _service.deletarFilme(id);
            return NoContent();
        }
    }
}