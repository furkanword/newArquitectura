using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
    
        builder.ToTable("Region");
        builder.Property(p => p.Id_region)
        .HasColumnName("Id_region");
        
        builder.Property(p => p.Descripcion)
        .HasColumnName("Descripcion");

        builder.Property(p => p.Id_pais)
        .HasColumnName("Id_pais");

        builder.HasOne(m => m.Pais)
        .WithMany(e => e.regiones)
        .HasForeignKey(m => m.Id_pais);
    }
}