
using System.ComponentModel.DataAnnotations;
namespace Dominio;

public class PersonaProducto
{
    [Key]
    public int PersonaId { get; set; }
    public Persona ? Persona { get; set; }
    
    [Key]
    public int ProductoId { get; set; }
    public Producto ? Producto { get; set; }

    
}
