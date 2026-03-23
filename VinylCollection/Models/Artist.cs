using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylCollection.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Podaj nazwę artysty")]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Country { get; set; }

        // Nawigacja — jeden artysta ma wiele płyt
        public virtual ICollection<Vinyl>? Vinyls { get; set; }
    }
}