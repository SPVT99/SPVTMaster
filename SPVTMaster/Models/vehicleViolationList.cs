using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPVTMaster.Models
{
    public class vehicleViolationList
    {
        public string VehicleViolation { set; get; }
        public List<SelectListItem> Violation { set; get; }
    }
}
