using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared
{
    internal abstract class DSPathBase : StringHolder
    {
        protected abstract char Separator { get; }

        protected DSPathBase(string value)
            : base(value)
        {
        }

        public DSPathBase CreateChild(string childValue)
        {
            var newValue = $"{Value}{Separator}{childValue}";

            return NewInstance(newValue);
        }

        public DSPathBase Create(string value)
        {
            return NewInstance(value);
        }

        public DSPathBase CreateParent(string parentValue)
        {
            return NewInstance(parentValue);
        }

        protected abstract DSPathBase NewInstance(string value);
    }
}
