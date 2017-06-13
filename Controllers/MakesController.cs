
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_2.Persitence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;

using WebApplicationBasic.Controllers.Resourses;
using WebApplicationBasic.Model;

namespace Angular_2.Controllers
{
    public class MakesController : Controller
    {


        [HttpGetAttribute("/api/makes")]
        public IEnumerable<MakeResource> GetMakes()
        {


          var makes = context.Makes.Include(m => m.models).ToList();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }



        private readonly VegaDbContext context;

        private readonly IMapper mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


    }
}