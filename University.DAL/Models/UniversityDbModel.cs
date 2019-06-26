using BaseRepositories.EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.DAL.Models
{
    public class UniversityDbModel : BaseEntity
    {
        public string Name { get; set; }
    }
}
