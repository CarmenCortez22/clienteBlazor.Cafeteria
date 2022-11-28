using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecti_Cafeteria.ClientesBlazor.Models

{
    public class Producto
    {
             public int Id { get; set; }
             public int IdCategoria { get; set; }
             public string Nombre { get; set; }
             public decimal Precio { get; set; }
             public string Imagen { get; set; }
    }
    
}
