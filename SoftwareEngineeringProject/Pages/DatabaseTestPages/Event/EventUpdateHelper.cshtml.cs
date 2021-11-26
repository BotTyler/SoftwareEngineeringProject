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
    public class EventUpdateHelperModel : PageModel
    {
        [BindProperty]
        public Database.Event regEvent { get; set; }

        private readonly IConfiguration _configuration;
        public EventUpdateHelperModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet([FromUri] string id)
        {
            EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);
            regEvent = db.selectEventByID(id);
        }

        public void OnPostUpdate()
        {
            if (ModelState.IsValid)
            {
                EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);
                db.updateEvent(regEvent);
                Response.Redirect("/DatabaseTestPages/Event/EventUpdate");
            }
        }
    }
}
