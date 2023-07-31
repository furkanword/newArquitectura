using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marca");
        builder.Property(m => m.Id_marca)
        .HasColumnName("Id_marca");
        
        builder.Property(m => m.Descripcion_Marca)
        .HasColumnName("Descripcion_Marca");

      
    }
}