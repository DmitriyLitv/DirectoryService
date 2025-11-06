namespace DirectoryService.Domain.DepartmentPositions
{
    public class DepartmentPosition
    {
        public Guid Id { get; } = Guid.NewGuid();

        public required Guid PositionId { get; init; }

        public required Guid DepartmentId { get; init; }

        public DepartmentPosition()// EF Core
        {
        }
    }
}
