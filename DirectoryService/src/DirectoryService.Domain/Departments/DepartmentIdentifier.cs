using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Departments
{
    internal class DepartmentIdentifier : StringHolder, IStringValidatable
    {
        public DepartmentIdentifier(string value)
            : base(value)
        {
        }

        public static StringValidatorHandler CreateValidator()
        {
            int minLength = 3;
            int maxLength = 150;

            var isEmptyString = new EmptyStringValidator();
            var lengthValidator = new LimitedLengthStringValidator(minLength, maxLength);
            var onlyLatinLetters = new OnlyLatinLettersStringValidator();

            return new StringValidatorHandler(isEmptyString, lengthValidator, onlyLatinLetters);
        }
    }
}
