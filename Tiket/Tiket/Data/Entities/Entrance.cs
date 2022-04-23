using System.ComponentModel.DataAnnotations;

namespace Tiket.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres")]
        public string Description { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
