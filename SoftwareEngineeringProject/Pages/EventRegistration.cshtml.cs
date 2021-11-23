using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages
{
    [Authorize]
    public class EventRegistrationModel : PageModel
    {
        [BindProperty]
        public Event regEvent { get; set; }

        public string SubmitError { get; set; }
        private readonly IConfiguration _configuration;

        public EventRegistrationModel(IConfiguration configuration)
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
                regEvent.AvailableSlots = regEvent.NumberOfSlots;
                if(HttpContext.User.FindFirst("ID") != null)
                {
                    regEvent.Owner_ID = HttpContext.User.FindFirst("ID").Value;
                }
                else
                {
                    // could not find theOwner_ID
                    SubmitError = "Cannot find user ID.";
                    return;
                }

                EventDB eventDB = new EventDB(_configuration["ApiKey:DefaultKey"]);
                if (eventDB.insertEvent(regEvent))
                {
                    // everything went through fine
                    SubmitError = "Submit Complete";
                }
                else
                {
                    SubmitError = "Submit Failed";
                }
                /* if (user.verifyUsernameIntegrity() == false || user.verifyPasswordIntegrity() == false)
                 {
                     this.SubmitError = "Please only use characters a-z, 0-9, !, and @";
                 }
                 else
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
                     else if (isAccountCreated == 1)
                     {
                         // username was already found within the database
                         this.SubmitError = "Username is Already Taken";
                     }
                     else
                     {
                         // network error
                         this.SubmitError = "Something Unexpected Happened";
                     }
                }*/

            }
        }

    }
}
