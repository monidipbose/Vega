using AutoMapper;
using server.Controllers.Resources;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}
