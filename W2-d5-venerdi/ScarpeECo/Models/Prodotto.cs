using System.ComponentModel.DataAnnotations;
/*classe principale del progetto
 
 Nome dell'articolo,
 Il prezzo, 
 Una descrizione dettagliata,
 Una immagine di copertina,
 Due immagini aggiuntive,
 */
namespace ScarpeCo.Models
{
    public class Product
    {
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [Range(0.01, 10000.00)]
        public decimal? Price { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? CoverImageUrl { get; set; }

        public string? ImageUrl1 { get; set; }

        public string? ImageUrl2 { get; set; }
    }
}
