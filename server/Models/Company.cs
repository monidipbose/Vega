using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Company()
        {
            Models = new Collection<Model>();
        }
    }
}
