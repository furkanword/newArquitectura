using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class PaisController : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais");
        builder.Property(c => c.Id_pais)
        .HasColumnName("Id_Pais");
        
        builder.Property(c => c.Nombre_pais)
        .HasColumnName("Nombre_pais");
    
        
        

    }
}