using Proyecti_Cafeteria.ClientesBlazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecti_Cafeteria.ClientesBlazor.Services
{
    public interface ICategoriasService
    {
        Task<IEnumerable<Categoria>> GetAll();
    }
}
