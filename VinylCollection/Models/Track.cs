using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylCollection.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }

        [Required(ErrorMessage = "Podaj tytuł utworu")]
        [MaxLength(150)]
        public string Title { get; set; }

        // Numer na płycie, np. A1, B2
        [Column(TypeName = "varchar(5)")]
        public string? SideAndNumber { get; set; }

        // Długość utworu w sekundach
        public int? DurationSeconds { get; set; }

        // Klucz obcy do płyty (relacja 1:N)
        [ForeignKey("Vinyl")]
        public int VinylId { get; set; }
        public virtual Vinyl Vinyl { get; set; }
    }
}