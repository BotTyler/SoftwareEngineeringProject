using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class Event
    {
        public Event()
        {

        }
        [BindProperty]
        public string _id { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "An event name is Required!")]
        public string EventName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "An event date is Required!")]
        public DateTime EventDate { get; set; }

        [BindProperty]
        public int NumberOfSlots { get; set; }

        [BindProperty]
        public int AvailableSlots { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "An event description is Required!")]
        public string EventDescription { get; set; }

        [BindProperty]
        public string Owner_ID { get; set; }
    }
}
