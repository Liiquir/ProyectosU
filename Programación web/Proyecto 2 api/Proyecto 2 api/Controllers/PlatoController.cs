using Microsoft.AspNetCore.Mvc;
using Proyecto_2_api.Datos;
using Proyecto_2_api.Models;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_2_api.Controllers
{
 
        [Route("api/[controller]/[action]")]
        [ApiController]
        public class PlatoController : ControllerBase
        {


        
            private readonly ILogger<PlatoController> _logger;
        private readonly ApplicationDbContext _db;

            public PlatoController(ILogger<PlatoController> logger,ApplicationDbContext db)
            {
                _logger = logger;
                _db=db;
            }



            // Retorna un Plato específico por su ID
            [HttpGet("{id:int}", Name = "GetPlato")]
            [ProducesResponseType(200)]
            [ProducesResponseType(400)]
            [ProducesResponseType(404)]
            public ActionResult<Plato> GetPlato(int id)
            {

                // Verifica si el ID es válido
                if (id == 0)
                {
                    _logger.LogError("Error al traer el Plato con el id " + id);
                    return BadRequest();
                }

                // Busca el Plato en la lista de Platos almacenada
                //var Plato = PlatoStore.PlatoList.FirstOrDefault(c => c.Id == id);
                var plato= _db.Platos.FirstOrDefault(v=>v.Id == id);
                // Si no se encontró el Plato, retorna un código de estado 404 (No encontrado)
                if (plato == null)
                {
                    return NotFound();
                }

                // Retorna el Plato encontrado con un código de estado 200 (Éxito)
                return Ok(plato);
            }
            [HttpGet]
            [ProducesResponseType(200)]
            public ActionResult<IEnumerable<Plato>> GetPlatos()
            {
                return Ok(_db.Platos.ToList());
            }

            [HttpPost]
            [ProducesResponseType(201)]
            [ProducesResponseType(400)]
            [ProducesResponseType(404)]
            public ActionResult<Plato> CrearPlato([FromBody] Plato Platos)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            Plato modelo = new()
            {
                Id = Platos.Id,
                Nombre = Platos.Nombre,
                Descripcion = Platos.Descripcion,
                Imagen = Platos.Imagen,
                Precio = Platos.Precio,
                Categoria = Platos.Categoria,

            };
            _db.Platos.Add(modelo);
            _db.SaveChanges();


                return CreatedAtRoute("GetPlato", new { id = Platos.Id }, Platos);
            }
            [HttpDelete("{id:int}")]
            [ProducesResponseType(204)]
            [ProducesResponseType(400)]
            [ProducesResponseType(404)]
            public IActionResult DeletePlato(int id)
            {

                if (id == 0)
                {
                    return BadRequest();
                }
                var Plato = _db.Platos.FirstOrDefault(c => c.Id == id);
                if (Plato == null)
                {
                    return NotFound();
                }
                _db.Platos.Remove(Plato);
            _db.SaveChanges();
                return NoContent();
            }
            [HttpPut]
            [ProducesResponseType(204)]
            [ProducesResponseType(400)]
            public IActionResult UpdatePlato([FromBody] Plato Platos)
            {

                if (Platos == null || Platos.Id != Platos.Id)
                {
                    return BadRequest();
                }
            var plato = _db.Platos.Find(Platos.Id);
            
            plato.Nombre = Platos.Nombre;
            plato.Descripcion = Platos.Descripcion;
            plato.Imagen = Platos.Imagen;
            plato.Precio = Platos.Precio;
            plato.Categoria = Platos.Categoria;
            
            _db.SaveChanges();
            return NoContent();

            }

        }
    
}
