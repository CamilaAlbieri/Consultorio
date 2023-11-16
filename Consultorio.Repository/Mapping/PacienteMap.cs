using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Consultorio.Repository.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure (EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.Observacao)
               .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Convenio);

        }
    }
}
