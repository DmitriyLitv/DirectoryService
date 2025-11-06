using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.Errors;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Positions
{
    public record PositionDescription : StringHolder, IStringValidatable
    {
        protected PositionDescription()// EF Core
        {
        }

        private PositionDescription(string value)
            : base(value)
        {
        }

        public static Result<PositionDescription, Error> Create(string value)
        {
            var error = ValidationResult(value);

            return error != null ? error : new PositionDescription(value);
        }

        private static Error? ValidationResult(string value)
        {
            var validator = CreateValidator();

            var result = validator?.IsValid(value);

            return result;
        }

        public static StringValidatorHandler CreateValidator()
        {
            int minLength = 0;
            int maxLength = 1000;

            var isEmptyString = new EmptyStringValidator();
            var lengthValidator = new LimitedLengthStringValidator(minLength, maxLength);

            return new StringValidatorHandler(isEmptyString, lengthValidator);
        }
    }
}
