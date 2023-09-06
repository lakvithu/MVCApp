using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Company
    {
        [Required]
        public int CompanyRegisterId { get; set; }

        [StringLength(5)]
        public string CompanyFounder { get; set; }



    }
}