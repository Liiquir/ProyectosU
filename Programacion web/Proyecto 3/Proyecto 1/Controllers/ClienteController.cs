using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto_1.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace Proyecto_1.Controllers
{
    public class ClienteController : Controller
    {
        private readonly HttpClient _client;

        public ClienteController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7011/api");
        }

        [HttpGet]
        public IActionResult Index(int? searchId)
        {
            List<Cliente> clientes = new List<Cliente>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/cliente/GetClientes").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            }

            // Verificar si se proporciona un valor de búsqueda de ID
            if (searchId.HasValue)
            {
                // Filtrar la lista de clientes por ID
                clientes = clientes.Where(c => c.ID == searchId.Value).ToList();
            }

            ViewBag.CurrentFilter = searchId; // Almacenar el valor de búsqueda en ViewBag
            return View(clientes); // Renderizar la vista con la lista de clientes filtrada
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/cliente/CrearCliente", cliente).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 1)
            {
                // No se permite eliminar el cliente administrador
                TempData["ErrorMessage"] = "No se puede eliminar al administrador.";
                return RedirectToAction("Index");
            }
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/cliente/DeleteCliente/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Cliente eliminado.";
                return RedirectToAction("Index");
            }
            else
            {               
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int ID)
        {
            try
            {
                Cliente cliente = new Cliente();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Cliente/GetCliente/" + ID).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<Cliente>(data);
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                TempData[""] = ex.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(Cliente modelo)
        {
            try
            {
                string data = JsonConvert.SerializeObject(modelo);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Cliente/UpdateCliente", content).Result;
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

