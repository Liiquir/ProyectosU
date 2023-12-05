using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_1.Models
{
    public class Venta
    {
        [Key]       
        public int NumeroOrden { get; set; }
        public DateTime FechaHoraVenta { get; set; }
        public string NombrePlato { get; set; }
        public int CantidadVendida { get; set; }
    }
}
