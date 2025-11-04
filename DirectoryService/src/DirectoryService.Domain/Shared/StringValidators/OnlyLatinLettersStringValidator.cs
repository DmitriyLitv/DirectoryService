using System.Text.RegularExpressions;
using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class OnlyLatinLettersStringValidator : IStringValidator
    {
        private readonly Regex _identifierRegex = new("^[a-zA-Z]+$", RegexOptions.Compiled);

        public Error? IsValid(string str)
        {
            var isValid = _identifierRegex.IsMatch(str);

            return isValid
                ? null
                : GeneralErrors.ValueIsInvalid(str);
        }
    }
}
