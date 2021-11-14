using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;
using SoftwareEngineeringProject.Pages.Encryption;

namespace SoftwareEngineeringProject.Pages
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public UserInfoSignup user { get; set; }

        public string SubmitError { get; set; }

        private readonly IConfiguration _configuration;
        public SignupModel(IConfiguration configuration)
        {
            this._configuration = configuration;
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
                user.Confirm = "";
                UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
                int isAccountCreated = db.insertUser(user);
                if (isAccountCreated == 0)
                {
                    // creation successful
                    user.CleanSignupUser();
                    user = new UserInfoSignup();
                    Response.Redirect("/LoginPage");
                }
                else if(isAccountCreated == 1)
                {
                    // username was already found within the database
                    this.SubmitError = "Username is Already Taken";
                }
                else
                {
                    // network error
                    this.SubmitError = "Something Unexpected Happened";
                }
            }
        }
    }
}
