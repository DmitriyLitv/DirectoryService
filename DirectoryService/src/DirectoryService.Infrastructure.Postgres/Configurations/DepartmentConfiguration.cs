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

            builder.HasKey(d => d.Id).HasName("pk_departments");

            builder.ComplexProperty(d => d.Name, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("name");
            });

            builder.Property(x => x.ParentId)
                .IsRequired(false)
                .HasColumnName("parent_id")
                .HasConversion(
                    value => value!.Value,
                    value => value);

            builder.Property(x => x.Depth)
                    .IsRequired()
                    .HasColumnName("depth");

            builder.ComplexProperty(d => d.Path, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("path");
            });

            builder.ComplexProperty(d => d.Identifier, nb =>
            {
                nb.Property(v => v.Value)
                .IsRequired()
                .HasMaxLength(Constants.Lengths500)
                .HasColumnName("identifier");
            });

            builder.Property(x => x.UpdatedAt)
                    .IsRequired()
                    .HasColumnName("updated_at");

            builder.HasMany(x => x.Locations)
                    .WithOne()
                    .HasForeignKey(x => x.Id);

            builder.HasMany(x => x.Positions)
                    .WithOne()
                    .HasForeignKey(x => x.Id);

            builder.Property(d => d.CreatedAt)
                .IsRequired()
                .HasColumnName("created_at");

            builder.Property(d => d.StateCode)
                    .IsRequired()
                    .HasColumnName("is_active");
        }
    }
}
