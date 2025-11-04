using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class EmptyStringValidator : IStringValidator
    {
        public Error? IsValid(string str)
        {
            var isValid = string.IsNullOrWhiteSpace(str);
            return isValid
                    ? null
                    : GeneralErrors.ValueIsInvalid(str);
        }
    }
}
