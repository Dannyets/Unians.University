using System.Threading.Tasks;
using AspNetCore.Infrastructure.Controllers;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Unians.University.Api.Data.Models;
using Unians.University.Data.Models;

namespace Unians.University.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : BaseEfCrudController<ApiUniversity, DbUniversity>
    {
        public UniversityController(IEfRepository<DbUniversity> repository,
                                    IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
