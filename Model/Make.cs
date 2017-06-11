using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Model
{
    public class Make
    {
        public int Id { get; set; }

        public string Mame { get; set; }

        public ICollection<Model> models { get; set; }

        public Make()
        {
            models = new Collection<Model>();
        }
    }
}
