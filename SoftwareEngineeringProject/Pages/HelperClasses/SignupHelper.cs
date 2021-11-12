using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.HelperClasses
{
    public class SignupHelper
    {
        public SignupHelper()
        {

        }

        [BindProperty]
        public int ID { get; set; }
        [BindProperty]
        public string UName { get; set; }
        [BindProperty]
        public string PWord { get; set; }
        [BindProperty]
        public string Confirm { get; set; }
    }
}
