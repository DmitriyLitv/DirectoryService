using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class StringAsTimeZoneValidator : IStringValidator
    {
        public bool IsValid(string str)
        {
            return TimeZoneInfo.TryFindSystemTimeZoneById(str, out _);
        }
    }
}
