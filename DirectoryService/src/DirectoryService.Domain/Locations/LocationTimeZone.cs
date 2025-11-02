using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Shared;
using DirectoryService.Domain.Shared.StringValidators;

namespace DirectoryService.Domain.Locations
{
    public record LocationTimeZone : StringHolder, IStringValidatable
    {
        public LocationTimeZone(string value)
            : base(value)
        {
        }

        public static LocationTimeZone Create(string value)
        {
            var validator = CreateValidator();

            if (!validator.IsValid(value))
                return null; // TODO ResultPattern

            return new LocationTimeZone(value);
        }

        public static StringValidatorHandler CreateValidator()
        {
            var isEmptyString = new EmptyStringValidator();
            var isTimeZoneValid = new StringAsTimeZoneValidator();

            return new StringValidatorHandler(isEmptyString, isTimeZoneValid);
        }
    }
}
