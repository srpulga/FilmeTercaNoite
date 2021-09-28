using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
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

        [HttpPost] //define metodo da requisição
        //POST: api/filme/create
        [Route("create")]

        public IActionResult Create([FromBody] Filme filme)
        {
            this.Filme = Filme;
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return Created("", filme);
        }

        [HttpGet]
        //GET: api/produto/list
        [Route("list")]

        public IActionResult List() => Ok(_context.Filmes.ToList());

    }
}