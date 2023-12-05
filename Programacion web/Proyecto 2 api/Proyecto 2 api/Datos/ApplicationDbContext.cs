using Microsoft.EntityFrameworkCore;
using Proyecto_1.Models;
using Proyecto_2_api.Models;

namespace Proyecto_2_api.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
           
        }
        public DbSet<Plato> Platos { get; set; }
       
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
