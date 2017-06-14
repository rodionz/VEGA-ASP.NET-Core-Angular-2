using Angular_2.Controllers.Resourses;
using Angular_2.Model;
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
            CreateMap<Make, KeyValuePairResource>();
            CreateMap<Model.Model, KeyValuePairResource>();
            CreateMap<Feature, KeyValuePairResource>();
        }
    }
}
