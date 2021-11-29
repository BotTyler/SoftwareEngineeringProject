using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
        }

        public void OnPost()
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
    }
}
