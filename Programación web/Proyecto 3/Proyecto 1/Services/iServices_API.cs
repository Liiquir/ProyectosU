using Proyecto_1.Models;
namespace Proyecto_1.Services
{
    public interface iServices_API
    {
        Task<List<Cliente>> GetClientes();
       
    }
}
