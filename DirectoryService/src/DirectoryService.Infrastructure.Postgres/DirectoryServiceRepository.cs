using DirectoryService.Domain.Departments;
using Microsoft.EntityFrameworkCore;

namespace DirectoryService.Infrastructure.Postgres
{
    public class DirectoryServiceRepository
    {
        private DirectoryServiceDBContext _context;

        public DirectoryServiceRepository(DirectoryServiceDBContext context)
        {
            _context = context;
        }


    }
}
