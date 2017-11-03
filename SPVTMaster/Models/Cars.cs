using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SPVTMaster.Models
{
    public class Cars
    {
        public int Id { get; set; }

        public DateTime DateTimeStamp { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Make { get; set; }


        //[StringLength(60, MinimumLength = 3)]
        [Required]
        public string Model { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }

        [Display(Name = " License Plate")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string licensePlate { get; set; }

        //[Display(Name = "Date Time")]
        //[DataType(DataType.DateTime)]
        //public DateTime DateTime { get; set; }


    }
}
