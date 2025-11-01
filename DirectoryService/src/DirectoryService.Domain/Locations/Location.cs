using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Locations
{
    public class Location
    {
        public Guid Id { get; private set; }

        public LocationName Name { get; private set; } = null!;

        public LocationAddress Address { get; private set; } = null!;

        public LocationTimeZone TimeZone { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
