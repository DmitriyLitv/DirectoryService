using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class StringAsTimeZoneValidator : IStringValidator
    {
        public Error? IsValid(string str)
        {
            var isValid = TimeZoneInfo.TryFindSystemTimeZoneById(str, out _);

            return isValid
                ? null
                : GeneralErrors.ValueIsInvalid(str);
        }
    }
}
