using api_dados_prestadores.Models;
using Microsoft.EntityFrameworkCore;

namespace api_dados_prestadores.Data
{
    public class PrestadorContext : DbContext
    {
        public PrestadorContext(DbContextOptions<PrestadorContext> options) : base (options) { }

        public DbSet<Prestador> Prestadores { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}
