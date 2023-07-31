using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class Persona
{
    [Key]
    public int Id_persona {get; set; }
    public string ? Nombre_persona {get; set; }
    public string ? ApellidoPersona {get; set; }
    public int Edad_persona {get; set; }
    public int Id_provincia {get; set; }
    public Provincia ? Provincia {get; set; }
    public int Id_TipoPersona {get; set; }
    public TipoPersona ? TipoPersona {get; set; }
    public ICollection<PersonaProducto> ? personaProductos {get; set; }

}
