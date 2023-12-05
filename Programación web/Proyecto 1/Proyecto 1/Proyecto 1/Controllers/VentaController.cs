using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Proyecto_1.Models;

namespace Proyecto_1.Controllers
{
    public class VentaController : Controller
    {
        private readonly IMemoryCache _cache;

        public VentaController(IMemoryCache cache)
        {
            _cache = cache;
        }

        // Obtener todas las ventas realizadas
        public ActionResult Index(int? searchNumeroOrden)
        {
            // Obtener la lista de ventas desde el caché o crear una nueva lista vacía
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();

            // Filtrar las ventas por el número de orden si se proporciona un valor de búsqueda
            if (searchNumeroOrden.HasValue)
            {
                ventas = ventas.Where(v => v.NumeroOrden == searchNumeroOrden.Value).ToList();
            }

            // Establecer ViewBag.CurrentFilter con el valor de búsqueda actual para mantenerlo en la vista
            ViewBag.CurrentFilter = searchNumeroOrden;

            // Devolver la vista con la lista de ventas filtrada (si corresponde)
            return View(ventas);
        }


        // Mostrar formulario para crear una nueva venta
        public ActionResult Create()
        {
            return View();
        }

        // Agregar una nueva venta
        [HttpPost]
        public ActionResult Create(Venta venta)
        {
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();
            ventas.Add(venta);
            _cache.Set("Ventas", ventas);
            return RedirectToAction("Index");
        }

        // Mostrar formulario para editar una venta existente
        public ActionResult Edit(int id)
        {
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();
            Venta venta = ventas.FirstOrDefault(v => v.NumeroOrden == id);
            if (venta == null)
            {
                return NotFound();
            }
            return View(venta);
        }

        // Actualizar una venta existente
        [HttpPost]
        public ActionResult Edit(Venta venta)
        {
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();
            Venta ventaExistente = ventas.FirstOrDefault(v => v.NumeroOrden == venta.NumeroOrden);
            if (ventaExistente == null)
            {
                return NotFound();
            }
            ventaExistente.FechaHoraVenta = venta.FechaHoraVenta;
            ventaExistente.NombrePlato = venta.NombrePlato;
            ventaExistente.CantidadVendida = venta.CantidadVendida;
            _cache.Set("Ventas", ventas);
            return RedirectToAction("Index");
        }

        // Eliminar una venta
        public ActionResult Delete(int id)
        {
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();
            Venta venta = ventas.FirstOrDefault(v => v.NumeroOrden == id);
            if (venta == null)
            {
                return NotFound();
            }
            ventas.Remove(venta);
            _cache.Set("Ventas", ventas);
            return RedirectToAction("Index");
        }

        // Mostrar detalles de una venta
        public ActionResult Details(int id)
        {
            List<Venta> ventas = _cache.Get<List<Venta>>("Ventas") ?? new List<Venta>();
            Venta venta = ventas.FirstOrDefault(v => v.NumeroOrden == id);
            if (venta == null)
            {
                return NotFound();
            }
            return View(venta);
        }


    }


}
