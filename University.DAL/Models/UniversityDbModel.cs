using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;

namespace University.DAL.Models
{
    public class UniversityDbModel : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
