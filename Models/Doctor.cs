using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Doctor
    {
        [Required (ErrorMessage = "Id can't be blank" )]
        public int DoctorId { get; set; }


        [StringLength(10)]
        public string DoctorName { get; set; }

        [RegularExpression(@"[6][0-9]{5}")]
        public string Pincode { get; set; }
    }
}