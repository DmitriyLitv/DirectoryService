using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments
{
    internal class Department
    {
        public Guid Id { get; private set; }

        public DepartmentName Name { get; private set; } = null!;

        public DepartmentIdentifier Identifier { get; private set; } = null!;

        public Guid? ParentId { get; private set; }

        public short Depth { get; private set; } = 0;

        public DepartmentPath Path { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public Department()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
