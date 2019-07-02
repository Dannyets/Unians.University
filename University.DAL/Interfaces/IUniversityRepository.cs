using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;
using University.DAL.Models;

namespace Unians.University.DAL.Interfaces
{
    public interface IUniversityRepository : IEfRepository<UniversityDbModel>
    {

    }
}
