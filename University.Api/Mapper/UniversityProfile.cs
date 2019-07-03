using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Api.Models;
using University.DAL.Models;

namespace University.Api.Mapper
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<ApiUniversity, DbUniversity>().ReverseMap();
        }
    }
}
