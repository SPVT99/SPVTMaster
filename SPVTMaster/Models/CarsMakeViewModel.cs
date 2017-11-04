using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPVTMaster.Models
{
    public class CarsMakeViewModel
    {
        public List<Cars> cars;
        public SelectList Make;
        public string carsMake { get; set; }

        //[Display(Name = "Notes")]
        //public string Discription { get; set; }
    }
}
