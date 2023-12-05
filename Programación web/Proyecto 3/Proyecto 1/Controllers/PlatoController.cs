using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Proyecto_1.Models;
using System.Text;

namespace Proyecto_1.Controllers
{
    public class PlatoController : Controller
    {
        private readonly HttpClient _client;

        public PlatoController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7011/api");
        }

        [HttpGet]
        public IActionResult Index(int? searchId)
        {
            List<Plato> Platos = new List<Plato>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Plato/GetPlatos").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Platos = JsonConvert.DeserializeObject<List<Plato>>(data);
            }

            // Verificar si se proporciona un valor de búsqueda de Id
            if (searchId.HasValue)
            {
                // Filtrar la lista de Platos por Id
                Platos = Platos.Where(c => c.Id == searchId.Value).ToList();
            }

            ViewBag.CurrentFilter = searchId; // Almacenar el valor de búsqueda en ViewBag
            return View(Platos); // Renderizar la vista con la lista de Platos filtrada
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Plato Plato)
        {
            if (!ModelState.IsValid)
            {
                return View(Plato);
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Plato/CrearPlato", Plato).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
               
                return View(Plato);
            }
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (Id == 1)
            {
                // No se permite eliminar el Plato 
                TempData["ErrorMessage"] = "No se puede eliminar este plato.";
                return RedirectToAction("Index");
            }
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Plato/DeletePlato/{Id}").Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Plato eliminado.";
                return RedirectToAction("Index");
            }
            else
            {
               
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id) 
        {
            try
            {
                Plato plato = new Plato();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Plato/GetPlato/"+Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    plato = JsonConvert.DeserializeObject<Plato>(data);
                }
                return View(plato);
            }
            catch (Exception ex)
            {
                TempData[""]= ex.Message;
                return View();
            }
           
        }
        [HttpPost]
        public IActionResult Edit(Plato modelo)
        {
            try
            {
                string data = JsonConvert.SerializeObject(modelo);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Plato/UpdatePlato", content).Result;
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

        public ActionResult Print()
        {
            return new Rotativa.AspNetCore.ViewAsPdf("Index");
        }
        


    }



}
