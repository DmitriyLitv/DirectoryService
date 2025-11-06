using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments
{
    public record DepartmentPath : DSPathBase
    {
        protected override char Separator => '.';

        protected DepartmentPath()// EF Core
        {
        }

        public DepartmentPath(string value)
            : base(value)
        {
        }

        protected override DSPathBase NewInstance(string value)
        {
            return new DepartmentPath(value);
        }
    }
}
