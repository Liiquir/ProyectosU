namespace Proyecto_1.Models
{
    public class Reserva
    {
        public int NumeroReserva { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public string NombreCliente { get; set; }
        public int NumeroPersonas { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
    }
}
