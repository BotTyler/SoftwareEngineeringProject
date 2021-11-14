using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class UserInfo
    {
        public UserInfo()
        {

        }

        [BindProperty]
        public int ID { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Username is Required!")]
        public string UName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password required!")]
        [DataType(DataType.Password)]
        public string PWord { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password Required!")]
        [DataType(DataType.Password)]
        [CompareAttribute("PWord", ErrorMessage = "Password doesn't match!")]
        public string Confirm { get; set; }
    }

}
