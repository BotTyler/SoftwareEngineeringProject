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
                    Response.Redirect("/HomePage");
                }
                else
                {
                    SubmitError = "Submit Failed";
                }
            }
        }

    }
}
