using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_2_api.Models;
using Proyecto_2_api.Datos;

namespace Proyecto_2_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        // Retorna una lista de clientes
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            _logger.LogInformation("Obtener los clientes");
            return Ok(ClientesStore.ClientesList);
        }

        // Retorna un cliente específico por su ID
        [HttpGet("{id:int}", Name = "GetCliente")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Cliente> GetCliente(int id)
        {
            // Verifica si el ID es válido
            if (id == 0)
            {
                _logger.LogError("Error al traer el cliente con el id " + id);
                return BadRequest();
            }

            // Busca el cliente en la lista de clientes almacenada
            var cliente = ClientesStore.ClientesList.FirstOrDefault(c => c.ID == id);

            // Si no se encontró el cliente, retorna un código de estado 404 (No encontrado)
            if (cliente == null)
            {
                return NotFound();
            }

            // Retorna el cliente encontrado con un código de estado 200 (Éxito)
            return Ok(cliente);
        }
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Cliente> CrearCliente([FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Verifica si el cliente es nulo
            if (cliente == null)
            {
                return BadRequest(cliente);
            }

            // Verifica si el ID del cliente es mayor que 0
            // Esto puede indicar un error, ya que normalmente se espera que el ID sea generado automáticamente
            if (cliente.ID > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            // Asigna un nuevo ID al cliente basado en el ID más alto existente en la lista de clientes almacenada
            cliente.ID = ClientesStore.ClientesList.OrderByDescending(c => c.ID).FirstOrDefault().ID + 1;

            // Agrega el cliente a la lista de clientes almacenada
            ClientesStore.ClientesList.Add(cliente);


            return CreatedAtRoute("GetCliente", new { id = cliente.ID }, cliente);
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteCliente(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var cliente = ClientesStore.ClientesList.FirstOrDefault(c => c.ID == id);
            if (cliente == null)
            {
                return NotFound();
            }
            ClientesStore.ClientesList.Remove(cliente);
            return NoContent();
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdateCliente(int id, [FromBody] Cliente cliente)
        {

            if (cliente == null || id != cliente.ID)
            {
                return BadRequest();
            }
            var clientes = ClientesStore.ClientesList.FirstOrDefault(c => c.ID == id);
            clientes.Nombre = cliente.Nombre;
            clientes.Apellido = cliente.Apellido;
            clientes.Email = cliente.Email;
            clientes.Telefono = cliente.Telefono;
            clientes.Direccion = cliente.Direccion;
            clientes.FechaNacimiento = cliente.FechaNacimiento;
            clientes.Genero = cliente.Genero;
            clientes.EsAdministrador = cliente.EsAdministrador;
            clientes.FechaRegistro = cliente.FechaRegistro;

            return NoContent();

        }

    }

}

