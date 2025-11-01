namespace DirectoryService.Domain.Shared.StringValidators
{
    internal interface IStringValidatable
    {
        bool IsValid(string str);
    }
}
