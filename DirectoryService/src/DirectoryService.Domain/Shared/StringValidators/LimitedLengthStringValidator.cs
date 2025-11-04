using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class LimitedLengthStringValidator : IStringValidator
    {
        internal int _minLength = 1;

        internal int _maxLength = 1;

        internal LimitedLengthStringValidator(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public Error? IsValid(string str)
        {
            var isValid = str.Length < _minLength || str.Length > _maxLength;

            return isValid
                ? null
                : GeneralErrors.ValueIsInvalid(str);
        }
    }
}
