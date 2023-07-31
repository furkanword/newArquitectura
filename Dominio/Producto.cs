
using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Producto
    {
        [Key]
        public int Id_producto { get; set; }
        public string ? Ref_producto { get; set; }
        public string ? Descripcion_producto { get; set; }
        public double Precio_Producto { get; set; }
        public double Dcto_producto { get; set; }
        public int MarcaId { get; set; }
        public Marca ? Marca { get; set; }
        public ICollection<PersonaProducto> ? PersonaProductos { get; set; }
        
    }
}