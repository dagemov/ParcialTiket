using System.ComponentModel.DataAnnotations;

namespace Tiket.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Range(1,1250)]
        public ICollection<Ticket> Ticket { get; set; }
    }
}
