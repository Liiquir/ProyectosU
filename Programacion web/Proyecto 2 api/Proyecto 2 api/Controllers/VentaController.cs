using Microsoft.AspNetCore.Mvc;
using Proyecto_1.Models;
using Proyecto_2_api.Datos;
using Proyecto_2_api.Models;

namespace Proyecto_2_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly ILogger<VentaController> _logger;
        private readonly ApplicationDbContext _db;

        public VentaController(ILogger<VentaController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        [HttpGet("{numeroOrden:int}", Name = "GetVenta")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Venta> GetVenta(int numeroOrden)
        {

            // Verifica si el ID es válido
            if (numeroOrden == 0)
            {
                _logger.LogError("Error al traer el cliente con el id " + numeroOrden);
                return BadRequest();
            }

            // Busca el cliente en la lista de clientes almacenada
            var Venta = _db.Ventas.FirstOrDefault(c => c.NumeroOrden == numeroOrden);

            // Si no se encontró el cliente, retorna un código de estado 404 (No encontrado)
            if (Venta == null)
            {
                return NotFound();
            }

            // Retorna la venta encontrada con un código de estado 200 (Éxito)
            return Ok(Venta);
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Venta>> GetVentas()
        {
            return Ok(_db.Ventas.ToList());
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Venta> CrearVenta([FromBody] Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Venta modelo = new()
            {
                NumeroOrden = venta.NumeroOrden,
                FechaHoraVenta = venta.FechaHoraVenta,
                NombrePlato = venta.NombrePlato,
                CantidadVendida = venta.CantidadVendida,
            };
             _db.Ventas.Add(modelo);
            _db.SaveChanges();

            return CreatedAtRoute("GetVenta", new { numeroOrden = venta.NumeroOrden }, venta);
        }
        [HttpDelete("{numeroOrden:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteVenta(int numeroOrden)
        {

            if (numeroOrden == 0)
            {
                return BadRequest();
            }
            var venta = _db.Ventas.FirstOrDefault(c => c.NumeroOrden == numeroOrden);
            if (venta == null)
            {
                return NotFound();
            }
            _db.Ventas.Remove(venta);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdateVenta([FromBody] Venta ventas)
        {

            if (ventas == null || ventas.NumeroOrden != ventas.NumeroOrden)
            {
                return BadRequest();
            }
            var venta = _db.Ventas.Find(ventas.NumeroOrden);

            venta.FechaHoraVenta = ventas.FechaHoraVenta;
            venta.NombrePlato = ventas.NombrePlato;
            venta.CantidadVendida = ventas.CantidadVendida;


            _db.SaveChanges();
            return NoContent();

        }
    }
}
