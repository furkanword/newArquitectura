using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
    
        builder.ToTable("Region");
        builder.Property(p => p.Id_TipoPersona)
        .HasColumnName("Id_TipoPersona");
        
        builder.Property(p => p.Descripcion)
        .HasColumnName("Descripcion");
   
    }
}