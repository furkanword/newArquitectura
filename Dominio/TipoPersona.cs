using System.ComponentModel.DataAnnotations;
namespace Dominio;

public class TipoPersona
{
    [Key]
    public int Id_TipoPersona { get; set; }
    public string ? Descripcion { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
    
}
