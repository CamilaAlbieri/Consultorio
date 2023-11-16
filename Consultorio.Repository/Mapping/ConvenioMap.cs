

using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consultorio.Repository.Mapping
{
    public class ConvenioMap : IEntityTypeConfiguration<Convenio>
    {
        public void Configure(EntityTypeBuilder<Convenio> builder)
        {
            builder.ToTable("Convenio");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasColumnType("varchar(100)");
        }
    }
}
