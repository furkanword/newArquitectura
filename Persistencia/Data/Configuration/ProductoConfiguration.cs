using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
    
        builder.ToTable("Persona");
        builder.Property(p => p.Id)
        .HasColumnName("Id_producto");
        
        builder.Property(p => p.Ref_producto)
        .HasColumnName("Referencia_producto");

        builder.Property(p => p.Descripcion_producto)
        .HasColumnName("Descripcion_producto");

        builder.Property(p => p.Precio_Producto)
        .HasColumnName("Precio_Producto"); 
        
        builder.Property(p => p.Dcto_producto)
        .HasColumnName("Dcto_producto");  

        builder.Property(p => p.MarcaId)
        .HasColumnName("MarcaId");    

        builder.HasOne(m => m.Marca)
        .WithMany(e => e.Productos)
        .HasForeignKey(m => m.MarcaId);

  
    }
}