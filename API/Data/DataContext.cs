
using FilmeTercaNoite.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeTercaNoite.Data
{
    public class DataContext : DbContext
    {
        // Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Filme> Filmes { get; set; }

    }
}