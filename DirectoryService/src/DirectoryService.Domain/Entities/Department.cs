using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Entities
{
    internal class Department
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Identifier { get; set; }

        public Guid? ParentId { get; set; }

        public string Path { get; set; }

        public short Depth { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
