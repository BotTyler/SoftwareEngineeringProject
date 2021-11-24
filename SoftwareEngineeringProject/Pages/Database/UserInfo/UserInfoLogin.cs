using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class UserInfoLogin
    {
        public UserInfoLogin()
        {

        }

        [BindProperty]
        public string _id { get; set; } // used as an identified for the update method

        [BindProperty]
        [Required(ErrorMessage = "Username is Required!")]
        [RegularExpression(@"[a-zA-Z0-9!@]*", ErrorMessage = "Please only use characters \'a-z, A-Z, 0-9, !, and @\'")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password required!")]
        [RegularExpression(@"[a-zA-Z0-9!@]*", ErrorMessage = "Please only use characters \'a-z, A-Z, 0-9, !, and @\'")]
        [DataType(DataType.Password)]
        //[JsonProperty("Password")]
        public string Password { get; set; }

        public void cleanLoginUser()
        {
            this._id = "";
            this.Username = "";
            this.Password = "";
        }
    }


}
