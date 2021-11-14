using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class UserInfoSignup : UserInfoLogin
    {
        public UserInfoSignup()
        {

        }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password Required!")]
        [DataType(DataType.Password)]
        [CompareAttribute("Password", ErrorMessage = "Password doesn't match!")]
        public string Confirm { get; set; }

        public void CleanSignupUser()
        {
            this.Username = "";
            this.Password = "";
            this.Confirm = "";
            this.ID = -1;
            this._id = "";
        }

    }
}
