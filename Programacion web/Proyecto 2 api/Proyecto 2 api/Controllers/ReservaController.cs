using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_2_api.Models;
using Proyecto_2_api.Datos;
using Proyecto_1.Models;

namespace Proyecto_2_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly ILogger<ReservaController> _logger;
        private readonly ApplicationDbContext _db;
        public ReservaController(ILogger<ReservaController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }



        // Retorna un cliente específico por su ID
        [HttpGet("{NumeroReserva:int}", Name = "GetReserva")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Reserva> GetReserva(int NumeroReserva)
        {

            // Verifica si el ID es válido
            if (NumeroReserva == 0)
            {
                _logger.LogError("Error al traer el cliente con el id " + NumeroReserva);
                return BadRequest();
            }

            // Buscar la reserva en la Base de datos
            var reserva = _db.Reservas.FirstOrDefault(c => c.NumeroReserva == NumeroReserva);

            // Si no se encontró el cliente, retorna un código de estado 404 (No encontrado)
            if (reserva == null)
            {
                return NotFound();
            }

            // Retorna La reserva encontrado con un código de estado 200 (Éxito)
            return Ok(reserva);
        }
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Reserva>> GetReservas()
        {
            return Ok(_db.Reservas.ToList());
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Reserva> CrearReserva([FromBody] Reserva reserva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Reserva modelo = new()
            {
                NumeroReserva = reserva.NumeroReserva,
                FechaHoraReserva = reserva.FechaHoraReserva,
                NombreCliente = reserva.NombreCliente,
                NumeroPersonas = reserva.NumeroPersonas,
                FechaHoraCreacion = reserva.FechaHoraCreacion,
            };
            _db.Reservas.Add(modelo);
            _db.SaveChanges();

            return CreatedAtRoute("GetReserva", new { id = reserva.NumeroReserva }, reserva);
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteReserva(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }
            var reserva = _db.Reservas.FirstOrDefault(r => r.NumeroReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }
            _db.Reservas.Remove(reserva);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdateReserva([FromBody] Reserva reservas)
        {

            if (reservas == null || reservas.NumeroReserva != reservas.NumeroReserva)
            {
                return BadRequest();
            }
            var reserva = _db.Reservas.Find(reservas.NumeroReserva);

            reserva.FechaHoraReserva=reservas.FechaHoraReserva;
            reserva.NombreCliente = reservas.NombreCliente;
            reserva.NumeroReserva = reservas.NumeroReserva;
            reserva.FechaHoraCreacion = reservas.FechaHoraCreacion;

            _db.SaveChanges();
            return NoContent();

        }

    }

}
