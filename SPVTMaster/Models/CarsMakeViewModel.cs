using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPVTMaster.Models
{
    public class CarsMakeViewModel
    {
        public List<Cars> cars;
        public SelectList Make;
        public string carsMake { get; set; }

        public List<Cars> dateTime;
        public SelectList DateTime;
    }
}
