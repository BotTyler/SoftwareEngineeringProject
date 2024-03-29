using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SoftwareEngineeringProject.Pages.Database;

namespace SoftwareEngineeringProject.Pages.DatabaseTestPages.Event
{
    public class EventInsertModel : PageModel
    {
        [BindProperty]
        public Database.Event regEvent { get; set; }

        public string statusMsg { get; set; }

        private readonly IConfiguration _configuration;
        public EventInsertModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                EventDB db = new EventDB(_configuration["ApiKey:DefaultKey"]);
                bool isInserted = db.insertEvent(regEvent);
                if (isInserted)
                {
                    statusMsg = "The registration was inserted";
                }
                else
                {
                    statusMsg = "The registration was not inserted";
                }
            }
        }
    }
}
