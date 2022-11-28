using System.Collections.Generic;
using System.Threading.Tasks;
using Proyecti_Cafeteria.ClientesBlazor.Models;

namespace Proyecti_Cafeteria.ClientesBlazor.Services
{
    public interface IProductosService
    {
        Task<IEnumerable<Producto>> GetAll();
        Task<IEnumerable<Producto>> GetByProducto(int idCategoria);
        Task<Producto> GetById(int id);
    }
}