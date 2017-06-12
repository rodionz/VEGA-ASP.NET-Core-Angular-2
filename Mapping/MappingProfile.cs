using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Controllers.Resourses;
using Vega.Model;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {


        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model.Model, ModelResource>();
        }
    }
}
