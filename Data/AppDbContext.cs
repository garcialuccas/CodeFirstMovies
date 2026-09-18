using CodeFirstMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CodeFirstMovies.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Diretor> Diretoes => Set<Diretor>();

        public DbSet<Filme> Filmes => Set<Filme>();

        public DbSet<Genero> Generos => Set<Genero>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diretor>().HasMany(d => d.Filmes).WithOne(f => f.Diretor).HasForeignKey(f => f.IdDiretor);

            modelBuilder.Entity<Filme>().HasMany(f => f.Generos).WithMany(g => g.Filmes);
        }
    }
}
