using DirectoryService.Domain;
using DirectoryService.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations
{
    internal class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("positions");

            builder.HasKey(p => p.Id).HasName("id");

            builder.OwnsOne(p => p.Description, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("description");
            });

            builder.OwnsOne(p => p.Name, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("description");
            });
        }
    }
}
