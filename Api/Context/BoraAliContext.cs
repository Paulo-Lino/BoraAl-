using BoraAli.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BoraAli.Api.Context
{
    public class BoraAliContext : DbContext
    {

        public BoraAliContext(DbContextOptions<BoraAliContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Favorito> Favorito { get; set; }
        public DbSet<PontoTuristico> PontoTuristico { get; set; }
        public DbSet<PrecoIngresso> PrecoIngresso { get; set; }
        public DbSet<Premio> Premio { get; set; }
        public DbSet<Resgate> Resgate { get; set; }
        public DbSet<Visita> Visita { get; set; }
        public DbSet<Roteiro> Roteiro { get; set; }
        public DbSet<HorarioFunc> HorarioFunc { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var Favorito = modelBuilder.Entity<Favorito>();

            Favorito
            .HasOne(f => f.PontoTuristico)
            .WithOne(pt => pt.Favorito)
            .HasForeignKey<Favorito>(f => f.PontosTuristicoId);


            var Usuario = modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nome = "Victor",
                    Email = "victor@gmail.com",
                    Idade = 22,
                    Genero = "Masculino",
                    DataCriacao = DateTime.Now
                }
                );


        }
}
}
