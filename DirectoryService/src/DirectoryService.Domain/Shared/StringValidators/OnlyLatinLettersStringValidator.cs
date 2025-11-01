using System.Text.RegularExpressions;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class OnlyLatinLettersStringValidator : IStringValidator
    {
        private readonly Regex _identifierRegex = new("^[a-zA-Z]+$", RegexOptions.Compiled);

        public bool IsValid(string str)
        {
           return _identifierRegex.IsMatch(str);
        }
    }
}
