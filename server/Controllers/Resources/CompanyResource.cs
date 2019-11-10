using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace server.Controllers.Resources
{
    public class CompanyResource
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }

        public CompanyResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}
