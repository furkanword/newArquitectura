

using System.ComponentModel.DataAnnotations;

namespace Dominio;

public class Marca
{
    [Key]
    public int Id_marca { get; set; }
    public string ? Descripcion_Marca { get; set; }
    public ICollection<Producto>? Productos { get; set; }
}
