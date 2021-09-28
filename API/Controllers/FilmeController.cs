using System.Linq;
using FilmeTercaNoite.Data;
using FilmeTercaNoite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeTercaNoite.Controllers
{
    [ApiController]
    [Route("api/filme")]

    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;

        public FilmeController(DataContext context)
        {
            _context = context;
        }

        [HttpPost] 
        //define metodo da requisição
        //POST: api/filme/create
        [Route("create")]
        public IActionResult Create([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return Created("", filme);
        }

        [HttpGet]
        //GET: api/filme/list
        [Route("list")]
        public IActionResult List() => Ok(_context.Filmes.ToList());

    }
}