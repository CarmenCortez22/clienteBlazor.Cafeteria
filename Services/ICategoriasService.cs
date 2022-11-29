using Proyecto_Cafeteria.ClientesBlazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto_Cafeteria.ClientesBlazor.Services
{
    public interface ICategoriasService
    {
        Task<IEnumerable<Categoria>> GetAll();
    }
}
