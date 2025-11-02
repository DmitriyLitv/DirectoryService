using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared
{
    public enum RecordStateCode
    {
        IsActive = 0,
        IsDeactivated = 1,
        IsDeleted = 2,
    }
}
