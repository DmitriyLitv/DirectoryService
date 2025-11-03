using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared
{
    public record StringHolder
    {
        public string Value { get; }

        protected StringHolder()
        {
            // EF Core
            Value = string.Empty;
        }

        public StringHolder(string value)
        {
            Value = value;
        }
    }
}
