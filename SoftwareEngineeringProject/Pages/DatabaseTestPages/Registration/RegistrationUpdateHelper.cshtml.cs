using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.Registration
{
    public class RegistrationUpdateHelperModel : PageModel
    {
        [BindProperty]
        public Database.Registration registration { get; set; }
        public string statusMsg { get; set; }

        private readonly IConfiguration _configuration;
        public RegistrationUpdateHelperModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet([FromUri] string id)
        {
            RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
            registration = db.selectRegistrationByID(id);
        }

        public void OnPostUpdate()
        {
            if (ModelState.IsValid)
            {
                RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                if(db.updateRegistration(registration))
                {
                    statusMsg = "The Event was updated";
                }
                else
                {
                    statusMsg = "The Event was not updated";

                }
                Response.Redirect("/DatabaseTestPages/Registration/RegistrationUpdate");
            }
        }
    }
}
