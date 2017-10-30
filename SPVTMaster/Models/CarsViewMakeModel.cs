using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SPVTMaster.Models
{
    public class CarsViewMakeModel
    {
        public List<Cars> cars;
        public SelectList Make;
        public string CarsMake { get; set; }

        public List<Cars> dateTime;
        public SelectList DateTime;
        


    }
}
