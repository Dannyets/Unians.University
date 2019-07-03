using System.Threading.Tasks;
using AspNetCore.Infrastructure.Controllers;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using University.Api.Models;
using University.DAL.Models;

namespace University.Api.Controllers
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
