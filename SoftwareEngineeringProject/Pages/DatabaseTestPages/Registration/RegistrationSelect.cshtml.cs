using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages
{
    public class RegistrationSelectModel : PageModel
    {
        [BindProperty]
        public Database.Registration[] regList { get; set; }
        
        [BindProperty]
        public string searchText { get; set; }

        public string statusMsg { get; set; }
        private readonly IConfiguration _configuration;
        public RegistrationSelectModel(IConfiguration configuration)
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
