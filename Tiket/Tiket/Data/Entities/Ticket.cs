using System.ComponentModel.DataAnnotations;

namespace Tiket.Data.Entities
{
    public class Ticket
    {
        public int Id{ get; set; }

        public bool WasUsed { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public int document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string name { get; set; }

        public Entrance Entrances { get; set; }
        
        public DateTime DateTime { get; set; }
    }
}
