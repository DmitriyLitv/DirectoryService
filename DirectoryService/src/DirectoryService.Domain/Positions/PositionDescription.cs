using DirectoryService.Domain.Shared;
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

        public static PositionDescription Create(string value)
        {
            var validator = CreateValidator();

            if (!validator.IsValid(value))
                return null; // TODO ResultPattern

            return new PositionDescription(value);
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
