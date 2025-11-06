using DirectoryService.Domain;
using DirectoryService.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("positions");

            builder.HasKey(p => p.Id).HasName("pk_positions");

            builder.Property(p => p.Id).HasColumnName("id").IsRequired();
            builder.Property(p => p.StateCode).HasColumnName("state").IsRequired();
            builder.Property(p => p.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(p => p.UpdatedAt).HasColumnName("updated_at").IsRequired();

            builder.OwnsOne(p => p.Name, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("name")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();

                nb.HasIndex(v => v.Value).IsUnique();
                nb.WithOwner();
            });
            builder.Navigation(p => p.Name).IsRequired();

            builder.OwnsOne(p => p.Description, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("description")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();

                nb.WithOwner();
            });

            builder.Navigation(p => p.Description).IsRequired();
        }
    }
}
