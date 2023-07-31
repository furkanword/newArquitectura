using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class PersonaProductoConfiguration : IEntityTypeConfiguration<PersonaProducto>
{
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        builder.ToTable("Producto");
        
        builder.Property(p => p.PersonaId)
        .HasColumnName("PersonaId");

        builder.Property(p => p.ProductoId)
        .HasColumnName("ProductoId");

        builder.HasOne(m => m.Producto)
        .WithMany(e => e.PersonaProductos)
        .HasForeignKey(m => m.ProductoId);

         builder.HasOne(m => m.Persona)
        .WithMany(e => e.personaProductos)
        .HasForeignKey(m => m.PersonaId);
  
    }
}