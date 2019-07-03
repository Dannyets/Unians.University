using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace University.DAL.Models
{
    public class DbUniversity : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
