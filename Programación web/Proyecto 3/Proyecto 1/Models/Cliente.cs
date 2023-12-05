using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_1.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public bool EsAdministrador { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
