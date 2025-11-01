namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class StringValidatorHandler : IStringValidatable
    {
        private List<IStringValidatable> _validators = new List<IStringValidatable>();

        public StringValidatorHandler(params IStringValidatable[] validators)
        {
            _validators.AddRange([.. validators]);
        }

        public StringValidatorHandler(List<IStringValidatable> validators)
        {
            _validators.AddRange(validators);
        }

        public void AddValidator(IStringValidatable validator)
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
