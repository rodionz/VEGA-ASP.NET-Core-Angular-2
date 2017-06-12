
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_2.Persitence;
using Microsoft.AspNetCore.Mvc;
using Vega.Model;

namespace Angular_2.Controllers
{
    public class MakesController : Controller
    {


        [HttpGetAttribute("/api/makes")]
        public IEnumerable<Make> GetMakes()
        {



        }


        private readonly VegaDbContext context;

        public MakesController(VegaDbContext context)
        {
            this.context = context;

        }


    }
}