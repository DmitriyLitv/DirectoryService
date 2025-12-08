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
            builder.Property(l => l.Name).HasColumnName("name").IsRequired();

            builder.OwnsOne(l => l.Name, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("name")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();

                nb.HasIndex(v => v.Value).IsUnique();
                nb.WithOwner();
            });

            builder.OwnsOne(l => l.Address, ab =>
            {
                ab.Property(a => a.Street).HasColumnName("address_street").HasMaxLength(200).IsRequired();
                ab.Property(a => a.City).HasColumnName("address_city").HasMaxLength(100).IsRequired();
                ab.Property(a => a.ZipCode).HasColumnName("address_zip").HasMaxLength(20).IsRequired();
                ab.WithOwner();
            });

            builder.Navigation(l => l.Name).IsRequired();

            builder.OwnsOne(l => l.TimeZone, nb =>
            {
                nb.Property(v => v.Value)
                  .HasColumnName("time_zone")
                  .HasMaxLength(Constants.Lengths500)
                  .IsRequired();
                nb.WithOwner();
            });

            builder.Navigation(l => l.Address).UsePropertyAccessMode(PropertyAccessMode.Field);

            builder.Navigation(l => l.DepartmentLocations).UsePropertyAccessMode(PropertyAccessMode.Field);

            builder.Navigation(l => l.TimeZone).IsRequired();
        }
    }
}
