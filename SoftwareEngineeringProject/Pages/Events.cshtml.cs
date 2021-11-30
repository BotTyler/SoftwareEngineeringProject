using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages
{
    public class EventsModel : PageModel
    {
        [BindProperty]
        public Database.Event[] eventList { get; set; }

        [BindProperty]
        public Database.Registration[] regEvents { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a word.")]
        public string searchText { get; set; }

        public string statusMsg { get; set; }
        private readonly IConfiguration _configuration;
        public EventsModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }


        public void OnGet()
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            eventList = db.selectAllEvents();

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                RegistrationDB reg = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);

                regEvents = reg.selectUserRegisteredEventByUserID(HttpContext.User.FindFirst("ID").Value);
            }
        }

        public void OnGetRegister([FromUri] string search)
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            eventList = db.selectEvents(search);

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                RegistrationDB reg = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);

                regEvents = reg.selectUserRegisteredEventByUserID(HttpContext.User.FindFirst("ID").Value);
            }
        }


        public void OnPostSearch()
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            if (ModelState.IsValid)
            {


                eventList = db.selectEvents(searchText);


            }
            else
            {
                eventList = db.selectAllEvents();
            }
        }
        public void OnPostRegister([FromUri] string id)
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                RegistrationDB reg = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                string authenticatedUserID = HttpContext.User.FindFirst("ID").Value;

                Database.Registration registrationHelper = new Database.Registration();

                registrationHelper.UserInfo_ID = authenticatedUserID;
                registrationHelper.Event_ID = id;

                reg.insertRegistration(registrationHelper);
                    Response.Redirect("/Events");

            }
            else
            {
                Response.Redirect("/LoginPage");
            }
        }
        public void OnPostUnregister([FromUri] string id)
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                RegistrationDB reg = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                string authenticatedUserID = HttpContext.User.FindFirst("ID").Value;

                Database.Registration registrationHelper = reg.selectUserRegisteredEventByUserIDAndEventID(authenticatedUserID, id)[0];

                reg.deleteRegistration(registrationHelper._id);

                Response.Redirect("/Events");

            }
            else
            {
                Response.Redirect("/LoginPage");
            }
        }
    }
}
