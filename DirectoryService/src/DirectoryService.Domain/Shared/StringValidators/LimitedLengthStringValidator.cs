using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class LimitedLengthStringValidator : IStringValidatable
    {
        internal int _minLength = 1;

        internal int _maxLength = 1;

        internal LimitedLengthStringValidator(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public bool IsValid(string str)
        {
            return str.Length < _minLength || str.Length > _maxLength;
        }
    }
}
