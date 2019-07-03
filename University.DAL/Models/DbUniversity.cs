using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace University.DAL.Models
{
    public class DbUniversity : DbIdEntity
    {
        public string Name { get; set; }
    }
}
