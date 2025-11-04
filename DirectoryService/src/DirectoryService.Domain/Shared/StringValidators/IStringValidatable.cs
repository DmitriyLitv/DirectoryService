namespace DirectoryService.Domain.Shared.StringValidators
{
    internal interface IStringValidatable
    {
        abstract static StringValidatorHandler CreateValidator();
    }
}
