using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Departments
{
    public class DepartmentIdentifier : StringHolder, IStringValidatable
    {
        private DepartmentIdentifier(string value)
            : base(value)
        {
        }

        public static DepartmentIdentifier Create(string value)
        {
            var validator = CreateValidator();

            if (!validator.IsValid(value))
                return null; // TODO ResultPattern

            return new DepartmentIdentifier(value);
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
