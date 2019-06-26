using BaseRepositories.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Unians.University.DAL.Interfaces;
using University.DAL;
using University.DAL.Models;

namespace Unians.University.DAL.Repositories
{
    public class UniversityRepository : BaseEntityFrameworkCoreRepository<UniversityDbModel>, IUniversityRepository
    {
        public UniversityRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}