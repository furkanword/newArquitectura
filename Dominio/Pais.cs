using System.ComponentModel.DataAnnotations;
namespace Dominio;

public class Pais
{
    [Key]
    public int Id_pais { get; set; }
    public string ? Nombre_pais { get; set; }

    public ICollection<Region> ? regiones { get; set;}
    
}
