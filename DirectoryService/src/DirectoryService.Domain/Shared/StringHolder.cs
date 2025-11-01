using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared
{
    public class StringHolder
    {
        public string Value { get; }

        public StringHolder(string value)
        {
            Value = value;
        }
    }
}
