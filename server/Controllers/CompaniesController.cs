using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Controllers.Resources;
using server.Models;
using server.Persistence;

namespace server.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly VegaDbContext context;
        private readonly IMapper _mapper;

        public CompaniesController(VegaDbContext dbContext, IMapper mapper)
        {
            context = dbContext;
            _mapper = mapper;
        }
        [HttpGet("/api/companies")]
        public async Task<IEnumerable<CompanyResource>> GetCompanies()
        {
            var companies= await context.Companies.Include(m => m.Models).ToListAsync();
            return _mapper.Map<List<Company>, List<CompanyResource>>(companies);
        }        
    }
}