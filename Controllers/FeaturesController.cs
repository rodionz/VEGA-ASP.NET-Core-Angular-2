
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Angular_2.Persitence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Angular_2.Model;
using Angular_2.Controllers.Resourses;

namespace Angular_2.Controllers
{
    public class FeaturesController : Controller
    {


        [HttpGetAttribute("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {


          var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }



        private readonly VegaDbContext context;

        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


    }
}