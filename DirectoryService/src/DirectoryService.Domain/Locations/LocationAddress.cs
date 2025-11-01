using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Locations
{
    public class LocationAddress
    {
        public string ZipCode { get; } = null!;

        public string Country { get; } = null!;

        public string City { get; } = null!;

        public string Street { get; } = null!;

        public string HouseNumber { get; } = null!;

        public string? Number { get; }
    }
}
