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

            builder.HasKey(l => l.Id).HasName("id");

            builder.OwnsOne(l => l.Name, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("name");
            });

            builder.OwnsOne(l => l.TimeZone, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("time_zone");
            });

            builder.Navigation(l => l.Name).IsRequired();
        }
    }
}
