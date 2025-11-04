using DirectoryService.Domain.DepartmentLocations;
using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Locations
{
    public class Location
    {
        private LocationAddress _address = null!;

        private List<DepartmentLocation> _departmentLocations = [];

        public Guid Id { get; private set; }

        public LocationName Name { get; private set; } = null!;

        public LocationTimeZone TimeZone { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public LocationAddress Addresses => _address;

        public IReadOnlyList<DepartmentLocation> DepartmentLocations => _departmentLocations;

        public Location()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
