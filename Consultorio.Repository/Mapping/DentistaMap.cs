using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository.Mapping
{
    public class DentistaMap : IEntityTypeConfiguration<Dentista>
    {
        public void Configure(EntityTypeBuilder<Dentista> builder)
        {
            builder.ToTable("Dentista");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.Property(prop => prop.CPF)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.HasMany(prop => prop.Especialidades);
            
        }

        public class DentistaEspecialidadeMap : IEntityTypeConfiguration<DentistaEspecialidade>
        {
            public void Configure(EntityTypeBuilder<DentistaEspecialidade> builder)
            {
                builder.ToTable("DentistaEspecialidade");

                builder.HasKey(prop => prop.Id);

                builder.HasOne(prop => prop.Dentista);

                builder.HasOne(prop => prop.Especialidade);
            }
        }



    }
}
