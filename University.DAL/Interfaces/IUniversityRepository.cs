using BaseRepositories.EntityFrameworkCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using University.DAL.Models;

namespace Unians.University.DAL.Interfaces
{
    public interface IUniversityRepository : IEfRepository<UniversityDbModel>
    {

    }
}
