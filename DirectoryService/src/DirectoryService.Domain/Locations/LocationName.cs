using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.Errors;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Locations
{
    public record LocationName : StringHolder, IStringValidatable
    {
        protected LocationName() // EF Core
        {
        }

        private LocationName(string value)
            : base(value)
        {
        }

        public static Result<LocationName, Error> Create(string value)
        {
            var error = ValidationResult(value);

            return error != null ? error : new LocationName(value);
        }

        private static Error? ValidationResult(string value)
        {
            var validator = CreateValidator();

            var result = validator?.IsValid(value);

            return result;
        }

        public static StringValidatorHandler CreateValidator()
        {
            int minLength = 3;
            int maxLength = 120;

            var isEmptyString = new EmptyStringValidator();
            var lengthValidator = new LimitedLengthStringValidator(minLength, maxLength);

            return new StringValidatorHandler(isEmptyString, lengthValidator);
        }
    }
}
