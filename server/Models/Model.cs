﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
        public int CompantId { get; set; }
    }
}
