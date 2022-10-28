using Fiap.Aula06.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula06.Api.Persistencia
{
    public class DoceriaContext : DbContext
    {
        public DoceriaContext(DbContextOptions op):base(op)
        {

        }

        public DbSet<Doceria> Docerias { get; set; }

    }
}
