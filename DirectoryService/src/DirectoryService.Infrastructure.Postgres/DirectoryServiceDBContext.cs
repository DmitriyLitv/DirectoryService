using DirectoryService.Domain.DepartmentLocations;
using DirectoryService.Domain.DepartmentPositions;
using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Locations;
using DirectoryService.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DirectoryService.Infrastructure.Postgres
{
    public class DirectoryServiceDBContext : DbContext
    {
        private string _connectionString;

        public DbSet<Department> Departments => Set<Department>();

        public DbSet<Location> Locations => Set<Location>();

        public DbSet<Position> Positions => Set<Position>();

        public DbSet<DepartmentPosition> DepartmentPosition => Set<DepartmentPosition>();

        public DbSet<DepartmentLocation> DepartmentLocation => Set<DepartmentLocation>();

        public DirectoryServiceDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DirectoryServiceDBContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql(_connectionString);
        }
    }
}
