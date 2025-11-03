namespace DirectoryService.Domain.DepartmentLocations
{
    public class DepartmentLocation
    {
        public Guid Id { get; } = Guid.NewGuid();

        public required Guid LocationId { get; init; }

        public required Guid DepartmentId { get; init; }

        public DepartmentLocation() // EF Core
        {
        }
    }
}
