using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SPVTMaster.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Company Title")]
        
        public string Title { get; set; }

        [Display(Name = "Current Site")]
        public string SiteLocation { get; set; }

        [Display(Name = "Current Supervisor")]
        public string CurrentSupervisor { get; set; }

    }
}
