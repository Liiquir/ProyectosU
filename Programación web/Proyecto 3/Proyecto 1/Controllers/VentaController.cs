using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Proyecto_1.Models;
using System.Reflection;
using System.Text;

namespace Proyecto_1.Controllers
{
    public class VentaController : Controller
    {
        private readonly HttpClient _client;

        public VentaController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7011/api");
        }

        [HttpGet]
        public IActionResult Index(int? searchNumeroOrden)
        {
            List<Venta> Ventas = new List<Venta>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Venta/GetVentas").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Ventas = JsonConvert.DeserializeObject<List<Venta>>(data);
            }

            // Verificar si se proporciona un valor de búsqueda de numeroOrden
            if (searchNumeroOrden.HasValue)
            {
                // Filtrar la lista de Ventas por numeroOrden
                Ventas = Ventas.Where(c => c.NumeroOrden == searchNumeroOrden.Value).ToList();
            }

            ViewBag.CurrentFilter = searchNumeroOrden; // Almacenar el valor de búsqueda en ViewBag
            return View(Ventas); // Renderizar la vista con la lista de Ventas filtrada
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Venta Venta)
        {
            if (!ModelState.IsValid)
            {
                return View(Venta);
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Venta/CrearVenta", Venta).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // Manejar el caso de error si la solicitud no es exitosa
               
                return View(Venta);
            }
        }

        [HttpPost]
        public IActionResult Delete(int numeroOrden)
        {
            if (numeroOrden == 1)
            {
                // No se permite eliminar el Venta administrador
                TempData["ErrorMessage"] = "No se puede eliminar esta venta.";
                return RedirectToAction("Index");
            }
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Venta/DeleteVenta/{numeroOrden}").Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Venta eliminada.";
                return RedirectToAction("Index");
            }
            else
            {
                // Manejar el caso de error si la solicitud no es exitosa
                
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int numeroOrden)
        {
            try
            {
                Venta venta = new Venta();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Venta/GetVenta/" + numeroOrden).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    venta = JsonConvert.DeserializeObject<Venta>(data);
                }
                return View(venta);
            }
            catch (Exception ex)
            {
                TempData[""] = ex.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Venta modelo)
        {
            try
            {
                string data = JsonConvert.SerializeObject(modelo);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Venta/UpdateVenta", content).Result;
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
