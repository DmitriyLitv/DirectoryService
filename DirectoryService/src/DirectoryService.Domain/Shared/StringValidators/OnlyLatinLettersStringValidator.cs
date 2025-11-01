using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class OnlyLatinLettersStringValidator : IStringValidatable
    {
        private readonly Regex _identifierRegex = new("^[a-zA-Z]+$", RegexOptions.Compiled);

        public bool IsValid(string str)
        {
           return _identifierRegex.IsMatch(str);
        }
    }
}
