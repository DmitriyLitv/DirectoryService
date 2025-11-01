using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Positions
{
    public class Position
    {
        public Guid Id { get; private set; }

        public PositionName Name { get; private set; } = null!;

        public PositionDescription Description { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public Position()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
