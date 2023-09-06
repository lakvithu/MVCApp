using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Models
{
    public class AssignRole
    {
        [Required(ErrorMessage = " Select proper UserRole Name")]
        public string UserRoleName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Select UserName")]
        public string UserID
        {
            get;
            set;
        }
        public List<SelectListItem> Userlist
        {
            get;
            set;
        }
        public List<SelectListItem> UserRolesList
        {
            get;
            set;
        }
    }
}