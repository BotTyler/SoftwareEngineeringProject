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
    public class EventDeleteModel : PageModel
    {
        [BindProperty]
        public Database.Event[] eventList { get; set; }

        public string statusMsg { get; set; }


        private readonly IConfiguration _configuration;
        public EventDeleteModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);

            eventList = db.selectAllEvents();
        }

        public void OnPostDelete([FromUri] string id)
        {
            if (ModelState.IsValid)
            {
                EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);
                if (db.deleteEvent(id))
                {
                    statusMsg = "Deleted \'" + id + "\'";
                }
                else
                {
                    statusMsg = "Cannot Delete";
                }
                eventList = db.selectAllEvents();
            }
        }
    }
}
