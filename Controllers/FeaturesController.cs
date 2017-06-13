using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBasic.Persitence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



using WebApplicationBasic.Controllers.Resourses;
using WebApplicationBasic.Core.Models;
using WebApplicationBasic.Persistence;



using AutoMapper;

namespace WebApplicationBasic.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly VegaDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(VegaDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features); 
    }
  }
}