
using Microsoft.EntityFrameworkCore;
using Angular_2;
using Angular_2.Model;
using Vega.Model;

namespace Angular_2.Persitence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
          : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }

        
        public DbSet<Feature> Features { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuider) {

            modelBuider.Entity<VehicleFeature>().HasKey(vf => new { vf.FeatureID, vf.VehicleID });
            
        }
      
    }
}