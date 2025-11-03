using DirectoryService.Domain;
using DirectoryService.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("departments");

            builder.HasKey(d => d.Id).HasName("id");

            /*builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("name");*/

            builder.OwnsOne(d => d.Name, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("name");
            });

            builder.OwnsOne(d => d.Path, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("path");
            });

            builder.OwnsOne(d => d.Identifier, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("identifier");
            });

            builder.Navigation(d => d.Name).IsRequired();
        }
    }
}
