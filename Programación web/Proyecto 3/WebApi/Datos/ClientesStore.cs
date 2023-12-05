using Proyecto_2_api.Models;

namespace Proyecto_2_api.Datos
{
    public static class ClientesStore
    {
        public static List<Cliente> ClientesList { get; set; } = new List<Cliente>
        {
            new Cliente{
                ID =1,
                Nombre = "Cristian",
                Apellido = "Monge",
                Email = "cjmongeuned",
                Telefono = "72263979",
                Direccion = "Senderos del rio",
                FechaNacimiento = DateTime.Now,
                Genero = "M",
                EsAdministrador = true,
                FechaRegistro = DateTime.Today},
            new Cliente{ ID =2,
                Nombre = "Cristian",
                Apellido = "Monge",
                Email = "cjmongeuned",
                Telefono = "72263979",
                Direccion = "Senderos del rio",
                FechaNacimiento = DateTime.Now,
                Genero = "M",
                EsAdministrador = true,
                FechaRegistro = DateTime.Today}
        };
    }
}
