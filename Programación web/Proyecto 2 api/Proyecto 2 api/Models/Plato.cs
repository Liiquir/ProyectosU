using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_2_api.Models
{
    public class Plato
    {
        [Key]        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}
