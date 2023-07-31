using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
{
    public void Configure(EntityTypeBuilder<Provincia> builder)
    {
    
        builder.ToTable("Persona");
        builder.Property(p => p.Id_region)
        .HasColumnName("Id_region");
        
        builder.Property(p => p.Descripcion)
        .HasColumnName("Descripcion");

        builder.Property(p => p.Id_reg)
        .HasColumnName("Id_reg");

        builder.HasOne(m => m.Region)
        .WithMany(e => e.Provincias)
        .HasForeignKey(m => m.Id_region);

    }
}