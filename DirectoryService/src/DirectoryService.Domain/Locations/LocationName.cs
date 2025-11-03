using DirectoryService.Domain.Shared;
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

        public static LocationName Create(string value)
        {
            var validator = CreateValidator();

            if (!validator.IsValid(value))
                return null; // TODO ResultPattern

            return new LocationName(value);
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
