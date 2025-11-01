namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class EmptyStringValidator : IStringValidatable
    {
        public bool IsValid(string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
