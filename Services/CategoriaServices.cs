using Proyecti_Cafeteria.ClientesBlazor.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecti_Cafeteria.ClientesBlazor.Services
{
    public class CategoriaService : ICategoriasService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public CategoriaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, options);
        }
    }
}

