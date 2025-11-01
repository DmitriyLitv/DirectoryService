namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class StringValidatorHandler : IStringValidator
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

        public bool IsValid(string str)
        {
            bool result = true;

            foreach (var validator in _validators)
                result &= validator.IsValid(str);

            return result;
        }
    }
}
