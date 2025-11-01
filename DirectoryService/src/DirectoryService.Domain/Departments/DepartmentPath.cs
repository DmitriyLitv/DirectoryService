using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments
{
    public class DepartmentPath : DSPathBase
    {
        protected override char Separator => '.';

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
