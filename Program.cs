using Proyecto_Cafeteria.ClientesBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cafeteria.ClientesBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44334/api/") });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.cafeteriasv.somee.com/api/") });
            builder.Services.AddScoped<ICategoriasService, CategoriaService>();
            builder.Services.AddScoped<IProductosService, ProductosService>();

            builder.Services.AddMudServices(); //importación de los servicios de MudBlazor

            await builder.Build().RunAsync();
        }
    }
}

