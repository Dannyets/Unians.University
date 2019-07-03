using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unians.University.Data.Models;
using Unians.University.Api.Data.Models;

namespace Unians.University.Api.Mapper
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<ApiUniversity, DbUniversity>().ReverseMap();
        }
    }
}
