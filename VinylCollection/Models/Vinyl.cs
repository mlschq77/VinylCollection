using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylCollection.Models
{
    public class Vinyl
    {
        [Key]
        public int VinylId { get; set; }

        [Required(ErrorMessage = "Podaj tytuł płyty")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Range(1900, 2100, ErrorMessage = "Podaj poprawny rok")]
        public int ReleaseYear { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }

        // Klucz obcy do artysty (relacja 1:N)
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        // Nawigacja — płyta ma wiele utworów (1:N)
        public virtual ICollection<Track>? Tracks { get; set; }

        // Nawigacja — płyta ma wiele gatunków (N:M)
        public virtual ICollection<Genre>? Genres { get; set; }
    }
}