using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPVTMaster.Models
{
    public class CarsModelViewModel
    {
        public List<Cars> cars;
        public SelectList Model;
        public string carsModel { get; set; }
    }
}
