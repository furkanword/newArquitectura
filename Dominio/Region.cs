using System.ComponentModel.DataAnnotations;
namespace Dominio;

public class Region
{
    [Key]
    public int Id_region { get; set; }
    public string ? Descripcion { get; set; }
    public int Id_pais { get; set; }
    public Pais ? Pais { get; set; }
    public ICollection<Provincia> ? Provincias { get; set; }

}
