using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Infrastructure.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Unians.University.DAL.Interfaces;
using University.Api.Models;
using University.DAL.Models;

namespace University.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : BaseEfCrudController<UniversityApiModel, UniversityDbModel>
    {
        private readonly IUniversityRepository _repository;

        public UniversityController(IUniversityRepository repository,
                                    IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
