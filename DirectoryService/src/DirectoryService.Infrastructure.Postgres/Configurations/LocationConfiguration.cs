using DirectoryService.Domain;
using DirectoryService.Domain.Locations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("locations");

            builder.HasKey(l => l.Id).HasName("pk_locations");

            builder.Property(l => l.Id).HasColumnName("id").IsRequired();
            builder.Property(l => l.StateCode).HasColumnName("state").IsRequired();
            builder.Property(l => l.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(l => l.UpdatedAt).HasColumnName("updated_at").IsRequired();

           /* builder.OwnsOne(l => l.Name, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("name")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();
                nb.WithOwner();
            });*/
            builder.Navigation(l => l.Name).IsRequired();

            builder.OwnsOne(l => l.TimeZone, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("time_zone")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();
                nb.WithOwner();
            });
            builder.Navigation(l => l.TimeZone).IsRequired();
        }
    }
}
