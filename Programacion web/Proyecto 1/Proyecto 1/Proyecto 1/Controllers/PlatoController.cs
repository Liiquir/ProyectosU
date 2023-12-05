using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Proyecto_1.Models;

namespace Proyecto_1.Controllers
{
    public class PlatoController : Controller
    {

        private readonly IMemoryCache _cache;

        // Constructor del controlador PlatoController que acepta una dependencia IMemoryCache como parámetro.
        public PlatoController(IMemoryCache cache)
        {
            _cache = cache; // Asignación del parámetro cache al campo _cache del controlador.
        }

        // Obtener todos los platos del menú        
        public ActionResult Index(int? searchId)
        {
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();

            // Verificar si se proporciona un valor de búsqueda de ID
            if (searchId.HasValue)
            {
                // Filtrar la lista de platos por ID
                platos = platos.Where(p => p.Id == searchId.Value).ToList();
            }

            ViewBag.CurrentFilter = searchId; // Almacenar el valor de búsqueda en ViewBag
            return View("Index", platos); // Renderizar la vista con la lista de platos filtrada
        }






        // Mostrar formulario para crear un nuevo plato
        public ActionResult Create()
        {
            return View();
        }

        // Agregar un nuevo plato al menú
        [HttpPost]
        public ActionResult Create(Plato plato)
        {
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();
            platos.Add(plato);
            _cache.Set("Platos", platos);
            return RedirectToAction("Index");
        }

        // Mostrar formulario para editar un plato existente
        public ActionResult Edit(int id)
        {
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();
            Plato plato = platos.FirstOrDefault(p => p.Id == id);
            if (plato == null)
            {
                return NotFound();
            }
            return View(plato);
        }

        // Actualizar un plato existente
        [HttpPost]
        public ActionResult Edit(Plato plato)
        {
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();

            // Buscar el plato existente en la lista de platos utilizando su ID
            Plato platoExistente = platos.FirstOrDefault(p => p.Id == plato.Id);

            // Verificar si el plato existente no se encontró
            if (platoExistente == null)
            {
                return NotFound(); // Devolver una respuesta NotFound si el plato no se encontró
            }

            // Actualizar los campos del plato existente con los valores proporcionados

            platoExistente.Nombre = plato.Nombre;
            platoExistente.Descripcion = plato.Descripcion;
            platoExistente.Imagen = plato.Imagen;
            platoExistente.Precio = plato.Precio;
            platoExistente.Categoria = plato.Categoria;

            _cache.Set("Platos", platos); // Actualizar la caché con la lista de platos modificada
            return RedirectToAction("Index"); // Redireccionar al método Index del controlador
        }


        // Eliminar un plato del menú
        public ActionResult Delete(int id)
        {
            // Obtener la lista de platos desde la memoria caché
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();

            // Buscar el plato por su ID
            Plato plato = platos.FirstOrDefault(p => p.Id == id);

            // Verificar si el plato existe
            if (plato == null)
            {
                // Devolver un resultado de "No encontrado" si el plato no existe
                return NotFound();
            }

            // Eliminar el plato de la lista

            platos.Remove(plato);

            // Actualizar la lista de platos en la memoria caché
            _cache.Set("Platos", platos);

            // Redirigir al método de acción "Index"
            return RedirectToAction("Index");
        }





        // Mostrar detalles de un plato
        public ActionResult Details(int id)
        {
            List<Plato> platos = _cache.Get<List<Plato>>("Platos") ?? new List<Plato>();
            Plato plato = platos.FirstOrDefault(p => p.Id == id);
            if (plato == null)
            {
                return NotFound();
            }
            return View(plato);
        }

    }



}
