using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SPVTMaster.Models
{
    public class AutomobileContext : DbContext
    {
        public AutomobileContext(DbContextOptions<AutomobileContext> options) : base(options)
        {

        }

        public DbSet<Cars> Cars { get; set; }
    }
}
