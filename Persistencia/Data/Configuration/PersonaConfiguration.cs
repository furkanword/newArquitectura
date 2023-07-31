using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.configurations ;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
    
        builder.ToTable("Persona");
        builder.Property(p => p.Id)
        .HasColumnName("Id_Persona");
        
        builder.Property(p => p.Nombre_persona)
        .HasColumnName("Nombre");

        builder.Property(p => p.ApellidoPersona)
        .HasColumnName("Apellido");

        builder.Property(p => p.Edad_persona)
        .HasColumnName("Edad"); 
        
        builder.Property(p => p.Id_provincia)
        .HasColumnName("Edad");  

        builder.Property(p => p.Id_TipoPersona)
        .HasColumnName("Id_TipoPersona"); 

        builder.HasOne(m => m.Provincia)
        .WithMany(e => e.Personas)
        .HasForeignKey(m => m.Id_provincia);  

        builder.HasOne(m => m.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(m => m.Id_TipoPersona);


    }
}