using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Proyecto_1.Models;

namespace Proyecto_1.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IMemoryCache _cache;
        Reserva reserva1 = new Reserva();
        public ReservaController(IMemoryCache cache)
        {
            _cache = cache;
        }

        // Obtener todas las reservas
        public ActionResult Index(int? searchNumeroReserva)
        {
            // Obtener la lista de reservas desde el caché o crear una nueva lista vacía
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();

            // Filtrar las reservas por el número de reserva si se proporciona un valor de búsqueda
            if (searchNumeroReserva.HasValue)
            {
                reservas = reservas.Where(r => r.NumeroReserva == searchNumeroReserva.Value).ToList();
            }

            // Establecer ViewBag.CurrentFilter con el valor de búsqueda actual para mantenerlo en la vista
            ViewBag.CurrentFilter = searchNumeroReserva;

            // Devolver la vista con la lista de reservas filtrada (si corresponde)
            return View(reservas);
        }



        // Mostrar formulario para crear una nueva reserva
        public ActionResult Create()
        {

            return View();
        }

        // Agregar una nueva reserva
        [HttpPost]
        public ActionResult Create(Reserva reserva)
        {
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();
            
            reservas.Add(reserva);
            _cache.Set("Reservas", reservas);
            return RedirectToAction("Index");
        }
        // Mostrar formulario para editar una venta existente
        public ActionResult Edit(int id)
        {
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();
            Reserva reservaExistente = reservas.FirstOrDefault(r => r.NumeroReserva == id);
            if (reservaExistente == null)
            {
                return NotFound();
            }
            return View(reservaExistente);
        }

        [HttpPost]
        public ActionResult Edit(Reserva reserva)
        {
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();
            Reserva reservaExistente = reservas.FirstOrDefault(r => r.NumeroReserva == reserva.NumeroReserva);
            if (reservaExistente == null)
            {
                return NotFound();
            }
            reservaExistente.NombreCliente = reserva.NombreCliente;
            reservaExistente.FechaHoraReserva = reserva.FechaHoraReserva;
            reservaExistente.NumeroPersonas = reserva.NumeroPersonas;
            _cache.Set("Reservas", reservas);
            return RedirectToAction("Index");
        }


        // Eliminar una reserva
        public ActionResult Delete(int id)
        {
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();
            Reserva reserva = reservas.FirstOrDefault(r => r.NumeroReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            reservas.Remove(reserva);
            _cache.Set("Reservas", reservas);
            return RedirectToAction("Index");
        }

        // Mostrar detalles de una reserva
        public ActionResult Details(int id)
        {
            List<Reserva> reservas = _cache.Get<List<Reserva>>("Reservas") ?? new List<Reserva>();
            Reserva reserva = reservas.FirstOrDefault(r => r.NumeroReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }
            return View(reserva);
        }
    }


}
