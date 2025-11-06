using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.Errors;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Locations
{
    public record LocationTimeZone : StringHolder, IStringValidatable
    {
        protected LocationTimeZone() // EF Core
        {
        }

        public LocationTimeZone(string value)
            : base(value)
        {
        }

        public static Result<LocationTimeZone, Error> Create(string value)
        {
            var error = ValidationResult(value);

            return error != null ? error : new LocationTimeZone(value);
        }

        private static Error? ValidationResult(string value)
        {
            var validator = CreateValidator();

            var result = validator?.IsValid(value);

            return result;
        }

        public static StringValidatorHandler CreateValidator()
        {
            var isEmptyString = new EmptyStringValidator();
            var isTimeZoneValid = new StringAsTimeZoneValidator();

            return new StringValidatorHandler(isEmptyString, isTimeZoneValid);
        }
    }
}
