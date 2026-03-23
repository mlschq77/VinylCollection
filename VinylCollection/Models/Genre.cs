using System.ComponentModel.DataAnnotations;

namespace VinylCollection.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Podaj nazwę gatunku")]
        [MaxLength(50)]
        public string Name { get; set; }

        // Nawigacja — gatunek może być na wielu płytach (N:M)
        public virtual ICollection<Vinyl>? Vinyls { get; set; }
    }
}