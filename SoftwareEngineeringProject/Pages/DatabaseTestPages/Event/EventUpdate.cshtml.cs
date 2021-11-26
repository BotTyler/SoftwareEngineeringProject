using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.Event
{
    public class EventUpdateModel : PageModel
    {
        [BindProperty]
        public Database.Event[] eventList { get; set; }

        private readonly IConfiguration _configuration;
        public EventUpdateModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet()
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            eventList = db.selectAllEvents();
        }

        
    }
}
