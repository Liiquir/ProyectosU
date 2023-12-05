using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Proyecto_1.Models
{
    public class Plato
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}
