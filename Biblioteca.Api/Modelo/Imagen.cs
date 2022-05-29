using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Api.Modelo
{
    public class Imagen
    {
            [Key]
            public int IdImagen { get; set; }
            public string Nombre { get; set; }
            public string Fotografo { get; set; }
            public string Pais { get; set; }
            public int Fecha { get; set; }
            public string Descripcion { get; set; }
        
    }
}

