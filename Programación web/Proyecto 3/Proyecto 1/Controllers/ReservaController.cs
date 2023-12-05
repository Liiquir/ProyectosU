using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Proyecto_1.Models;
using System.Reflection;
using System.Text;

namespace Proyecto_1.Controllers
{
    public class ReservaController : Controller
    {
        private readonly HttpClient _client;
        public ReservaController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7011/api");
        }

        // Obtener todas las reservas
        public ActionResult Index(int? searchNumeroReserva)
        {
            // Obtener la lista de reservas desde el caché o crear una nueva lista vacía
            List<Reserva> reservas = new List<Reserva>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Reserva/GetReservas").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                reservas = JsonConvert.DeserializeObject<List<Reserva>>(data);
            }

            // Verificar si se proporciona un valor de búsqueda de Id
            if (searchNumeroReserva.HasValue)
            {
                // Filtrar la lista de reservas por Id
                reservas = reservas.Where(c => c.NumeroReserva == searchNumeroReserva.Value).ToList();
            }

            ViewBag.CurrentFilter = searchNumeroReserva; // Almacenar el valor de búsqueda en ViewBag
            return View(reservas); // Renderizar la vista con la lista de reservas filtrada
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Agregar una nueva reserva
        [HttpPost]
        public IActionResult Create(Reserva reserva)
        {
            if (!ModelState.IsValid)
            {
                return View(reserva);
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Reserva/CrearReserva/", reserva).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return View(reserva);
            }
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (Id == 1)
            {
                // No se permite eliminar La reserva 
                TempData["ErrorMessage"] = "No se puede eliminar este plato.";
                return RedirectToAction("Index");
            }
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Reserva/DeleteReserva/{Id}").Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Reserva eliminada.";
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int NumeroReserva)
        {
            try
            {
                Reserva reserva = new Reserva();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Reserva/GetReserva/"+NumeroReserva).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    reserva = JsonConvert.DeserializeObject<Reserva>(data);
                }
                return View(reserva);
            }
            catch (Exception ex)
            {
                TempData[""] = ex.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Reserva modelo)
        {
            try
            {
                string data = JsonConvert.SerializeObject(modelo);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Reserva/UpdateReserva", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

       
    }


}
