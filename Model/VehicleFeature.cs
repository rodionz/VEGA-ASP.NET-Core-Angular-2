using Angular_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Model
{

    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        public int VehicleID { get; set; }

        public int FeatureID { get; set; }

        public Vehicle Vehicle { get; set; }

        public Feature Feature { get; set; }
    }
}
