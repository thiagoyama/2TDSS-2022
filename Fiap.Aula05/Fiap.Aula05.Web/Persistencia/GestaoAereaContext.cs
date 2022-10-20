using Fiap.Aula05.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Persistencia
{
    public class GestaoAereaContext : DbContext
    {
        public DbSet<Voo> Voos { get; set; }
        public DbSet<FrequenciaVoo> FrequenciasVoo { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<VooServico> VoosServicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a chave composta da associativa
            modelBuilder.Entity<VooServico>()
                .HasKey(v => new { v.ServicoId, v.VooId });
            //Configurar a relação da associativa com o voo
            modelBuilder.Entity<VooServico>()
                .HasOne(v => v.Voo)
                .WithMany(v => v.VoosServicos)
                .HasForeignKey(v => v.VooId);
            //Configurar a relação da associativa com o serviço
            modelBuilder.Entity<VooServico>()
                .HasOne(v => v.Servico)
                .WithMany(v => v.VoosServicos)
                .HasForeignKey(v => v.ServicoId);
            base.OnModelCreating(modelBuilder);
        }

        public GestaoAereaContext(DbContextOptions options) : base(options)
        {
        }
    }
}
