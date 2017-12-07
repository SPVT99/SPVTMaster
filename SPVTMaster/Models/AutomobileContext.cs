using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPVTMaster.Models;

namespace SPVTMaster.Models
{
    public class AutomobileContext : DbContext
    {
        public AutomobileContext(DbContextOptions<AutomobileContext> options) : base(options)
        {

        }

        public DbSet<Cars> Cars { get; set; }

        //public DbSet<SPVTMaster.Models.ApplicationUser> ApplicationUser { get; set; }

        //public DbSet<Category> Category { get; set; }

        //public DbSet<SPVTMaster.Models.VehicleViolationList> VehicleViolationList { get; set; }

        
    }
}
