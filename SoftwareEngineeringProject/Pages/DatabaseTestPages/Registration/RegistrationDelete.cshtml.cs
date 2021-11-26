using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages
{
    public class RegistrationDeleteModel : PageModel
    {
        [BindProperty]
        public Database.Registration[] regList { get; set; }

        public string statusMsg { get; set; }

        private readonly IConfiguration _configuration;
        public RegistrationDeleteModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
            RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);

            regList = db.selectAllRegisteredEvents();
        }

        public void OnPostDelete([FromUri] string id)
        {
            if (ModelState.IsValid)
            {
                RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);
                if(db.deleteRegistration(id))
                {
                    statusMsg = "Deleted \'" + id + "\'";
                }
                else
                {
                    statusMsg = "Cannot Delete";
                }
                regList = db.selectAllRegisteredEvents();
            }
        }
    }
}
