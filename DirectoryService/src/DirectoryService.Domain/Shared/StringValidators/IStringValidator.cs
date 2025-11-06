using DirectoryService.Domain.Shared.Errors;

namespace DirectoryService.Domain.Shared.StringValidators
{
    public interface IStringValidator
    {
        Error? IsValid(string str);
    }
}
