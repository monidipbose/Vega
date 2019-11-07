using Microsoft.EntityFrameworkCore;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Persistence
{
    public class VegaDbContext:DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options): base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
    }
}
