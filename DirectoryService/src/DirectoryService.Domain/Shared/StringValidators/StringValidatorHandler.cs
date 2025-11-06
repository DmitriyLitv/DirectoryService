using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    public class StringValidatorHandler : IStringValidator
    {
        private List<IStringValidator> _validators = new List<IStringValidator>();

        public StringValidatorHandler(params IStringValidator[] validators)
        {
            _validators.AddRange([.. validators]);
        }

        public StringValidatorHandler(List<IStringValidator> validators)
        {
            _validators.AddRange(validators);
        }

        public void AddValidator(IStringValidator validator)
        {
            _validators.Add(validator);
        }

        public Error? IsValid(string str)
        {
            foreach (var validator in _validators)
            {
                Error? validationResult = validator.IsValid(str);
                if (validationResult != null)
                    return validationResult;
            }

            return null;
        }
    }
}