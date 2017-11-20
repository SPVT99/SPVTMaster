using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPVTMaster.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SPVTMaster.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public UserManagementController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        // GET: /<controller>/
        public IActionResult Index()
        {
            var users = _dbContext.Users.ToList();
            return View();
        }
    }
}
