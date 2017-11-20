using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SPVTMaster.Configuration
{
    
    public class UserRoleSeed
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRoleSeed(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void Seed()
        {
            if((await _roleManager.FindByNameAsync("Member")) == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
            }
        }
    }
}
