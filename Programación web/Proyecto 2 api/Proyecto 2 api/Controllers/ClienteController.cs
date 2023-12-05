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
        private readonly ApplicationDbContext _db;
        public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        

        // Retorna un cliente específico por su ID
        [HttpGet("{id:int}",Name="GetCliente")]
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

            // Busca el cliente en la Base de datos
            var cliente = _db.Clientes.FirstOrDefault(c => c.ID == id);

            // Si no se encontró el cliente, retorna un código de estado 404 (No encontrado)
            if (cliente == null)
            {
                return NotFound();
            }

            // Retorna el cliente encontrado con un código de estado 200 (Éxito)
            return Ok(cliente);
        }
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(_db.Clientes.ToList());
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Cliente> CrearCliente([FromBody] Cliente clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Cliente modelo = new()
            {
                ID = clientes.ID,
                Nombre = clientes.Nombre,
                Apellido = clientes.Apellido,
                Email = clientes.Email,
                Telefono = clientes.Telefono,
                Direccion = clientes.Direccion,
                FechaNacimiento = clientes.FechaNacimiento,
                Genero = clientes.Genero,
                EsAdministrador = clientes.EsAdministrador,
                FechaRegistro = clientes.FechaRegistro,
            };
            _db.Clientes.Add(modelo);
            _db.SaveChanges();

            return CreatedAtRoute("GetCliente", new {id=clientes.ID},clientes);
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteCliente(int id)
        {
           
            if (id==0)
            {
                return BadRequest();
            }
            var cliente=_db.Clientes.FirstOrDefault(c => c.ID==id);
            if (cliente == null)
            {
                return NotFound();
            }
            _db.Clientes.Remove(cliente);
            return NoContent();
        }
        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]        
        public  IActionResult UpdateCliente([FromBody] Cliente clientes) 
        {

            if (clientes == null || clientes.ID != clientes.ID)
            {
                return BadRequest();
            }
            var cliente = _db.Clientes.Find(clientes.ID);

            cliente.Nombre=clientes.Nombre;
            cliente.Apellido=clientes.Apellido;
            cliente.Email=clientes.Email;
            cliente.Telefono=clientes.Telefono;
            cliente.Direccion=clientes.Direccion;
            cliente.FechaNacimiento=clientes.FechaNacimiento;
            cliente.Genero=clientes.Genero;
            cliente.EsAdministrador=clientes.EsAdministrador;
            cliente.FechaRegistro=clientes.FechaRegistro;

            _db.SaveChanges();
            return NoContent();

        }

    }

}
