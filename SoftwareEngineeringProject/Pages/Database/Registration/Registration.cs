using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class Registration
    {
        public Registration()
        {

        }
        [BindProperty]
        public string _id { get; set; }

        [BindProperty]
        public string UserInfo_ID { get; set; }

        [BindProperty]
        public string Event_ID { get; set; }
    }
}
