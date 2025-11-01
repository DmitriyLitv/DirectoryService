namespace DirectoryService.Domain.Shared.StringValidators
{
    internal class EmptyStringValidator : IStringValidator
    {
        public bool IsValid(string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
