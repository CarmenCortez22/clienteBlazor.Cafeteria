using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Proyecti_Cafeteria.ClientesBlazor.Models;


namespace Proyecti_Cafeteria.ClientesBlazor.Services
{
    public class ProductosService : IProductosService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ProductosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Producto>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, options);
        }

        public async Task<Producto> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Producto/{id}");
            return JsonSerializer.Deserialize<Producto>(resp, options);
        }

        public async Task<IEnumerable<Producto>> GetByProducto(int idCategoria)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Producto/Buscar", new { idCategoria = idCategoria });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(respString, options);
        }
    }
}

