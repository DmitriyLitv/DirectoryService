using DirectoryService.Domain.DepartmentLocations;
using DirectoryService.Domain.DepartmentPositions;
using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments
{
    public class Department
    {
        private List<DepartmentLocation> _locations = [];

        private List<DepartmentPosition> _positions = [];

        public Guid Id { get; private set; }

        public DepartmentName Name { get; private set; } = null!;

        public DepartmentIdentifier Identifier { get; private set; } = null!;

        public Guid? ParentId { get; private set; }

        public short Depth { get; private set; } = 0;

        public DepartmentPath Path { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyList<DepartmentLocation> Locations => _locations;

        public IReadOnlyList<DepartmentPosition> Positions => _positions;

        public Department()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
