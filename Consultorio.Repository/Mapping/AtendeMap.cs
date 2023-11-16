using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository.Mapping
{
    public class AtendeMap : IEntityTypeConfiguration<Atende>
    {
        public void Configure(EntityTypeBuilder<Atende> builder)
        {
            builder.ToTable("Atende");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Dentista);

            builder.HasOne(prop => prop.Convenio);
        }
    }
}
