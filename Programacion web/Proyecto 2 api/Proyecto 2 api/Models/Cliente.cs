using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_2_api.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
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
