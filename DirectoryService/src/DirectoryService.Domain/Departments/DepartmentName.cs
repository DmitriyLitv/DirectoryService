using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.StringValidators;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DirectoryService.Domain.Departments
{
    internal class DepartmentName : StringHolder, IStringValidatable
    {
        private DepartmentName(string value)
            : base(value)
        {
        }

        public static DepartmentName Create(string value)
        {
            var validator = CreateValidator();

            if (!validator.IsValid(value))
                return null; // TODO ResultPattern

            return new DepartmentName(value);
        }

        public static StringValidatorHandler CreateValidator()
        {
            int minLength = 3;
            int maxLength = 150;

            var isEmptyString = new EmptyStringValidator();
            var lengthValidator = new LimitedLengthStringValidator(minLength, maxLength);

            return new StringValidatorHandler(isEmptyString, lengthValidator);
        }
    }
}
