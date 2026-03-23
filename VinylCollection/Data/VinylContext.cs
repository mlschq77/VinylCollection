using Microsoft.EntityFrameworkCore;
using VinylCollection.Models;

namespace VinylCollection.Data
{
    public class VinylContext : DbContext
    {
        public VinylContext(DbContextOptions options) : base(options) { }

        // Każda linia = jedna tabela w bazie danych
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definiujemy relację wiele-do-wielu: Vinyl <-> Genre
            modelBuilder.Entity<Vinyl>()
                .HasMany(v => v.Genres)
                .WithMany(g => g.Vinyls);
        }
    }
}