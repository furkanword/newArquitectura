
using System.ComponentModel.DataAnnotations;
namespace Dominio;

public class Provincia
{
    [Key]
    public int Id_region { get; set; }
    public string ? Descripcion { get; set; }
    public int Id_reg { get; set; }
    public Region ? Region { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
    
}
