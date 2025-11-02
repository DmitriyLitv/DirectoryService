using DirectoryService.Domain.DepartmentLocations;
using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Shared;
using System.Net;

namespace DirectoryService.Domain.Locations
{
    public class Location
    {
        private List<LocationAddress> _addresses = [];

        private List<DepartmentLocation> _departmentLocations = [];

        public Guid Id { get; private set; }

        public LocationName Name { get; private set; } = null!;

        public LocationTimeZone TimeZone { get; private set; } = null!;

        public int StateCode { get; private set; } = (int)RecordStateCode.IsActive;

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public IReadOnlyList<LocationAddress> Addresses => _addresses;

        public IReadOnlyList<DepartmentLocation> DepartmentLocations => _departmentLocations;

        public Location()
        {
            Id = Guid.NewGuid();

            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
    }
}
