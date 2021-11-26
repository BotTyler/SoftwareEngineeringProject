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
    public class RegistrationUpdateModel : PageModel
    {
        [BindProperty]
        public Database.Registration[] regList { get; set; }

        private readonly IConfiguration _configuration;
        public RegistrationUpdateModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet()
        {
            RegistrationDB db = new RegistrationDB(_configuration["ApiKey:DefaultKey"]);

            regList = db.selectAllRegisteredEvents();
        }

    }
}
