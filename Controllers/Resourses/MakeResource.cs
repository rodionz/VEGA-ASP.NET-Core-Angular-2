using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Controllers.Resourses
{
    public class MakeResource 
    {



        public int Id { get; set; }


        public string Name { get; set; }

        public ICollection<ModelResource> models { get; set; }

        public MakeResource()
        {
            models = new Collection<ModelResource>();
        }



    }
}
