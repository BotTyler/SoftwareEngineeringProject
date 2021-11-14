using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SoftwareEngineeringProject.Pages.Database;
using SoftwareEngineeringProject.Pages.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages
{
    public class LoginPageModel : PageModel
    {

        [BindProperty]
        public UserInfoLogin user { get; set; }

        public string loginError { get; set; }

        private readonly IConfiguration _configuration;

        public LoginPageModel(IConfiguration _configuration)
        {
            this._configuration = _configuration;
        }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid) // Checks to see if all fields are filled properly
            {
                Cipher cipher = new Cipher(new DESCryptoServiceProvider());
                user.Password = cipher.Encrypt(user.Password, user.Password);

                // init the database
                UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                if (db.validateUserInformation(user))
                {
                    // account verified

                    Response.Redirect("/HomePage");
                }
                else
                {
                    // Account information is incorrect give error
                    loginError = "Invalid Login Information";
                }
                //Response.Redirect("/LoginPage");
            }
        }
    }
}
