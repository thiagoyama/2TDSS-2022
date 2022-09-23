using Fiap.Aula05.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Persistencia
{
    public class GestaoAereaContext : DbContext
    {
        public DbSet<Voo>? Voos { get; set; }

        public GestaoAereaContext(DbContextOptions options) : base(options)
        {
        }
    }
}
