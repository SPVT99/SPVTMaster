using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SPVTMaster.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
