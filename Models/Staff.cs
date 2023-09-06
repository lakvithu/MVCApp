using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Staff
    {
        [Required]
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
    }
}