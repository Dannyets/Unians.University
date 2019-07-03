using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace Unians.University.Data.Models
{
    public class DbUniversity : DbIdEntity
    {
        public string Name { get; set; }
    }
}
