using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Dentista);

            builder.HasOne(prop => prop.Paciente);

            builder.Property(prop => prop.Valor)
                .IsRequired();

            builder.Property(prop => prop.Data)
                .IsRequired();

            builder.Property(prop => prop.Descricao)
                .HasColumnType("varchar(100)");
        }
    }
}
