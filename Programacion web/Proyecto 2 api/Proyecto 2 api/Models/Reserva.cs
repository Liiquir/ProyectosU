using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_1.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroReserva { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public string NombreCliente { get; set; }
        public int NumeroPersonas { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
    }
}
